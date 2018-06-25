namespace Syncfusion.Report.Server.Api.Helper.V2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Datasource details
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiReportDataSourceUpdate
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
        /// Datasource name
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
