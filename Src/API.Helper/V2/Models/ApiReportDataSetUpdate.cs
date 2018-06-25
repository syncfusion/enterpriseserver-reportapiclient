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
    /// Dataset details
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiReportDataSetUpdate
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
        /// Dataset name
        /// </summary>
        [DataMember]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Dataset description
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
        /// Datasource mapping information
        /// </summary>
        [DataMember]
        public List<DataSourceMappingInfo> DataSourceMappingInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Provide items in an array of bytes
        /// </summary>
        [DataMember]
        public byte[] ItemContent
        {
            get;
            set;
        }
    }
}
