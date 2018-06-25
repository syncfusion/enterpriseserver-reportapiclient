namespace Syncfusion.Report.Server.Api.Helper.V3.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// Runs the schedule on a monthly basis.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiMonthlySchedule
    {
        /// <summary>
        /// Specifies the recurrence type, whether the schedule recurs on a day basis or on the customized day basis. Valid values: `DayRecurrence` `CustomRecurrence` \n\n Note: If you chose the recurrence type as DayRecurrence, provide a value to the DayRecurrence property and leave the (CustomRecurrence) property empty.
        /// </summary>
        [Required]
        [DataMember]
        public string RecurrenceType { get; set; }

        /// <summary>
        /// The schedule recurs on the day specified on the month interval.
        /// </summary>
        [DataMember]
        public ApiMonthlyScheduleDayRecurrence DayRecurrence { get; set; }

        /// <summary>
        /// The schedule recurs on the customized day of the specified month interval.
        /// </summary>
        [DataMember]
        public ApiMonthlyScheduleCustomRecurrence CustomRecurrence { get; set; }
    }
}
