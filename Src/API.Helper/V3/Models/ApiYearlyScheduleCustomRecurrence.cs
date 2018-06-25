namespace Syncfusion.Report.Server.Api.Helper.V3.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// The schedule recurs in the customized month based on the number of years provided in the YearInterval property.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiYearlyScheduleCustomRecurrence
    {
        /// <summary>
        /// Specifies the week of the month the schedule recurs. Valid values: `first` `second` `third` `fourth` `last`. \n\n For example: If you provide second, the schedule will recur on the second week.
        /// </summary>
        [DataMember]
        [Required]
        public string WeekOfMonth { get; set; }

        /// <summary>
        /// Specifies the day of week the schedule recurs. Valid values: `day` `weekday` `weekendday` `Sunday` `Monday` `Tuesday` `Wednesday` `Thursday` `Friday` `Saturday`.\n\n For example: If you provide Sunday, the schedule will recur on every sunday's of the second week.
        /// </summary>
        [DataMember]
        [Required]
        public string DayOfWeek { get; set; }

        /// <summary>
        /// Specifies the month the schedule recurs.  Valid values: `January` `February` `March` `April` `May` `June` `July` `August` `September` `October` `November` `December`. \n\n For example: If you provide March, the schedule will recur on the sunday's of the second week of March every year. Here the (year) is the value provided in the YearInterval property.
        /// </summary>
        [DataMember]
        [Required]
        public string MonthOfYear { get; set; }
    }
}
