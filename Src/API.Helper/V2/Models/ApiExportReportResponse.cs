namespace Syncfusion.Report.Server.Api.Helper.V2.Models
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    [DataContract]
    public class ApiExportReportResponse
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
        /// Returns the exported report in an array of bytes.
        /// </summary>
        [DataMember]
        public byte[] FileContent
        {
            get;
            set;
        }
    }
}
