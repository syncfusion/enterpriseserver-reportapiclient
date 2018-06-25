namespace Syncfusion.Report.Server.Api.Helper.V2.Models
{
    using System;

    /// <summary>
    /// Mapping information of dataset
    /// </summary>
    public class DataSetMappingInfo
    {
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
        public string Name
        {
            get;
            set;
        }
    }
}