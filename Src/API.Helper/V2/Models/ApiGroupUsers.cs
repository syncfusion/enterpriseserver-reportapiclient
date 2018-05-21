namespace Syncfusion.Report.Server.Api.Helper.V2.Models
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Runtime.Serialization;

    /// <summary>
    /// User(s) added/removed from the group.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiGroupUsers
    {
        /// <summary>
        /// List of user IDs
        /// </summary>
        [DataMember]
        public List<int> Id { get; set; }
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }
    }
}
