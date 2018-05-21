namespace Syncfusion.Report.Server.Api.Helper.V2.Models
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;

    /// <summary>
    /// Group Permission details from the server.
    /// </summary>
    public class ApiGroupPermissionDetail
    {
        /// <summary>
        /// Specify an access type for item.
        /// </summary>
        public string PermissionAccess
        {
            get;
            set;
        }

        /// <summary>
        /// Specify an entity of item for permission.
        /// </summary>
        public string PermissionEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Group ID.
        /// </summary>
        public int GroupId
        {
            get;
            set;
        }

        /// <summary>
        /// Item name.
        /// </summary>
        public string ItemName
        {
            get;
            set;
        }

        /// <summary>
        /// Permission ID.
        /// </summary>
        public int PermissionId
        {
            get;
            set;
        }

        /// <summary>
        /// Item ID.
        /// </summary>
        public Guid? ItemId
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
