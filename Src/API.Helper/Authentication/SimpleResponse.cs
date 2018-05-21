using System;
using System.Net;
using System.Runtime.Serialization;

namespace Syncfusion.Report.Server.Api.Helper.Authentication
{
    public class SimpleResponse 
    {
        public bool ApiStatus { get; set; }

        public bool Status { get; set; }

        public string StatusMessage { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }

    }
}
