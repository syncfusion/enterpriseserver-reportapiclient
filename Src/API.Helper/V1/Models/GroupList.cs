using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization;

namespace Syncfusion.Report.Server.Api.Helper.V1.Models
{
    public class Groups
    {
        /// <summary>
        /// List of groups
        /// </summary>
        public List<GroupInfo> GroupList { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }
    }
}
