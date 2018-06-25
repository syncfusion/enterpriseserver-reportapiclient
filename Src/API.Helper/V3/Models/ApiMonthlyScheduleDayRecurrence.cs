namespace Syncfusion.Report.Server.Api.Helper.V3.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// The schedule recurs on the day specified on the month interval.
    /// </summary>
    [DataContract]
    [Serializable]
    public class ApiMonthlyScheduleDayRecurrence
    {
        /// <summary>
        /// Specifies the number of days the schedule recurs. \n\n For example: If you provide 10, the schedule will recur every 10th day. 
        /// </summary>
        [DataMember]
        [Required]
        public int DayInterval { get; set; }

        /// <summary>
        /// Specifies the number of months the schedule recurs. \n\n For example: If you provide 3, the schedule will recur 10th day of every 3 months.
        /// </summary>
        [DataMember]
        [Required]
        public int MonthInterval { get; set; }
    }
}
