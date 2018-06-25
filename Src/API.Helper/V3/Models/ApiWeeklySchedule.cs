namespace Syncfusion.Report.Server.Api.Helper.V3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// Runs the schedule on a weekly basis.
    /// </summary>
    [DataContract]
    [Serializable]
    public class ApiWeeklySchedule
    {
        /// <summary>
        /// Specifies the number of weeks the schedule recurs. \n\n For example: If you provide 2, the schedule will recur every 2 weeks.  
        /// </summary>
        [DataMember]
        [Required]
        public int RecurrenceWeeks { get; set; }

        /// <summary>
        /// Specifies the list of  days the schedule recurs. Valid values `Sunday` `Monday` `Tuesday` `Wednesday` `Thursday` `Friday` `Saturday`. \n\n For example: If you provide `Sunday`, the schedule will recur sunday's of every 2 weeks.
        /// </summary>
        [DataMember]
        [Required]
        public List<string> RecurrenceDays { get; set; }
    }
}
