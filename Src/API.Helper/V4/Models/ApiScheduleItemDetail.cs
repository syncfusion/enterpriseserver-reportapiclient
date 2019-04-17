namespace Syncfusion.Report.Server.Api.Helper.V4.Models
{
    using Syncfusion.Report.Server.Api.Helper.V3.Models;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    [DataContract]
    public class ApiScheduleItemDetail
    {
        /// <summary>
        /// Specifies the user ID of the item creator.
        /// </summary>
        [DataMember]
        public int CreatedById
        {
            get;
            set;
        }

        /// <summary>
        /// Date created of item in date format.
        /// </summary>
        [DataMember]
        public DateTime CreatedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the report export type.
        /// </summary>
        [DataMember]
        public string ExportType
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the the end date of the schedule.
        /// </summary>
        [DataMember]
        public DateTime? EndDate
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the export type id of schedule.
        /// </summary>
        [DataMember]
        public int ExportTypeId
        {
            get;
            set;
        }

        /// <summary>
        /// Returns true, if the Schedule is active.
        /// </summary>
        public bool IsActive
        {
            get;
            set;
        }

        /// <summary>
        /// Returns true, if the Schedule is enabled.
        /// </summary>
        [DataMember]
        public bool IsEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the ItemType.
        /// </summary>
        [DataMember]
        public string ItemType
        {
            get;
            set;
        }

        /// <summary>
        /// Date modified of item in date format.
        /// </summary>
        [DataMember]
        public DateTime ModifiedDate
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the user ID of the item modifier.
        /// </summary>
        [DataMember]
        public int ModifiedById
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the Next scheduled date and time.
        /// </summary>
        [DataMember]
        public DateTime? NextSchedule
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the recurrence information of the schedule.
        /// </summary>
        [DataMember]
        public string RecurrenceInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the recurrence Id of the schedule.
        /// </summary>
        [DataMember]
        public int RecurrenceTypeId
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the recurrence type of the schedule.
        /// </summary>
        [DataMember]
        public string RecurrenceType
        {
            get;
            set;
        }

        /// <summary>
        /// Item ID.
        /// </summary>
        [DataMember]
        public Guid ReportId
        {
            get;
            set;
        }

        /// <summary>
        /// Item name.
        /// </summary>
        [DataMember]
        public string ReportName
        {
            get;
            set;
        }

        /// <summary>
        /// Schedule ID.
        /// </summary>
        [DataMember]
        public Guid ScheduleId
        {
            get;
            set;
        }

        /// <summary>
        /// Schedule name.
        /// </summary>
        [DataMember]
        public string ScheduleName
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the start date of the schedule.
        /// </summary>
        [DataMember]
        public DateTime StartDate
        {
            get;
            set;
        }

        /// <summary>
        /// Sets the schedule with no end when specified as true. \n\n Note: By default, the NeverEnd is set to true. To set the end time for the schedule, fill the properties of either EndAfterOccurrence or EndDate; otherwise remains empty.
        /// </summary>
        [DataMember]
        public bool NeverEnd { get; set; }

        /// <summary>
        /// Specifies the number of occurrences after which the schedule will be completed. \n\n For example: If you provide 5, the schedule will end after the completion of 5 occurrences.
        /// </summary>
        [DataMember]
        public int EndAfterOccurrence { get; set; }

        /// <summary>
        /// Provides the list of username, email, or user IDs to the recipients who will get the schedules.
        /// </summary>
        [DataMember]
        public List<int> UserList { get; set; }

        /// <summary>
        /// Provides the list of group IDs to the recipients in the group list who will get the schedules.
        /// </summary>
        [DataMember]
        public List<int?> GroupList { get; set; }

        /// <summary>
        /// Provides the list of email IDs to the email recipients who will get the schedules. 
        /// </summary>
        [DataMember]
        public List<string> ExternalRecipientsList { get; set; }

        /// <summary>
        /// Runs the schedules on an hourly basis.
        /// </summary>
        [DataMember]
        public ApiHourlySchedule HourlySchedule { get; set; }

        /// <summary>
        /// Runs the schedules on a daily basis. 
        /// </summary>
        [DataMember]
        public ApiDailySchedule DailySchedule { get; set; }

        /// <summary>
        /// Runs the schedule on a weekly basis.
        /// </summary>
        [DataMember]
        public ApiWeeklySchedule WeeklySchedule { get; set; }

        /// <summary>
        /// Runs the schedule on a monthly basis.
        /// </summary>
        [DataMember]
        public ApiMonthlySchedule MonthlySchedule { get; set; }

        /// <summary>
        /// Runs the schedules on a yearly basis.
        /// </summary>
        [DataMember]
        public ApiYearlySchedule YearlySchedule { get; set; }

        /// <summary>
        /// Specify the schedule parameter
        /// </summary>
        [DataMember]
        public List<ApiReportParameter> ReportParameter
        {
            get;
            set;
        }
    }
}
