namespace Syncfusion.Report.Server.Api.Helper.V2.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Net;
    using System.Runtime.Serialization;

    /// <summary>
    /// Validation details of the item.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiValidateItemName
    {
        /// <summary>
        /// Item name.
        /// </summary>
        [Required]
        [DataMember]
        public string ItemName { get; set; }

        /// <summary>
        /// Category name.
        /// </summary>
        [DataMember]
        public string CategoryName { get; set; }

        /// <summary>
        /// Item type.
        /// </summary>
        [Required]
        [DataMember]
        public string ItemType { get; set; }
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }
    }
}
