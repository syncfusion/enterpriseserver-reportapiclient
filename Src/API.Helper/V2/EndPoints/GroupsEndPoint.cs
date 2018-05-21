using Newtonsoft.Json;
using Syncfusion.Report.Server.Api.Helper.V2.Models;

namespace Syncfusion.Report.Server.API.Helper.V2.EndPoints
{
    public class GroupsEndPoint2
    {
        private readonly ServerClientV2 _serverClientV2;
        private readonly string _baseUrl;

        public GroupsEndPoint2(ServerClientV2 serverClientV2)
        {
            _serverClientV2 = serverClientV2;
            _baseUrl = _serverClientV2.BaseUrl;
        }

        /// <summary>
        /// This method is used to add list of users to the particular group.
        /// </summary>
        /// <param name="id">Group id</param>
        /// <param name="apiGroupUsers">List of users to be added.</param>
        /// <returns>Status of adding users to the group.</returns>
         
        public ApiResponse AddUserToGroup(int id, ApiGroupUsers apiGroupUsers)
        {
            var result = _serverClientV2.Post(apiGroupUsers, _baseUrl + "/groups/" + id + "/users");
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
        /// This method is used to delete list of users from the particular group.
        /// </summary>
        /// <param name="id">Group id</param>
        /// <param name="apiGroupUsers">List of users to be deleted.</param>
        /// <returns>Status of deleting users from the group.</returns>

        public ApiResponse DeleteUserFromGroup(int id, ApiGroupUsers apiGroupUsers)
        {
            var overrideUrl = _baseUrl + "/groups/" + id + "/users";
            var result = _serverClientV2.Delete(apiGroupUsers, overrideUrl);
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiResponse>(result.Content);
            }
            else
            {
                return new ApiResponse {
                ApiStatus = true,
                StatusMessage = "User has been deleted successfully from the group."};
            }
        }
    }
}
