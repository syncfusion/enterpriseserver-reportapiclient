namespace Syncfusion.Report.Server.Api.Helper.V2.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// Details about the report to be exported
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiExportReport
    {
        /// <summary>
        /// Report ID.
        /// </summary>
        [DataMember]
        public Guid ReportId
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the relative URL of the report.
        /// </summary>
        [DataMember]
        public string ServerPath
        {
            get;
            set;
        }

        /// <summary>
        /// Export type.
        /// </summary>
        [DataMember]
        [Required]
        public string ExportType
        {
            get;
            set;
        }
    }
}
