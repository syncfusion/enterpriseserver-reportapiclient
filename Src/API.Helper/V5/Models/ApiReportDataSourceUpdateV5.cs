namespace Syncfusion.Report.Server.Api.Helper.V5.Models
{
    using Syncfusion.Report.Server.Api.Helper.V2.Models;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// Datasource details
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiReportDataSourceUpdateV5
    {
        /// <summary>
        /// Item ID
        /// </summary>
        [DataMember]
        [Required]
        public Guid ItemId
        {
            get;
            set;
        }

        /// <summary>
        /// Current Datasource name
        /// </summary>
        [DataMember]
        public string DataSourceName
        {
            get;
            set;
        }

        /// <summary>
        /// Updating Datasource name
        /// </summary>
        [DataMember]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Datasource description
        /// </summary>
        [DataMember]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Comments about update
        /// </summary>
        [DataMember]
        public string VersionComment
        {
            get;
            set;
        }

        /// <summary>
        /// Datasource definition
        /// </summary>
        [DataMember]
        public DataSourceDefinition DataSourceDefinition
        {
            get;
            set;
        }
    }
}
