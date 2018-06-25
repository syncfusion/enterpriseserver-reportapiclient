namespace Syncfusion.Report.Server.Api.Helper.V3.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// The schedule recurs on the month and number of years specified in YearInterval property.
    /// </summary>
    [DataContract]
    [Serializable]
    public class ApiYearlyScheduleMonthRecurrence
    {
        /// <summary>
        /// Specifies the month the schedule recurs. Valid values: `January` `February` `March` `April` `May` `June` `July` `August` `September` `October` `November` `December`. \n\n For example: If you provide April, the schedule will recur in April of every year. Here the (year) is the value provided in the YearInterval property.
        /// </summary>
        [DataMember]
        [Required]
        public string MonthOfYear { get; set; }

        /// <summary>
        /// Specifies the day of the month the schedule recurs. \n\n For example: If you provide 20, the schedule will recur 20th April of every year.  Here the (year) is the value provided in the YearInterval property.
        /// </summary>
        [DataMember]
        [Required]
        public int DayOfMonth { get; set; }
    }
}
