namespace Syncfusion.Report.Server.Api.Helper.V2.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// File details
    /// </summary>
    public class ApiFileAdd
    {
        /// <summary>
        /// File name
        /// </summary>
        [DataMember]
        [Required]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// File description
        /// </summary>
        [DataMember]
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// Provide the file extension to save the item
        /// </summary>
        [DataMember]
        [Required]
        public string Extension
        {
            get;
            set;
        }

        /// <summary>
        /// Provide items in an array of bytes
        /// </summary>
        [DataMember]
        [Required]
        public byte[] ItemContent
        {
            get;
            set;
        }
    }
}
