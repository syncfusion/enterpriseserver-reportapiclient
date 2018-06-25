namespace Syncfusion.Report.Server.Api.Helper.V2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// User detail
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiUserAdd
    {
        /// <summary>
        /// Email address of the user.
        /// </summary>
        [DataMember]
        [Required]
        public string Email
        {
            get;
            set;
        }

        /// <summary>
        /// First name of the user.
        /// </summary>
        [DataMember]
        [Required]
        public string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// Last name of the user.
        /// </summary>
        [DataMember]
        public string Lastname
        {
            get;
            set;
        }

        /// <summary>
        /// Username of the user.
        /// </summary>
        [DataMember]
        [Required]
        public string Username
        {
            get;
            set;
        }

        /// <summary>
        /// Password of the user.
        /// </summary>
        [DataMember]
        public string Password
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