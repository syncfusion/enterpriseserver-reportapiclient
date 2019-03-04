namespace Syncfusion.Report.Server.Api.Helper.V5.Models
{
    using System;

    /// <summary>
    /// Mapping information of dataset
    /// </summary>
    public class DataSetMappingInfoV5
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Dataset ID
        /// </summary>
        public Guid DataSetId
        {
            get;
            set;
        }

        /// <summary>
        /// Dataset name
        /// </summary>
        public string DataSetName
        {
            get;
            set;
        }
    }
}
