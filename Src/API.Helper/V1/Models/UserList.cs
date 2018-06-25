using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization;

namespace Syncfusion.Report.Server.Api.Helper.V1.Models
{
    public class Users
    {
        /// <summary>
        /// List of users
        /// </summary>
        public List<UserInfo> UserList { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }
    }
}
