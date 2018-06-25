namespace Syncfusion.Report.Server.Api.Helper.Authentication
{
    using RestSharp;
    using System.Collections.Generic;

    public abstract class Authenticate
    {
        protected RestClient Client;

        public virtual DataResponse<T> GetResponse<T>(string url, Method method, T body, Dictionary<string, object> requestParameters)
        {
            var executeMethod = typeof(RequestExecutor).GetMethod("ExecuteRequest");
            var generic = executeMethod.MakeGenericMethod(typeof(T));
            return (DataResponse<T>)generic.Invoke(this, new object[] { url, method, body, Client, requestParameters});
        }
    }
}