namespace Syncfusion.Report.Server.Api.Helper.V5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// Report details
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiReportUpdateV5
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
        /// Report name
        /// </summary>
        [DataMember]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Report description
        /// </summary>
        [DataMember]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Category ID
        /// </summary>
        [DataMember]
        [Required]
        public Guid CategoryId
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
        /// Specify the relative Path of the item
        /// </summary>
        [DataMember]
        public string ServerPath
        {
            get;
            set;
        }

        /// <summary>
        /// Specify true to set item as public
        /// </summary>
        [DataMember]
        public bool IsPublic
        {
            get;
            set;
        }

        /// <summary>
        /// Dataset mapping information
        /// </summary>
        [DataMember]
        public List<DataSetMappingInfoV5> DataSetMappingInfo
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
