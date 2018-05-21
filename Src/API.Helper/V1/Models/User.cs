using System.Net;
using System.Runtime.Serialization;

namespace Syncfusion.Report.Server.Api.Helper.V1.Models
{
    public class User
    {
        /// <summary>
        /// Username of the user.
        /// </summary>
        public string Username
        {
            get;
            set;
        }

        /// <summary>
        /// First name of the user.
        /// </summary>
        public string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// Last name of the user.
        /// </summary>
        public string Lastname
        {
            get;
            set;
        }

        /// <summary>
        /// Email address of the user.
        /// </summary>
        public string Email
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
