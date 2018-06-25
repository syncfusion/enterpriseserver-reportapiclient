namespace Syncfusion.Report.Server.Api.Helper.V2.Models
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;

    /// <summary>
    /// User activation or deactivation request
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiUserActivationRequest
    {
        /// <summary>
        /// Status update for the user.
        /// </summary>
        [DataMember]
        public bool Activate { get; set; }
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }
    }
}
