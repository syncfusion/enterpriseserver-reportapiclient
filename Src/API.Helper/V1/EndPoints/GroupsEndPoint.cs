using Newtonsoft.Json;
using Syncfusion.Report.Server.Api.Helper.Authentication;
using Syncfusion.Report.Server.Api.Helper.V1;
using Syncfusion.Report.Server.Api.Helper.V1.Models;
using System.Collections.Generic;

namespace Syncfusion.Report.Server.API.Helper.V1.EndPoints
{
    public class GroupsEndPoint
    {
        private readonly ServerClientV1 _serverClientV1;
        private readonly string _baseUrl;

        public GroupsEndPoint(ServerClientV1 serverClientV1)
        {
            _serverClientV1 = serverClientV1;
            _baseUrl = _serverClientV1.BaseUrl + "/groups";
        }

        /// <summary>
        /// This method is used to get all groups on the server.
        /// </summary>
        /// <returns>List of groups</returns>
        public Groups GetAllGroups()
        {
            var groups = new Groups
            {
                GroupList = new List<GroupInfo>()
            };
            var result = _serverClientV1.Get(groups, _baseUrl);
            if(result != null)
            {
                return JsonConvert.DeserializeObject<Groups>(result.Content);
            }
            else
            {
                return new Groups();
            } 
        }

        /// <summary>
        /// This method is used to get group details from the server.
        /// </summary>
        /// <param name="groupId">Group Id.</param>
        /// <returns>Details of the specified group.</returns>
        public Group GetGroup(int groupId)
        {
            var requestUrl = _baseUrl + "/" + groupId;
            var result = _serverClientV1.Get(new Group(), requestUrl);
            if(result != null)
            {
                return JsonConvert.DeserializeObject<Group>(result.Content);
            }
           else
            {
                return new Group();
            }
        }

        /// <summary>
        /// Get the list of users on the server for the specified group
        /// </summary>
        /// <param name="id">ID of the group.</param>
        /// <returns>Returns a list of users on the server for the specified group.</returns>
        public Users GetGroupMembers(int id)
        {
            var requestUrl = _baseUrl + "/" + id + "/users";
            var result =  _serverClientV1.Get(new Users(), requestUrl);
            if(result != null)
            {
                return JsonConvert.DeserializeObject<Users>(result.Content);
            }
            else
            {
                return new Users();
            }
        }

        /// <summary>
        /// This mehod is used to create a group.
        /// </summary>
        /// <param name="group">Group name, description</param>
        /// <returns>Status of creating the group.</returns>
        public SimpleResponse CreateGroup(Group group)
        {
            var result =_serverClientV1.Post(group, _baseUrl);
            if(result != null)
            {
                return JsonConvert.DeserializeObject<SimpleResponse>(result.Content);
            }
            else
            {
                return new SimpleResponse();
            }
        }

        /// <summary>
        /// This method is used to update the group details.
        /// </summary>
        /// <param name="groupId">Group Id</param>
        /// <param name="group">Group name and description</param>
        /// <returns>Status of updating the group</returns>
        public SimpleResponse UpdateGroup(int groupId, Group group)
        {
            var requestUrl = _baseUrl + "/" + groupId;
            var result = _serverClientV1.Put(group, requestUrl);
            if(result != null)
            {
                return JsonConvert.DeserializeObject<SimpleResponse>(result.Content);
            }
            else
            {
                return new SimpleResponse();
            }
        }

        /// <summary>
        /// To remove a group from the Server
        /// </summary>
        /// <param name="groupId">Group Id</param>
        /// <returns>Status of removing the user fromm the group.</returns>
        public SimpleResponse DeleteGroup(int groupId)
        {
            var overrideUrl = _baseUrl + "/" + groupId;
            var result = _serverClientV1.Delete(new User(), overrideUrl);
            if(result != null)
            {
                return JsonConvert.DeserializeObject<SimpleResponse>(result.Content);
            }
            else
            {
                return new SimpleResponse
                {
                    ApiStatus = true,
                    StatusMessage = "Group has been deleted successfully."
                };
            }
        }
    }
}
