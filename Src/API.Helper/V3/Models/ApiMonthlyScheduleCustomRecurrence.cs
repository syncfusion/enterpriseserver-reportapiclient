namespace Syncfusion.Report.Server.Api.Helper.V3.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// The schedule recurs on the customized day of the specified month interval.
    /// </summary>
    [DataContract]
    [Serializable]
    public class ApiMonthlyScheduleCustomRecurrence
    {
        /// <summary>
        /// Specifies the week of the month the schedule recurs. Valid values: `first` `second` `third` `fourth` `last`. \n\n For example: If you provide second, the schedule will recur on the second week.
        /// </summary>
        [DataMember]
        [Required]
        public string WeekOfMonth { get; set; }

        /// <summary>
        /// Specifies the day of the week the schedule recurs. Valid values: `day` `weekday` `weekendday` `Sunday` `Monday` `Tuesday` `Wednesday` `Thursday` `Friday` `Saturday`. \n\n For example: If you provide Sunday, the schedule will recur on the second week of sunday.
        /// </summary>
        [DataMember]
        [Required]
        public string DayOfWeek { get; set; }

        /// <summary>
        /// Specifies the number of months the schedule recurs. \n\n For example: If you provide 5, the schedule will recur second week of sunday's of every 5 months.
        /// </summary>
        [DataMember]
        [Required]
        public int MonthInterval { get; set; }
    }
}
