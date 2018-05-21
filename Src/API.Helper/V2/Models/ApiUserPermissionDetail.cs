namespace Syncfusion.Report.Server.Api.Helper.V2.Models
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;

    /// <summary>
    /// User permission details from the server.
    /// </summary>
    public class ApiUserPermissionDetail
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
        /// User ID.
        /// </summary>
        public int UserId
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
