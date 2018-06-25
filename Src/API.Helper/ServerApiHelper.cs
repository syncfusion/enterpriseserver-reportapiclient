using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using Syncfusion.Report.Server.Api.Helper.Utilities;
using Syncfusion.Report.Server.Api.Helper.Authentication;

namespace Syncfusion.Report.Server.API.Helper
{
    public class ServerApiHelper
    {
        private Authenticate _authenticator;

        public string BaseUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="serverUrl"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public OAuth2 Connect(string serverUrl, string username, string password)
        {
            _authenticator = new OAuth2(serverUrl, username, password);
            ((OAuth2)_authenticator).GetToken();
            return (OAuth2)_authenticator;
        }

        private DataResponse<T> Send<T>(T body, Method method, string overrideUrl = null, Dictionary<string, object> requestParameters = null)
        {
            var relativeUrl = overrideUrl;
            DataResponse<T> response;
            try
            {
                response = _authenticator.GetResponse(relativeUrl, method, body, requestParameters);
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
                response = default(DataResponse<T>);
            }
            return response;
        }

        internal DataResponse<T> Get<T>(T body, string overrideUrl, object requestParameters = null)
        {
            var parameterDictionary = requestParameters.ToDictionary();
            return Send(body, Method.GET, overrideUrl, parameterDictionary);
        }

        internal DataResponse<T> Post<T>(T body, string overrideUrl, object requestParameters = null)
        {
            var parameterDictionary = requestParameters.ToDictionary();
            return Send(body, Method.POST, overrideUrl, parameterDictionary);
        }

        internal DataResponse<T> Put<T>(T body, string overrideUrl, object requestParameters = null)
        {
            var parameterDictionary = requestParameters.ToDictionary();
            return Send(body, Method.PUT, overrideUrl, parameterDictionary);
        }

        internal DataResponse<T> Delete<T>(T body, string overrideUrl, object requestParameters = null)
        {
            var parameterDictionary = requestParameters.ToDictionary();
            return Send(body, Method.DELETE, overrideUrl, parameterDictionary);
        }
    }
}
