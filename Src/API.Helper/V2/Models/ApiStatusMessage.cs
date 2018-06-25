namespace Syncfusion.Report.Server.Api.Helper.V2.Models
{
    using System.Net;
    using System.Runtime.Serialization;

    public class ApiStatusMessage
    {
        /// <summary>
        /// Returns the status message from the API.
        /// </summary>
        [DataMember]
        public string StatusMessage
        {
            get;
            set;
        }

        /// <summary>
        /// Returns the Link from  API.
        /// </summary>
        [DataMember]
        public string Link
        {
            get;
            set;
        }
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }
    }
}
