namespace Syncfusion.Report.Server.Api.Helper.V2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Net;
    using System.Runtime.Serialization;

    /// <summary>
    /// Contains CSV user import request.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiCsvUserImportRequest
    {
        /// <summary>
        /// Provides the CSV file in an array of bytes.
        /// </summary>
        [DataMember]
        [Required]
        public byte[] CsvFileContent
        {
            get;
            set;
        }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public HttpStatusCode StatusCode { get; set; }
    }
}
