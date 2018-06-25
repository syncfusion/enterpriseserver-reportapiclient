namespace Syncfusion.Report.Server.Api.Helper.V3.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// Runs the schedules on an hourly basis.
    /// </summary>
    [DataContract]
    [Serializable]
    public class ApiHourlySchedule
    {
        /// <summary>
        /// Specifies the hour interval. Based on this interval the schedule will run continuously until the end time. The format should be `HH:mm`.
        /// </summary>
        [DataMember]
        [Required]
        public string ScheduleInterval { get; set; }
    }
}
