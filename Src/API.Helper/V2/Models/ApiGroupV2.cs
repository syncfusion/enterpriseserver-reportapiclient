namespace Syncfusion.Report.Server.Api.Helper.V2.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    [Serializable]
    [DataContract]
    public class ApiGroupV2
    {
        /// <summary>
        /// Description of the group.
        /// </summary>
        [DataMember]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// ID of the group.
        /// </summary>
        [DataMember]
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Returns true if the group is added from Active Directory
        /// </summary>
        [DataMember]
        public bool IsActiveDirectoryGroup
        {
            get;
            set;
        }

        /// <summary>
        /// Returns true if the group is added from Azure Active Directory
        /// </summary>
        [DataMember]
        public bool IsAzureADGroup
        {
            get;
            set;
        }

        /// <summary>
        /// Name of the group.
        /// </summary>
        [DataMember]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// User(s) count
        /// </summary>
        [DataMember]
        public int UserCount
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