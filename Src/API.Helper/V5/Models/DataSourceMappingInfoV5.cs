namespace Syncfusion.Report.Server.Api.Helper.V5.Models
{
    using System;

    /// <summary>
    /// Mapping information of datasource
    /// </summary>
    public class DataSourceMappingInfoV5
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
        /// Datasource ID
        /// </summary>
        public Guid DataSourceId
        {
            get;
            set;
        }

        /// <summary>
        /// Datasource name
        /// </summary>
        public string DataSourceName
        {
            get;
            set;
        }
    }
}
