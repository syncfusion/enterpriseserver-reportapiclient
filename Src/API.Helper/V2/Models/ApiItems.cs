namespace Syncfusion.Report.Server.Api.Helper.V2.Models
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Runtime.Serialization;

    /// <summary>
    /// Details of items.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiItems
    {
        /// <summary>
        /// Specifies the read permission of the item.
        /// </summary>
        [DataMember]
        public bool CanRead { get; set; }

        /// <summary>
        /// Specifies the write permission of the item.
        /// </summary>
        [DataMember]
        public bool CanWrite { get; set; }

        /// <summary>
        /// Specifies the delete permission of the item.
        /// </summary>
        [DataMember]
        public bool CanDelete { get; set; }

        /// <summary>
        /// Specifies the download permission of the item.
        /// </summary>
        [DataMember]
        public bool CanDownload { get; set; }

        /// <summary>
        /// Specifies the schedule permission of the item.
        /// </summary>
        [DataMember]
        public bool CanSchedule { get; set; }

        /// <summary>
        /// Specifies the open permission of the item.
        /// </summary>
        [DataMember]
        public bool CanOpen { get; set; }

        /// <summary>
        /// Specifies the move permission of the item.
        /// </summary>
        [DataMember]
        public bool CanMove { get; set; }

        /// <summary>
        /// Specifies the copy permission of the item.
        /// </summary>
        [DataMember]
        public bool CanCopy { get; set; }

        /// <summary>
        /// Specifies the clone permission of the item.
        /// </summary>
        [DataMember]
        public bool CanClone { get; set; }

        /// <summary>
        /// Specifies the create permission of the item.
        /// </summary>
        [DataMember]
        public bool CanCreateItem { get; set; }

        /// <summary>
        /// Item ID
        /// </summary>
        [DataMember]
        public Guid Id { get; set; }

        /// <summary>
        /// Item type.
        /// </summary>
        [DataMember]
        public string ItemType { get; set; }

        /// <summary>
        /// Item name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Item description.
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Item location.
        /// </summary>
        [DataMember]
        public string ItemLocation
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the user ID of the item creator.
        /// </summary>
        [DataMember]
        public int CreatedById { get; set; }

        /// <summary>
        /// Specifies the display name of the user who created the item.
        /// </summary>
        [DataMember]
        public string CreatedByDisplayName { get; set; }

        /// <summary>
        /// Specifies the user ID of the item modifier.
        /// </summary>
        [DataMember]
        public int ModifiedById { get; set; }

        /// <summary>
        /// Specifies the full name of the user who modified the item.
        /// </summary>
        [DataMember]
        public string ModifiedByFullName { get; set; }

        /// <summary>
        /// Category ID.
        /// </summary>
        [DataMember]
        public Guid? CategoryId { get; set; }

        /// <summary>
        /// Category name.
        /// </summary>
        [DataMember]
        public string CategoryName { get; set; }

        /// <summary>
        /// Date created of item in string format.
        /// </summary>
        [DataMember]
        public string CreatedDate { get; set; }

        /// <summary>
        /// Date modified of item in string format.
        /// </summary>
        [DataMember]
        public string ModifiedDate { get; set; }

        /// <summary>
        /// Date modified of item in date format.
        /// </summary>
        [DataMember]
        public DateTime ItemModifiedDate { get; set; }

        /// <summary>
        /// Date created of item in date format.
        /// </summary>
        [DataMember]
        public DateTime ItemCreatedDate { get; set; }

        /// <summary>
        /// Returns true if the dashboard is multi-dashboard.
        /// </summary>
        [DataMember]
        public bool IsMultiDashboard { get; set; }

        /// <summary>
        /// Returns true if it is a favorite item.
        /// </summary>
        [DataMember]
        public bool IsFavorite { get; set; }

        /// <summary>
        /// Returns true if the item is public.
        /// </summary>
        [DataMember]
        public bool IsPublic { get; set; }       

        /// <summary>
        /// Returns link of the file
        /// </summary>
        [DataMember]
        public string FileLink { get; set; }

        /// <summary>
        /// Returns extension of the file
        /// </summary>
        [DataMember]
        public string Extension { get; set; }
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }
    }
}
