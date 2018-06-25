namespace Syncfusion.Report.Server.Api.Helper.V2.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// Details about the favorite item.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiUpdateFavoriteReport
    {
        /// <summary>
        /// Report ID.
        /// </summary>
        [DataMember]
        [Required]
        public Guid ReportId { get; set; }

        /// <summary>
        /// Specify true to set the item as a favorite item.
        /// </summary>
        [DataMember]
        [Required]
        public bool Favorite { get; set; }
    }
}
