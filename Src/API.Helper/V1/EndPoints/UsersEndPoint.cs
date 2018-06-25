using System.Collections.Generic;
using Syncfusion.Report.Server.Api.Helper.Authentication;
using Newtonsoft.Json;
using Syncfusion.Report.Server.Api.Helper.V1;
using Syncfusion.Report.Server.Api.Helper.V1.Models;

namespace Syncfusion.Report.Server.API.Helper.V1.EndPoints
{
    public class UsersEndPoint
    {
        private readonly ServerClientV1 _serverClientV1;
        private readonly string _baseUrl;

        public UsersEndPoint(ServerClientV1 serverClientV1)
        {
            _serverClientV1 = serverClientV1;
            _baseUrl = _serverClientV1.BaseUrl + "/users";
        }

        /// <summary>
        /// This method is used to get the list of users.
        /// </summary>
        /// <returns> List of users from the server.</returns>
        public Users GetAllUsers()
        {
            var users = new Users
            {
                UserList = new List<UserInfo>()
            };
            var result =  _serverClientV1.Get(users, _baseUrl);
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
        /// This method is used to get the details of the specified user.
        /// </summary>
        /// <param name="user">Username or Email id of the user</param>
        /// <returns>User details.</returns>
        public User GetUser(string user)
        {
            var overrideUrl = _baseUrl + "/" + user;
            var result =  _serverClientV1.Get(new User(), overrideUrl);
            if(result != null)
            {
                return JsonConvert.DeserializeObject<User>(result.Content);
            }
            else
            {
                return new User();
            }
        }

        /// <summary>
        /// This method is used to create a user.
        /// </summary>
        /// <param name="user">Use details (username, firstname, lastname, email) to be added.</param>
        /// <returns>Status of creating the user.</returns>
        public SimpleResponse CreateUser(User user)
        {
            var result = _serverClientV1.Post(user, _baseUrl);
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
        /// This method is used to update the user details.
        /// </summary>
        /// <param name="userId">User name or emailid</param>
        /// <param name="user">User details (email, firstname, lastname, contact number)</param>
        /// <returns>Status of updating the user</returns>
        public SimpleResponse UpdateUser(string userId, User user)
        {
            var requestUrl = _baseUrl + "/" + userId;
            var result = _serverClientV1.Put(user, requestUrl);
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
        /// This method is used to delete a user.
        /// </summary>
        /// <param name="userId">User name or email id</param>
        /// <returns>Status of deleting the user.</returns>
        public SimpleResponse DeleteUser(string userId)
        {
            var requestUrl = _baseUrl + "/" + userId;
            var result = _serverClientV1.Delete(new User(), requestUrl);
            if(result != null)
            {
                return JsonConvert.DeserializeObject<SimpleResponse>(result.Content);
            }
            else
            {
                return new SimpleResponse
                {
                    ApiStatus = true,
                    StatusMessage = "User has been deleted successfully."
                };
            }
        }
    }
}
