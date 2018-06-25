using Newtonsoft.Json;
using Syncfusion.Report.Server.Api.Helper.V2.Models;
using System.Collections.Generic;

namespace Syncfusion.Report.Server.API.Helper.V2.EndPoints
{
    public class PermissionEndPoint
    {
        private readonly ServerClientV2 _serverClientV2;
        private readonly string _baseUrl;

        public PermissionEndPoint(ServerClientV2 serverClientV2)
        {
            _serverClientV2 = serverClientV2;
            _baseUrl = _serverClientV2.BaseUrl;
        }

        /// <summary>
        /// This method is used to get the list of permissions of a specific user.
        /// </summary>
        /// <param name="id">User Id</param>
        /// <returns>list of permissions of a specific user.</returns>

        public List<ApiUserPermissionDetail> GetUserPermission(int id)
        {
            var requestUrl = _baseUrl + "/permissions/users/" + id;
            var userpermission = new List<ApiUserPermissionDetail>();
            var result =  _serverClientV2.Get(userpermission, requestUrl);
            if(result != null)
            {
                return JsonConvert.DeserializeObject<List<ApiUserPermissionDetail>>(result.Content);
            }
            else
            {
               return userpermission;
            }
        }

        /// <summary>
        /// This method is used to get the list of permissions of a specific group.
        /// </summary>
        /// <param name="id">Group Id</param>
        /// <returns>List of permissions of a specific group.</returns>

        public List<ApiGroupPermissionDetail> GetGroupPermission(int id)
        {
            var requestUrl = _baseUrl + "/permissions/groups/" + id;
            var grouppermission = new List<ApiGroupPermissionDetail>();
            var result =  _serverClientV2.Get(grouppermission, requestUrl);
            if(result != null)
            {
                return JsonConvert.DeserializeObject<List<ApiGroupPermissionDetail>>(result.Content);
            }
            else
            {
                return grouppermission;
            }
        }

        /// <summary>
        /// This method is used to add new permissions to specific users on the server.
        /// </summary>
        /// <param name="apiUserPermissionAdd">Permission details (permission access type, user id, permission entity, item id) to be added to the specified user.</param>
        /// <returns>Status of adding new permissions to specific users.</returns>
        
        public ApiResponse AddUserPermission(ApiUserPermissionAdd apiUserPermissionAdd)
        {
            var result = _serverClientV2.Post(apiUserPermissionAdd, _baseUrl + "/permissions/users");
            var response = new ApiResponse();
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiResponse>(result.Content);
            }
            else
            {
                return response;
            }
        }

        /// <summary>
        /// This method is used to add new permissions to the specific group on the server.
        /// </summary>
        /// <param name="apiGroupPermissionAdd">Permission details (permission access type, group id, permission entity, item id) to be added to the specified group.</param>
        /// <returns>Status of adding new permissions to specific group.</returns>

        public ApiResponse AddGroupPermission(ApiGroupPermissionAdd apiGroupPermissionAdd)
        {
            var result = _serverClientV2.Post(apiGroupPermissionAdd, _baseUrl + "/permissions/groups");
            var response = new ApiResponse();
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiResponse>(result.Content);
            }
            else
            {
                return response;
            }
        }

        /// <summary>
        /// This method is used to delete the specific user permissions on the server.
        /// </summary>
        /// <param name="id">User permission id</param>
        /// <returns>Status of deleting specific user permissions on the server.</returns>

        public ApiResponse DeleteUserPermission(int id)
        {
            var requestUrl = _baseUrl + "/permissions/users/" + id;
            var permission = new List<Permission>() { };
            var result = _serverClientV2.Delete(permission, requestUrl);
            if(result != null)
            {
                return JsonConvert.DeserializeObject<ApiResponse>(result.Content);
            }
            else
            {
                return new ApiResponse { ApiStatus = true, StatusMessage = "User permission has been deleted successfully." };
            }
            
        }

        /// <summary>
        ///  This method is used to delete the specific group permissions on the server.
        /// </summary>
        /// <param name="id">Group permission id</param>
        /// <returns>Status of deleting specific group permissions on the server.</returns>

        public ApiResponse DeleteGroupPermission(int id)
        {
            var requestUrl = _baseUrl + "/permissions/groups/" + id;
            var permission = new List<Permission>() { };
            var result = _serverClientV2.Delete(permission, requestUrl);
            if(result != null)
            {
                return JsonConvert.DeserializeObject<ApiResponse>(result.Content);
            }
            else
            {
                return new ApiResponse { ApiStatus = true, StatusMessage = "Group permission has been deleted successfully."};
            }
        }
    }
}