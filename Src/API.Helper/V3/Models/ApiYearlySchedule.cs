namespace Syncfusion.Report.Server.Api.Helper.V3.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// Runs the schedules on a yearly basis.
    /// </summary>
    [DataContract]
    [Serializable]
    public class ApiYearlySchedule
    {
        /// <summary>
        /// Specifies the number of years the schedule recurs. \n\n For example: If you provide 5, the schedule will recur every 5 years.
        /// </summary>
        [DataMember]
        [Required]
        public int YearInterval { get; set; }

        /// <summary>
        /// Specifies the recurrence type, whether the schedule recurs on a month basis or on the customized month basis. Valid values: `MonthRecurrence` `CustomRecurrence`. \n\n Note: If you chose the recurrence type as MonthRecurrence, provide a value to the MonthRecurrence property, and leave the (CustomRecurrence) property empty.
        /// </summary>
        [DataMember]
        [Required]
        public string RecurrenceType { get; set; }

        /// <summary>
        /// The schedule recurs on the month and number of years specified in YearInterval property.
        /// </summary>
        [DataMember]
        public ApiYearlyScheduleMonthRecurrence MonthRecurrence { get; set; }

        /// <summary>
        /// The schedule recurs in the customized month based on the number of years provided in the YearInterval property.
        /// </summary>
        [DataMember]
        public ApiYearlyScheduleCustomRecurrence CustomRecurrence { get; set; }
    }
}
