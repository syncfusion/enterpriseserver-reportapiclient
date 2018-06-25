namespace Syncfusion.Report.Server.Api.Helper.V2.Models
{
    using System;

    /// <summary>
    /// Mapping information of datasource
    /// </summary>
    public class DataSourceMappingInfo
    {
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
        public string Name
        {
            get;
            set;
        }
    }
}