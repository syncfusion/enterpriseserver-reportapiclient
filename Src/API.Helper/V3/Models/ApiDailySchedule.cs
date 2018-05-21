namespace Syncfusion.Report.Server.Api.Helper.V3.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    ///  Runs the schedules on a daily basis. 
    /// </summary>
    [DataContract]
    [Serializable]
    public class ApiDailySchedule
    {
        /// <summary>
        /// Specifies the recurrence type, whether the schedule recurs every day or every working day.  Valid values: `EveryNdays` `EveryWeekday`. \n\n Note: If you chose the recurrence type as EveryNdays, provide a value to the EveryNdays property, and leave the (EveryWeekday) property empty.
        /// </summary>
        [DataMember]
        [Required]
        public string RecurrenceType { get; set; }

        /// <summary>
        /// Specifies the number of days the schedule recurs. \n\n For example: If you provide 2, the schedule recurs every 2 days.
        /// </summary>
        [DataMember]
        public int EveryNdays { get; set; }

        /// <summary>
        /// For the schedule to recur every working day, set to true.
        /// </summary>
        [DataMember]
        public bool EveryWeekday { get; set; }
    }
}
