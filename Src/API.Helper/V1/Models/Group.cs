using System;
using System.Net;
using System.Runtime.Serialization;

namespace Syncfusion.Report.Server.Api.Helper.V1.Models
{
    public class Group
    {
        /// <summary>
        /// Name of the group.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the group.
        /// </summary>
        public string Description { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }
    }
}
