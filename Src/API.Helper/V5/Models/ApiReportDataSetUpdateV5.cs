namespace Syncfusion.Report.Server.Api.Helper.V5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// Dataset details
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiReportDataSetUpdateV5
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
        public string DataSetName
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
        public List<DataSourceMappingInfoV5> DataSourceMappingInfo
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