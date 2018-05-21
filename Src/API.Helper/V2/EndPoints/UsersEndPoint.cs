using Newtonsoft.Json;
using Syncfusion.Report.Server.Api.Helper.V2.Models;
using System.Web.Http;

namespace Syncfusion.Report.Server.API.Helper.V2.EndPoints
{
    public class UsersEndPoint2
    {
        private readonly ServerClientV2 _serverClientV2;
        private readonly string _baseUrl;

        public UsersEndPoint2(ServerClientV2 serverClientV2)
        {
            _serverClientV2 = serverClientV2;
            _baseUrl = _serverClientV2.BaseUrl;
        }

        /// <summary>
        /// This method is used to add a user with password to the server.
        /// </summary>
        /// <param name="user">User details (Email, first name, last name, username, password) to be added.</param>
        /// <returns>Status of adding new user.</returns>
         
        public ApiStatusMessage AddUserV2(ApiUserAdd user)
        {
            var result = _serverClientV2.Post(user, _baseUrl + "/users");
            if(result != null)
            {
                return JsonConvert.DeserializeObject<ApiStatusMessage>(result.Content);
            }
            else
            {
                return new ApiStatusMessage();
            }
        }

        /// <summary>
        ///  This method is used to get the group details of particular users from the server.
        /// </summary>
        /// <param name="user">User id, username or email of the user.</param>
        /// <returns>List of groups of the user.</returns>
        
        public ApiGroupListV2 GetGroupsOfUser(string user)
        {
            var overrideUrl = _baseUrl + "/users/" + user + "/groups";
            var result = _serverClientV2.Get(new ApiGroupListV2(), overrideUrl);
            if(result != null)
            {
                return JsonConvert.DeserializeObject<ApiGroupListV2>(result.Content);
            }
            else
            {
                return new ApiGroupListV2 {
                    Message = "User doesnot belong to any group"
                };
            }
        }

        /// <summary>
        /// Used to download the CSV templates from the server.
        /// </summary>
        /// <returns>CSV template file.</returns>
         
        public ApiDownloadCsvTemplate DownloadCsvTemplate()
        {
            var overrideUrl = _baseUrl + "/csv-users/download-template";
            var result = _serverClientV2.Get(new ApiDownloadCsvTemplate(), overrideUrl);
            if(result != null)
            {
                return JsonConvert.DeserializeObject<ApiDownloadCsvTemplate>(result.Content);
            }
            else
            {
                return new ApiDownloadCsvTemplate();
            }
        }

        /// <summary>
        /// This method is used to add a CSV of users to the server.
        /// </summary>
        /// <param name="apiCsvUserImportRequest">CSV file in an array of bytes.</param>
        /// <returns>Status of adding users from the CSV file.</returns>
        public ApiCsvUserImportResponse CsvUserImport(ApiCsvUserImportRequest apiCsvUserImportRequest)
        {            
            var result = _serverClientV2.Post(apiCsvUserImportRequest, _baseUrl + "/csv-users");
            var response = new ApiCsvUserImportResponse();
            if (result != null)
            {
                return JsonConvert.DeserializeObject<ApiCsvUserImportResponse>(result.Content);
            }
            else
            {
                return response;
            }
        }

        /// <summary>
        /// This method is used to activate or de-activate the user account in the server.
        /// </summary>
        /// <param name="user">Username or email id of the user.</param>
        /// <param name="activationRequest">Status to activate or deactivate the user.</param>
        /// <returns>Status of activate or deactivate the user.</returns>
        
        public ApiResponse ActivateDeactivateuser([FromUri] string user, [FromBody] ApiUserActivationRequest activationRequest)
        {
            var requestUrl = _baseUrl + "/users/" + user;
            var result = _serverClientV2.Put(activationRequest, requestUrl);
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
    }
}