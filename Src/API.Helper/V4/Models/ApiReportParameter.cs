namespace Syncfusion.Report.Server.Api.Helper.V4.Models
{
    using Syncfusion.Report.Server.Api.Helper.V3.Models;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    [DataContract]
    public class ApiReportParameter
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public List<string> Values { get; set; }
    }
}
