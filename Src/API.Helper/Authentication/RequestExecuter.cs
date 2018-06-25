using RestSharp;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Syncfusion.Report.Server.Api.Helper.Authentication
{
    internal class RequestExecutor
    {
        public static DataResponse<T> ExecuteRequest<T>(string url, Method method, T body, RestClient client, IDictionary<string, object> requestParameters) where T : new()
        {
            var request = new RestRequest(url, method);
            if (requestParameters != null)
            {
                foreach (var requestParameter in requestParameters)
                {
                    request.AddParameter(requestParameter.Key, requestParameter.Value);
                }
            }
            if (ShouldAddBody(method))
            {
                request.RequestFormat = DataFormat.Json;
                request.AddJsonBody(body);
            }

            var result = client.Execute<List<object>>(request);
         
            if(result.StatusCode.ToString() == HttpStatusCode.NoContent.ToString() && result.ErrorException != null)
            {
                return null;
            }
        
            if (RequestingSimpleType<T>())
            {
                return result.Content as dynamic;
            }
            return new DataResponse<T>
            {
                Content = result.Content,
                Data = result.Data,
                StatusCode = result.StatusCode
            };
        }

        private static bool ShouldAddBody(Method method)
        {
            return method == Method.PUT || method == Method.POST || method == Method.DELETE;
        }

        private static bool RequestingSimpleType<T>() where T : new()
        {
            return typeof(T) == typeof(object);
        }
    }
}
