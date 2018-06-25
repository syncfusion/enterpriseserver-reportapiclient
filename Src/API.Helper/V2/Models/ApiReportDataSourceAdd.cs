namespace Syncfusion.Report.Server.Api.Helper.V2.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// Datasource details
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiReportDataSourceAdd
    {
        /// <summary>
        /// Datasource name
        /// </summary>
        [DataMember]
        [Required]
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
