namespace Syncfusion.Report.Server.Api.Helper.V2.Models
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;

    /// <summary>
    /// Contains response of downloaded CSV template file.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiDownloadCsvTemplate
    {
        /// <summary>
        /// Returns the status of the API.
        /// </summary>
        [DataMember]
        public bool ApiStatus
        {
            get;
            set;
        }

        /// <summary>
        /// Returns status of the API request.
        /// </summary>
        [DataMember]
        public bool Status
        {
            get;
            set;
        }

        /// <summary>
        /// Returns the status message from the API.
        /// </summary>
        [DataMember]
        public string StatusMessage
        {
            get;
            set;
        }

        /// <summary>
        /// Returns CSV file in array of bytes.
        /// </summary>
        [DataMember]
        public byte[] FileContent
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
