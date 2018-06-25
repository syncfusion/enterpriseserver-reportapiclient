namespace Syncfusion.Report.Server.Api.Helper.V2.Models
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;

    public class Permission
    {
        /// <summary>
        /// To state whether user can delete the permission or not.
        /// </summary>
        public bool CanDelete
        {
            get;
            set;
        }

        /// <summary>
        /// To find the report item corresponds to which category
        /// </summary>
        public string CategoryName
        {
            get;
            set;
        }

        /// <summary>
        /// Id of the group
        /// </summary>
        public int GroupId
        {
            get;
            set;
        }

        /// <summary>
        /// Name of the group
        /// </summary>
        public string GroupName
        {
            get;
            set;
        }

        /// <summary>
        /// To check whether the permission is user permission or group permission
        /// </summary>
        public bool IsUserPermission
        {
            get;
            set;
        }

        /// <summary>
        /// Id of the Item
        /// </summary>
        public Guid? ItemId
        {
            get;
            set;
        }

        /// <summary>
        /// Name of the Item e.g. FIFA World Cup2014-Brazil etc.
        /// </summary>
        public string ItemName
        {
            get;
            set;
        }

        /// <summary>
        ///  Enum type property to store the multiple constants like Category=1, report=3 etc.
        /// </summary>
        public ItemType ItemType
        {
            get;
            set;
        }

        /// <summary>
        /// Description for the enum Itemtype  e.g.Report,DataSet etc.
        /// </summary>
        public string ItemTypeDescription
        {
            get;
            set;
        }

        /// <summary>
        /// Enum type property to store the multiple constants like  Read=2,ReadWrite=6 etc.
        /// </summary>
        public PermissionAccess PermissionAccess
        {
            get;
            set;
        }

        /// <summary>
        /// Description for the enum PermissionAccess e.g. Read, Write, Delete
        /// </summary>
        public string PermissionAccessDescription
        {
            get;
            set;
        }

        /// <summary>
        /// Enum type property to store the multiple constants like  All Reports=1 etc.
        /// </summary>
        public PermissionEntity PermissionEntity
        {
            get;
            set;
        }

        /// <summary>
        ///  Description for the enum PermissionEntity e.g. Specific Category, All Category, Specific Dashborads etc.
        /// </summary>
        public string PermissionEntityDescription
        {
            get;
            set;
        }

        /// <summary>
        /// ID of each permission
        /// </summary>
        public int PermissionId
        {
            get;
            set;
        }

        /// <summary>
        /// To state whether the permission belongs to a user or group
        /// </summary>
        public int TargetId
        {
            get;
            set;
        }

        /// <summary>
        /// Full Name of user
        /// </summary>
        public string UserFullName
        {
            get;
            set;
        }

        /// <summary>
        /// Id of User
        /// </summary>
        public int UserId
        {
            get;
            set;
        }

        /// <summary>
        /// UserName of user
        /// </summary>
        public string UserName
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