namespace Syncfusion.Report.Server.Api.Helper.V4.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    [DataContract]
    public class ApiReportParameters
    {

        [DataMember]
        public List<ApiReportParameter> ReportParameter
        {
            get;
            set;
        }
    }
}
