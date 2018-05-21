namespace Syncfusion.Report.Server.Api.Helper.V2.Models
{
    using System.ComponentModel;
    using System.Runtime.Serialization;

    public enum ActivationType
    {
        [Description("Automatic Activation")]
        AutomaticActivation = 0,

        [Description("Email Activation")]
        EmailActivation
    }

    /// <summary>
    ///     SQL Aggregate functions
    /// </summary>
    public enum AggregateMethod
    {
        /// <summary>
        ///     Aggregation will not be applied
        /// </summary>
        None,

        /// <summary>
        ///     Returns the number of rows
        /// </summary>
        COUNT,

        /// <summary>
        ///     Returns the Maximum value in the given column
        /// </summary>
        MAX,

        /// <summary>
        ///     Returns the Minimum value in the given column
        /// </summary>
        MIN,

        /// <summary>
        ///     Returns the Average of the given column
        /// </summary>
        AVG,

        /// <summary>
        ///     Returns the SUM of the given column
        /// </summary>
        SUM,

        /// <summary>
        ///     Returns the Standard deviation of the given column
        /// </summary>
        STDEV,

        /// <summary>
        ///     Returns the variance of all the values in the given column
        /// </summary>
        VAR
    }

    public enum AuthenticationType
    {
        [Description("Windows")]
        Windows,

        [Description("SQL Server")]
        SqlServer
    }

    public enum AzureBlobConnectionType
    {
        https,
        http,
        CustomEndPoint
    }

    public enum CommentAction
    {
        Add,
        Edit,
        Delete,
        GetComments
    }

    /// <summary>
    ///     SQL Conditions
    /// </summary>
    public enum Condition
    {
        /// <summary>
        ///     No Condition will be applied
        /// </summary>
        None,

        /// <summary>
        ///     Applies Equal Operator
        /// </summary>
        Equals,

        /// <summary>
        ///     Applies Not Equal Operator
        /// </summary>
        NotEquals,

        /// <summary>
        ///     Applies Lesser than Operator
        /// </summary>
        LessThan,

        /// <summary>
        ///     Applies Greater than Operator
        /// </summary>
        GreaterThan,

        /// <summary>
        ///     Applies Lesser than or Equal Operator
        /// </summary>
        LessThanOrEquals,

        /// <summary>
        ///     Applies Greater than or Equals Operator
        /// </summary>
        GreaterThanOrEquals,

        /// <summary>
        ///     Applies for NULL values
        /// </summary>
        IS,

        /// <summary>
        ///     Applies for NULL values
        /// </summary>
        IN,

        /// <summary>
        ///     Applies for NULL values
        /// </summary>
        LIKE,

        NOTIN
    }

    public enum DatabaseLogType
    {
        [Description("None")]
        None = 0,

        [Description("Restored")]
        Restored = 1,

        [Description("backed up")]
        BackedUp
    }

    public enum DatabaseType
    {
        [Description("MSSQL")]
        MSSQL,

        [Description("MySQL")]
        MySQL,

        [Description("MSSQLCE")]
        MSSQLCE,

        [Description("ORACLE")]
        Oracle,

        [Description("PostgreSQL")]
        PostgreSQL
    }

    /// <summary>Values for days of the week (Monday, Tuesday, etc.)</summary>
    public enum DayOfTheWeek
    {
        /// <summary>Sunday</summary>
        Sunday = 0,

        /// <summary>Monday</summary>
        Monday,

        /// <summary>Tuesday</summary>
        Tuesday,

        /// <summary>Wednesday</summary>
        Wednesday,

        /// <summary>Thursday</summary>
        Thursday,

        /// <summary>Friday</summary>
        Friday,

        /// <summary>Saturday</summary>
        Saturday,

        /// <summary> Days</summary>
        day,

        /// <summary>Week days</summary>
        weekday,

        /// <summary> Week End days</summary>
        weekendday
    }

    /// <summary>Defines the end type of schedule</summary>
    public enum EndType
    {
        /// <summary>Specifies the schedule with an end date</summary>
        EndDate,

        /// <summary>Specifies the schedule with no end date</summary>
        NoEndDate,

        /// <summary>Specifies the schedule to end after n occurrences</summary>
        EndAfter,
    }

    public enum EntityType
    {
        [Description("Specific Type Entity")]
        SpecificType = 0,

        [Description("All Type Entity")]
        AllType = 1,

        [Description("In Type Entity")]
        InType = 2
    }

    public enum ErrorCode
    {
        [Description("None")]
        None = 0,

        // user errors
        [Description("User account not found.")]
        UserNotFound = 1001,
        [Description("User detail not found.")]
        UserDetailNotFound = 1002,
        [Description("Invalid user ID.")]
        UserIdInvalid = 1003,
        [Description("Invalid Password.")]
        PasswordInvalid = 1004,
        [Description("Active Directory credentials invalid.")]
        ADCredentialsInvalid = 1005,
        [Description("Email address exceeds the limit of 255 characters.")]
        EmailLengthExceeded = 1006,
        [Description("Username exceeds the limit of 100 characters.")]
        UsernameLengthExceeded = 1007,
        [Description("Username field is empty. ")]
        UsernameEmpty = 1008,
        [Description("Email address field is empty. ")]
        EmailEmpty = 1009,
        [Description("Password field is empty.")]
        PasswordEmpty = 1010,
        [Description("User ID is empty.")]
        UserIdEmpty = 1011,
        [Description("User account has been deactivated.")]
        UserAccountDeactivated = 1012,
        [Description("User account has been deleted.")]
        UserAccountDeleted = 1013,

        //accounts
        [Description("User account activation link has expired.")]
        UserAccountActivationLinkExpired = 1014,
        [Description("Failed to reset the password recovery code.")]
        PasswordRecoveryCodeResetFailed = 1015,
        [Description("Password recovery code is invalid.")]
        PasswordRecoveryCodeInvalid = 1016,
        [Description("Failed to update the password.")]
        UpdatePasswordFailed = 1017,
        [Description("Access denied for resending activation code.")]
        ResendActivationCodeAccessDenied = 1018,
        [Description("Invalid activation code.")]
        ActivationCodeInvalid = 1019,
        [Description("Invalid Azure User ID.")]
        AzureUserIdInvalid = 1020,
        [Description("Azure User ID is empty.")]
        AzureUserIdEmpty = 1021,

        // item errors
        [Description("Invalid item ID.")]
        ItemIdInvalid = 2001,
        [Description("Item is not public.")]
        ItemNotPublic = 2002,
        [Description("Item ID is empty.")]
        ItemIdEmpty = 2003,
        [Description("Item name is empty.")]
        ItemNameEmpty = 2004,
        [Description("Item name already exists.")]
        ItemNameAlreadyExists = 2005,
        [Description("Item type is empty.")]
        ItemTypeEmpty = 2006,
        [Description("Invalid item type.")]
        ItemTypeInvalid = 2007,
        [Description("Item details not found.")]
        ItemDetailNotFound = 2008,
        [Description("Item logs not found.")]
        ItemLogsNotFound = 2009,
        [Description("Category name is empty.")]
        CategoryNameEmpty = 2010,
        [Description("Category ID is empty.")]
        CategoryIdEmpty = 2011,
        [Description("Category name already exists.")]
        CategoryNameAlreadyExists = 2012,
        [Description("Destination category ID is empty.")]
        DestinationCategoryIdEmpty = 2013,
        [Description("Item type ID is empty.")]
        ItemTypeIdEmpty = 2014,
        [Description("Access mode is empty.")]
        AccessModeEmpty = 2015,
        [Description("Item version detail is not found.")]
        ItemVersionDetailNotFound = 2016,
        [Description("File is empty.")]
        FileEmpty = 2017,
        [Description("Export type is empty.")]
        ExportTypeEmpty = 2018,
        [Description("Failed to export item.")]
        ExportItemFailed = 2019,
        [Description("Access denied for the item.")]
        ItemAccessDenied = 2020,
        [Description("Access denied to add item.")]
        AddItemAccessDenied = 2021,
        [Description("Access denied to edit item.")]
        EditItemAccessDenied = 2022,
        [Description("View ID is empty.")]
        ViewIdEmpty = 2023,
        [Description("Access denied for itemview.")]
        ItemViewAccessDenied = 2024,
        [Description("Itemview is not active.")]
        ItemViewNotActive = 2025,
        [Description("Itemview detail is not found.")]
        ItemViewDetailNotFound = 2026,
        [Description("Failed to add category.")]
        AddCategoryFailed = 2027,
        [Description("Failed to update category.")]
        UpdateCategoryFailed = 2028,
        [Description("Failed to move item.")]
        MoveItemFailed = 2029,
        [Description("Failed to copy item.")]
        CopyItemFailed = 2030,
        [Description("Failed to clone item.")]
        CloneItemFailed = 2031,
        [Description("View name is empty.")]
        ViewNameEmpty = 2032,
        [Description("View name already exists.")]
        ViewNameAlreadyExists = 2033,
        [Description("Query string is empty.")]
        QueryStringEmpty = 2034,
        [Description("Failed to save itemview.")]
        SaveItemViewFailed = 2035,
        [Description("Failed to publish file.")]
        PublishFileFailed = 2036,
        [Description("Failed to update dashboard.")]
        UpdateDashboardFailed = 2037,
        [Description("Failed to update data source.")]
        UpdateDataSourceFailed = 2038,
        [Description("Failed to update widget.")]
        UpdateWidgetFailed = 2039,
        [Description("No favorite items.")]
        FavoriteItemsEmpty = 2040,
        [Description("Failed to update favorite item.")]
        UpdateFavoriteItemFailed = 2041,
        [Description("Categories with create access is empty.")]
        CategoriesWithCreateAccessEmpty = 2042,
        [Description("Failed to mark unwatch.")]
        UnwatchFailed = 2043,
        [Description("Failed to mark watch.")]
        WatchFailed = 2044,
        [Description("Failed to delete item.")]
        DeleteItemFailed = 2045,
        [Description("Failed to add user item permission.")]
        AddUserItemPermissionFailed = 2046,
        [Description("Failed to add group item permission.")]
        AddGroupItemPermissionFailed = 2047,
        [Description("Failed to rollback.")]
        RollBackFailed = 2048,
        [Description("Failed to get system settings.")]
        GetSystemSettingsFailed = 2049,
        [Description("Failed to download item.")]
        DownloadItemFailed = 2050,
        [Description("Access denied for assigning permission to yourself.")]
        AssigningPermissionToYourselfAccessDenied = 2051,
        [Description("Access mode is invalid")]
        AccessModeInvalid = 2052,
        [Description("Access denied to delete item.")]
        DeleteItemAccessDenied = 2053,
        [Description("SSO settings disabled.")]
        SsoSettingsDisabled = 2054,
        [Description("Invalid version Id.")]
        VersionIdInvalid = 2055,
        [Description("Shared data sources server path is empty.")]
        SharedDataSourceServerPathEmpty = 2056,
        [Description("No shared data sources found.")]
        SharedDatasourceNotFound = 2057,

        //report errors
        [Description("Data source name is empty.")]
        DataSourceNameEmpty = 2058,
        [Description("Data source ID is empty.")]
        DataSourceIdEmpty = 2059,
        [Description("Target ID is empty.")]
        TargetIdEmpty = 2060,
        [Description("Failed to add dataset.")]
        AddDataSetFailed = 2061,
        [Description("Failed to add data source.")]
        AddDataSourceFailed = 2062,
        [Description("Dataset name is empty.")]
        DataSetNameEmpty = 2063,
        [Description("Dataset ID is empty.")]
        DataSetIdEmpty = 2064,
        [Description("Failed to add report.")]
        AddReportFailed = 2065,
        [Description("Failed to download data source.")]
        DownloadDataSourceFailed = 2066,
        [Description("Failed to download report.")]
        DownloadReportFailed = 2067,
        [Description("Failed to download dataset.")]
        DownloadDataSetFailed = 2068,
        [Description("Failed to download file.")]
        DownloadFileFailed = 2069,
        [Description("Failed to get item view.")]
        GetItemViewFailed = 2070,
        [Description("Failed to update dataset.")]
        UpdateDatasetFailed = 2071,
        [Description("Failed to update report.")]
        UpdateReportFailed = 2072,
        [Description("Published ID is empty.")]
        PublishedIdEmpty = 2073,
        [Description("Invalid category name.")]
        CategoryNameInvalid = 2074,
        [Description("Invalid item name.")]
        ItemNameInvalid = 2075,
        [Description("Invalid view name.")]
        ViewNameInvalid = 2076,
        [Description("Failed to update public item.")]
        UpdatePublicItemFailed = 2077,
        [Description("Items not found.")]
        ItemsNotFound = 2078,
        [Description("Item versions not found.")]
        ItemVersionNotFound = 2079,
        [Description("Mark as public has been restricted.")]
        MarkPublicItemRestricted = 2080,
        [Description("Item Info is Empty.")]
        ItemInfoEmpty = 2081,
        [Description("Failed to add dashboard.")]
        AddDashboardFailed = 2082,
        [Description("Failed to add Widget.")]
        AddWidgetFailed = 2083,
        [Description("Invalid Category Id")]
        CategoryIdInvalid = 2084,
        [Description("DataSource details is empty")]
        DataSourceDetailsEmpty = 2085,
        [Description("Prompt value is empty")]
        PromptValueEmpty = 2086,
        [Description("Extension value is empty")]
        ExtensionEmpty = 2087,
        [Description("Name cannot exceed 254 characters")]
        ItemNameExceedslimit = 2088,
        [Description("Description cannot exceed 1024 characters")]
        ItemDescriptionExceedslimit = 2089,
        [Description("Failed to add file")]
        AddFileFailed = 2090,
        [Description("Failed to update file")]
        UpdateFileFailed = 2091,
        [Description("Failed to get cache expired time")]
        GetCacheExpiredTimeFailed = 2092,
        [Description("Category details not found.")]
        CategoryDetailNotFound = 2093,
        [Description("Failed to validate item name.")]
        ItemNameValidationFailed = 2094,
        [Description("Invalid export type.")]
        ExportTypeInvalid = 2095,
        [Description("Failed to get shared data sources.")]
        GetSharedDataSourceFailed = 2096,
        [Description("Failed to get favorite items.")]
        GetFavoriteItemsFailed = 2097,
        [Description("Failed to get public items.")]
        GetPublicItemsFailed = 2098,
        [Description("Failed to get storage type.")]
        GetStorageTypeFailed = 2099,
        [Description("Failed to get item location.")]
        GetItemLocationFailed = 2100,
        [Description("Name cannot exceed 100 characters.")]
        ScheduleNameExceedslimit = 2101,
        [Description("Failed to add schedule.")]
        AddScheduleFailed = 2102,
        [Description("Recipients list is empty.")]
        RecipientsListEmpty = 2103,
        [Description("Failed to add subscribed users.")]
        AddSubscribedUsersFailed = 2104,
        [Description("Failed to add subscribed groups.")]
        AddSubscribedGroupsFailed = 2105,
        [Description("Failed to add external recipients.")]
        AddExternalRecipientsFailed = 2106,
        [Description("Invalid schedule type.")]
        ScheduleTypeInvalid = 2106,
        [Description("Schedule type is empty.")]
        ScheduleTypeEmpty = 2107,
        [Description("Schedule interval is empty.")]
        ScheduleIntervalEmpty = 2108,
        [Description("Invalid schedule interval.")]
        ScheduleIntervalInvalid = 2109,
        [Description("End time should not be lower than the schedule interval.")]
        EndTimeShouldNotBeLowerThanScheduleInterval = 2110,
        [Description("End time should not be lower than the start time.")]
        EndTimeShouldNotBeLowerThanStartTime = 2111,
        [Description("Start time is empty.")]
        StartTimeEmpty = 2112,
        [Description("Invalid start time.")]
        StartTimeInvalid = 2113,
        [Description("Invalid end time.")]
        EndTimeInvalid = 2114,
        [Description("Recurrence type of daily schedule is empty.")]
        DailyScheduleRecurrenceTypeEmpty = 2115,
        [Description("Recurrence type of daily schedule is invalid.")]
        DailyScheduleRecurrenceTypeInvalid = 2116,
        [Description("EveryNDays is invalid.")]
        EveryNDaysIsInvalid = 2117,
        [Description("EveryWeekDay is invalid.")]
        EveryWeekDayInvalid = 2118,
        [Description("Invalid recurrence week.")]
        RecurrenceWeekInvalid = 2119,
        [Description("Week day is empty.")]
        WeekDaysEmpty = 2120,
        [Description("Invalid week days.")]
        WeekDaysInvalid = 2121,
        [Description("Ends after occurrence is invalid.")]
        EndAfterOccurrenceInvalid = 2122,
        [Description("Recurrence type of monthly schedule is empty.")]
        MonthlyScheduleRecurrenceTypeEmpty = 2123,
        [Description("Recurrence type of monthly schedule is invalid.")]
        MonthlyScheduleRecurrenceTypeInvalid = 2124,
        [Description("Invalid day interval.")]
        DayIntervalInvalid = 2125,
        [Description("Invalid month interval.")]
        MonthIntervalInvalid = 2126,
        [Description("Day of the week is empty.")]
        DayOfWeekIsEmpty = 2127,
        [Description("Day of the week is invalid.")]
        DayOfWeekIsInvalid = 2128,
        [Description("Week of the month is empty.")]
        WeekOfMonthIsEmpty = 2129,
        [Description("Week of the month is invalid.")]
        WeekOfMonthIsInvalid = 2130,
        [Description("Year interval is invalid.")]
        YearIntervalInvalid = 2131,
        [Description("Recurrence type of yearly schedule is empty.")]
        YearlyScheduleRecurrenceTypeEmpty = 2132,
        [Description("Recurrence type of yearly schedule is invalid.")]
        YearlyScheduleRecurrenceTypeInvalid = 2133,
        [Description("Month of the year is empty.")]
        MonthOfYearIsEmpty = 2134,
        [Description("Month of the year is invalid.")]
        MonthOfYearIsInvalid = 2135,
        [Description("Day of the month is invalid.")]
        DayOfMonthIsInvalid = 2136,
        [Description("Schedule failed to run.")]
        ScheduleRunFailed = 2137,

        // general errors
        [Description("Server version is not available.")]
        ServerVersionNotAvailable = 3001,
        [Description("Encrypted string is empty.")]
        EncryptedStringEmpty = 3002,
        [Description("Decryption key is empty.")]
        DecryptionKeyEmpty = 3003,
        [Description("Validation key is empty.")]
        ValidationKeyEmpty = 3004,
        [Description("Supplied validation key does not match our key.")]
        ValidationKeyMismatch = 3005,
        [Description("Supplied decryption key does not match our key.")]
        DecryptionKeyMismatch = 3006,
        [Description("Error in database while executing the query.")]
        DatabaseError = 3007,
        [Description("Connection string is empty.")]
        ConnectionStringEmpty = 3008,
        [Description("Internal Server Error.")]
        InternalServerError = 3009,
        [Description("Current request is empty.")]
        RequestEmpty = 3010,
        [Description("Failed to extract zip file.")]
        ExtractZipFileFailed = 3011,
        [Description("Failed to create zip file.")]
        CreateZipFileFailed = 3012,
        [Description("File path is empty.")]
        FilePathEmpty = 3013,
        [Description("Failed to read the file contents.")]
        ReadFileContentFailed = 3014,
        [Description("Failed to write the file contents to the path.")]
        WriteFileContentToPathFailed = 3015,
        [Description("No records found.")]
        RecordsNotFound = 3016,
        [Description("Request type was not POST.")]
        InvalidPostRequestType = 3017,
        [Description("Request type was not PUT.")]
        InvalidPutRequestType = 3018,
        [Description("Request type was not DELETE.")]
        InvalidDeleteRequestType = 3019,
        [Description("Request type was not GET.")]
        InvalidGetRequestType = 3020,
        [Description("Invalid connection string.")]
        ConnectionStringInvalid = 3021,
        [Description("Server type is empty.")]
        ServerTypeEmpty = 3022,
        [Description("Invalid URL.")]
        UrlInvalid = 3023,
        [Description("Email settings are not configured.")]
        EmailSettingsNotConfigured = 3024,
        [Description("Invalid filter ID.")]
        FilterIdInvalid = 3025,

        //usermanagement errors
        [Description("Group list is empty.")]
        GroupListEmpty = 4001,
        [Description("Invalid group ID.")]
        GroupIdInvalid = 4002,
        [Description("Group detail was not found.")]
        GroupDetailNotFound = 4003,
        [Description("User already exists in the group.")]
        UserAlreadyExistsInGroup = 4004,
        [Description("Failed to get user detail.")]
        GetUserDetailFailed = 4005,
        [Description("Failed to check whether the group is active or not.")]
        CheckGroupStatusFailed = 4006,
        [Description("Failed to add group.")]
        AddGroupFailed = 4007,
        [Description("User list is empty.")]
        UserListEmpty = 4008,
        [Description("Group ID is empty.")]
        GroupIdEmpty = 4009,
        [Description("Group name already exists.")]
        GroupNameAlreadyExists = 4010,
        [Description("Group name filed is empty.")]
        GroupNameEmpty = 4011,
        [Description("Failed to add user to the group.")]
        AddUserToGroupFailed = 4012,
        [Description("Username already exists.")]
        UsernameAlreadyExists = 4013,
        [Description("Email address already exists.")]
        EmailAddressAlreadyExists = 4014,
        [Description("Failed to add user.")]
        AddUserFailed = 4015,
        [Description("Access to delete the group was denied.")]
        DeleteGroupAccessDenied = 4016,
        [Description("First name field is empty.")]
        FirstNameEmpty = 4017,
        [Description("Failed to delete the group.")]
        DeleteGroupFailed = 4018,
        [Description("Failed to delete the user from the group.")]
        DeleteUserFromGroupFailed = 4019,
        [Description("Failed to update user profile detail.")]
        UpdateUserProfileDetailFailed = 4020,
        [Description("Failed to delete the user.")]
        DeleteUserFailed = 4021,
        [Description("Access to update the user profile was denied.")]
        UpdateUserProfileAccessDenied = 4022,
        [Description("Access denied for updating user profile picture.")]
        UpdateUserProfilePictureAccessDenied = 4023,
        [Description("Old password does not match the current password.")]
        PasswordMismatch = 4024,
        [Description("Access denied for updating user password.")]
        UpdateUserPasswordAccessDenied = 4025,
        [Description("Group detail is empty.")]
        GroupDetailEmpty = 4026,
        [Description("Failed to update group.")]
        UpdateGroupFailed = 4027,
        [Description("Current time is empty.")]
        CurrentTimeEmpty = 4028,
        [Description("Failed to get the formatted time.")]
        GetFormattedTimeFailed = 4029,
        [Description("Access to delete the user was denied.")]
        DeleteUserAccessDenied = 4030,
        [Description("Access denied for the API.")]
        ApiAccessDenied = 4031,

        [Description("Invalid group name.")]
        GroupNameInvalid = 4032,
        [Description("Invalid username.")]
        UsernameInvalid = 4033,
        [Description("Invalid email address.")]
        EmailAddressInvalid = 4034,
        [Description("Invalid first name.")]
        FirstNameInvalid = 4035,
        [Description("Invalid last name.")]
        LastNameInvalid = 4036,
        [Description("Invalid Phone number.")]
        PhoneNumberInvalid = 4037,
        [Description("Old password is empty.")]
        OldPasswordEmpty = 4038,
        [Description("Access to update group was denied.")]
        UpdateGroupAccessDenied = 4039,
        [Description("Failed to download CSV template file.")]
        DownloadCsvTemplateFailed = 4040,
        [Description("Failed to add CSV users.")]
        AddCsvUsersFailed = 4041,
        [Description("Users exceed the user license limit.")]
        UserLicenseExceeded = 4042,
        [Description("Invalid CSV file.")]
        CsvFileInvalid = 4043,
        [Description("Failed to activate or deactivate user account.")]
        ActivateDeActivateUserFailed = 4044,
        [Description("Access denied for updating user status.")]
        UpdateUserStatusAccessDenied = 4045,
        [Description("User is already inactive.")]
        UserAlreadyInactive = 4046,
        [Description("User is already active.")]
        UserAlreadyActive = 4047,
        [Description("Failed to get group details.")]
        GetGroupDetailsFailed = 4048,

        //comment errors
        [Description("Comment is empty.")]
        CommentEmpty = 5001,
        [Description("Invalid comment ID.")]
        CommentIdInvaild = 5002,
        [Description("Comment detail is empty.")]
        CommentDetailEmpty = 5003,
        [Description("Comment URL is empty.")]
        CommentUrlEmpty = 5004,
        [Description("Club ID is empty.")]
        ClubIdEmpty = 5005,
        [Description("Log ID list is empty.")]
        LogIdListEmpty = 5006,
        [Description("Failed to notify through e-mail.")]
        NotifyThroughEmailFailed = 5007,
        [Description("Old comment is empty.")]
        OldCommentEmpty = 5008,
        [Description("New comment is empty.")]
        NewCommentEmpty = 5009,
        [Description("Access denied for editing the comment.")]
        EditCommentAccessDenied = 5010,
        [Description("Access denied for deleting the comment.")]
        DeleteCommentAccessDenied = 5011,
        [Description("Notification is empty.")]
        NotificationEmpty = 5012,
        [Description("Failed to mark the notification as read.")]
        MarkNotificationAsReadFailed = 5013,
        [Description("Comment Id is empty")]
        CommentIdEmpty = 5014,

        //permission
        [Description("Permission entity is empty.")]
        PermissionEntityEmpty = 6001,
        [Description("Scope ID is empty.")]
        ScopeIdEmpty = 6002,
        [Description("Invalid permission entity.")]
        PemissionEntityInvalid = 6003,
        [Description("Invalid scope Id.")]
        ScopeIdInvalid = 6004,
        [Description("Permission already exists.")]
        PermissionAlreadyExists = 6005,
        [Description("Failed to add group permission.")]
        AddPermissionToGroupFailed = 6006,
        [Description("Group permission is empty.")]
        GroupPermissionEmpty = 6007,
        [Description("Failed to add user permission.")]
        AddPermissionToUserFailed = 6008,
        [Description("User permission is empty.")]
        UserPermissionEmpty = 6009,
        [Description("Permission ID is empty.")]
        PermissionIdEmpty = 6010,
        [Description("Failed to remove permission.")]
        RemovePermissionFailed = 6011,

        //Custom Expression
        [Description("Expression Name is empty.")]
        EmptyExpressionName = 6012,
        [Description("Invalid Id.")]
        InvalidId = 6013,
        [Description("Invalid permission access.")]
        PermissionAccessInvalid = 6014,

        //Token Authentication
        [Description("Authentication Token is invalid.")]
        AuthenticationTokenInvalid = 7000,
        [Description("Authentication Token is empty.")]
        AuthenticationTokenEmpty = 7001,
    }

    public enum ExceptionCollection
    {
        [Description("Group category exist")]
        GroupCategoryExist,

        [Description("No Exception")]
        NoException,

        [Description("Sql exception")]
        SqlException,

        [Description("UserExists")]
        UserExists,

        [Description("UserNotFound")]
        UserNotFound,

        [Description("GroupNotFound")]
        GroupNotFound
    }

    public enum ExportType
    {
        [Description("None")]
        None = 0,

        [Description("Excel")]
        Excel = 1,

        [Description("Html")]
        Html,

        [Description("PDF")]
        Pdf,

        [Description("Word")]
        Word,

        [Description("Image")]
        Image,

        [Description("PPT")]
        PPT,

        [Description("CSV")]
        CSV
    }

    public enum ItemCommentLogType
    {
        [Description("None")]
        None = 0,

        [Description("Added")]
        Added = 1,

        [Description("Edited")]
        Edited,

        [Description("Deleted")]
        Deleted,

        [Description("Upvoted")]
        Upvoted,

        [Description("Downvoted")]
        Downvoted,

        [Description("Replied")]
        Replied,

        [Description("UserMention")]
        UserMention
    }

    public enum ItemLogType
    {
        [Description("None")]
        None = 0,

        [Description("Added")]
        Added = 1,

        [Description("Edited")]
        Edited,

        [Description("Deleted")]
        Deleted,

        [Description("Moved")]
        Moved,

        [Description("Copied")]
        Copied,

        [Description("Cloned")]
        Cloned,

        [Description("Trashed")]
        Trashed,

        [Description("Restored")]
        Restored,

        [Description("Rollbacked")]
        Rollbacked,

        [Description("Watched")]
        Watched,

        [Description("Unwatched")]
        Unwatched,

        [Description("Scheduled")]
        Scheduled
    }

    /// <summary>
    /// Item type
    /// </summary>
    [DataContract]
    public enum ItemType
    {
        [Description("None")]
        None = 0,

        [EnumMember]
        [Description("Category")]
        Category = 1,

        [EnumMember]
        [Description("Dashboard")]
        Dashboard,

        [EnumMember]
        [Description("Report")]
        Report,

        [EnumMember]
        [Description("Datasource")]
        Datasource,

        [EnumMember]
        [Description("Dataset")]
        Dataset,

        [EnumMember]
        [Description("File")]
        File,

        [EnumMember]
        [Description("Schedule")]
        Schedule,

        [EnumMember]
        [Description("Widget")]
        Widget,

        [EnumMember]
        [Description("ItemView")]
        ItemView
    }

    /// <summary>
    ///     SQL Table Join Types
    /// </summary>
    public enum JoinType
    {
        /// <summary>
        ///     Inner Joins
        /// </summary>
        Inner,

        /// <summary>
        ///     Full Outer Join
        /// </summary>
        FullOuter,

        /// <summary>
        ///     Left Outer Join
        /// </summary>
        Left,

        /// <summary>
        ///     Right Outer Join
        /// </summary>
        RightOuter,

        /// <summary>
        ///     Cross Join
        /// </summary>
        Cross
    }

    public enum LogCategory
    {
        [Description("None")]
        None = 0,

        [Description("Item")]
        Item = 1,

        [Description("Comment")]
        Comment,

        [Description("User")]
        User,

        [Description("Group")]
        Group,

        [Description("Permission")]
        Permission,

        [Description("SystemSettings")]
        SystemSettings,

        [Description("Schedule")]
        Schedule
    }

    /// <summary>
    ///     SQL Logical Operators
    /// </summary>
    public enum LogicalOperator
    {
        /// <summary>
        ///     No Condition Will be applied
        /// </summary>
        None,

        /// <summary>
        ///     Applies Logical OR operation
        /// </summary>
        OR,

        /// <summary>
        ///     Applies Logical AND operation
        /// </summary>
        AND,

        /// <summary>
        ///     Applies Logical IN operation
        /// </summary>
        IN,

        /// <summary>
        ///     Applies Logical LIKE operation
        /// </summary>
        LIKE,

        /// <summary>
        ///     Applies Logical NOT operation
        /// </summary>
        NOT
    }

    public enum LogOnResponse
    {
        ValidUser,
        InvalidUserName,
        InvalidPassword,
        ThrottledUser,
        DeactivatedUser,
        DeletedUser,
        InvalidMailId
    }

    public enum MailSettingsAuthType
    {
        [Description("Anonymous")]
        Anonymous = 0,

        [Description("Basic")]
        Basic,

        [Description("Windows")]
        Windows,
    }

    /// <summary>Values for months of the year (January, February, etc.)</summary>
    public enum MonthOfTheYear
    {
        //None = 0,

        /// <summary>January</summary>
        January = 1,

        /// <summary>February</summary>
        February,

        /// <summary>March</summary>
        March,

        /// <summary>April</summary>
        April,

        /// <summary>May</summary>
        May,

        /// <summary>June</summary>
        June,

        /// <summary>July</summary>
        July,

        /// <summary>August</summary>
        August,

        /// <summary>September</summary>
        September,

        /// <summary>October</summary>
        October,

        /// <summary>November</summary>
        November,

        /// <summary>December</summary>
        December
    }

    public enum NotificationPreferenceOption
    {
        [Description("Enable")]
        Enable = 0,

        [Description("Disable")]
        Disable,

        [Description("Inherit")]
        Inherit
    }

    /// <summary>
    /// Specify an access type for item.
    /// </summary>
    public enum PermissionAccess
    {
        [Description("[[[None]]]")]
        None = 0,

        [Description("[[[Read]]]")]
        Read = 2,

        [Description("[[[Read, Write]]]")]
        ReadWrite = 6,

        [Description("[[[Read, Write, Delete]]]")]
        ReadWriteDelete = 14,

        [Description("[[[Read, Download]]]")]
        ReadDownload = 18,

        [Description("[[[Read, Write, Download]]]")]
        ReadWriteDownload = 22,

        [Description("[[[Read, Write, Delete, Download]]]")]
        ReadWriteDeleteDownload = 30,

        [Description("[[[Create]]]")]
        Create = 1
    }

    /// <summary>
    /// Specify an entity of item for permission.
    /// </summary>
    public enum PermissionEntity
    {
        [Description("[[[None]]]")]
        None = 0,

        [Description("[[[All Reports]]]")]
        AllReports = 1,

        [Description("[[[Reports in Category]]]")]
        ReportsInCategory,

        [Description("[[[Specific Report]]]")]
        SpecificReports,

        [Description("[[[All Categories]]]")]
        AllCategories,

        [Description("[[[Specific Category]]]")]
        SpecificCategory,

        [Description("[[[All Data Sources]]]")]
        AllDataSources,

        [Description("[[[Specific Data Source]]]")]
        SpecificDataSource,

        [Description("[[[All Files]]]")]
        AllFiles,

        [Description("[[[Specific File]]]")]
        SpecificFile,

        [Description("[[[All Schedules]]]")]
        AllSchedules,

        [Description("[[[Specific Schedule]]]")]
        SpecificSchedule,

        [Description("[[[All Dashboards]]]")]
        AllDashboards,

        [Description("[[[Dashboards in Category]]]")]
        DashboardsInCategory,

        [Description("[[[Specific Dashboard]]]")]
        SpecificDashboard,

        [Description("[[[All Widgets]]]")]
        AllWidgets,

        [Description("[[[Specific Widget]]]")]
        SpecificWidget,

        [Description("[[[All Datasets]]]")]
        AllDatasets,

        [Description("[[[Specific Dataset]]]")]
        SpecificDataset,

        [Description("[[[Specific ItemView]]]")]
        SpecificItemView,

        [Description("[[[All ItemViews]]]")]
        AllItemViews
    }

    public enum RecurrenceType
    {
        /// <summary>Schedule's the task on a daily schedule.</summary>
        Daily,

        /// <summary>Schedule's the task on a weekly schedule.</summary>
        Weekly,

        /// <summary>Schedule's the task on a monthly schedule.</summary>
        Monthly,

        /// <summary>Schedule's the task on a yearly schedule.</summary>
        Yearly,

        /// <summary>Schedule's the task on a hourly schedule.</summary>
        Hourly
    }

    public enum ScheduleStatus
    {
        [Description("None")]
        None = 0,

        [Description("Schedule Success")]
        Success = 1,

        [Description("Schedule Fail")]
        Fail
    }

    public enum SortType
    {
        Asc,
        Desc
    }

    public enum Status
    {
        [Description("Success")]
        Success,

        [Description("Failure")]
        Failure
    }

    public enum StorageType
    {
        FileStorage,
        AzureBlob,
        AmazonS3,
        Redis
    }

    public enum SystemLogType
    {
        [Description("None")]
        None = 0,

        [Description("Updated")]
        Updated = 1
    }

    public enum SystemSettingKey
    {
        OrganizationName,
        LoginLogo,
        MainScreenLogo,
        FavIcon,
        WelcomeNoteText,
        Language,
        TimeZone,
        DateFormat,
        BaseUrl,
        ActivationExpirationDays,
        ReportCount,
        MailSettingsAddress,
        MailSettingsUserName,
        MailSettingsPassword,
        MailSettingsHost,
        MailSettingsSenderName,
        MailSettingsPort,
        MailSettingsIsSecureAuthentication,
        RecurrenceTypeId,
        RecurrenceInfo,
        ScheduleSynchronizationIsEnabled,
        AzureRecTypeId,
        AzureRecInfo,
        AzureScheduleSyncIsEnabled,
        DatabaseRecTypeId,
        DatabaseRecInfo,
        DatabaseScheduleSyncIsEnabled,
        UmsRecTypeId,
        UmsRecInfo,
        UmsScheduleSyncIsEnabled,
        MachineName,
        HostDomain,
        IsSecureConnection,
        NotificationSettings,
        NotificationAdministration,
        IsEnablePoweredBySyncfusion,
        IsEnableCopyrightInfo,
        MailSettingsAuthType,
        StorageType,
        ActivationType,
        InstallationFolder,
        CopyrightInformation,
        IsShowPoweredBySyncfusion,
        AzureBlobStorageUri,
        AzureBlobStorageContainerName,
        ConnectionType,
        ConnectionString,
        IsMarkItemsPublic,
        TimeFormat
    }

    /// <summary>Defines the type of schedule that can be used by tasks.</summary>
    public enum TaskScheduleType
    {
        None = 0,

        /// <summary>Schedule's the task on a daily schedule.</summary>
        Daily = 1,

        /// <summary>Schedule's the task on a daily schedule.</summary>
        DailyWeekDay,

        /// <summary>Schedule's the task on a weekly schedule.</summary>
        Weekly,

        /// <summary>Schedule's the task on a monthly schedule.</summary>
        Monthly,

        /// <summary>Schedule's the task on a monthly day-of-week schedule.</summary>
        MonthlyDOW,

        /// <summary>Schedule's the task on a yearly schedule.</summary>
        Yearly,

        /// <summary>Schedule's the task on a yearly day-of-week schedule.</summary>
        YearlyDOW,

        /// <summary>Schedule's the task at a specific time of day.</summary>
        Time,

        /// <summary>Schedule's the task on a hourly schedule.</summary>
        Hourly
    }

    public enum TokenAuthenticationTypes
    {
        AuthorizationCode = 1,
        Implicit,
        ResourceOwnerCredentials,
        ClientCredentials
    }

    public enum UploadImageType
    {
        None = 0,
        LoginLogo = 1,
        MainScreenLogo = 2,
        Favicon = 3,
        ProfilePicture = 4,
        CommentImage = 5
    }

    public enum UserLogType
    {
        [Description("None")]
        None = 0,

        [Description("Added")]
        Added = 1,

        [Description("Updated")]
        Updated,

        [Description("Deleted")]
        Deleted,

        [Description("Changed")]
        Changed
    }

    //public enum UserStatus
    //{
    //    [Description("Active")]
    //    Active,

    //    [Description("InActive")]
    //    InActive
    //}

    public enum UserType
    {
        [Description("Server User")]
        ServerUser = 0,

        [Description("Active Directory User")]
        ActiveDirectoryUser,

        [Description("Azure AD User")]
        AzureADUser,

        [Description("Custom Database")]
        DatabaseUser,

        [Description("UMS User")]
        UmsUser
    }

    /// <summary>Values for week of month (first, second, ..., last)</summary>
    public enum WeekOfMonth
    {
        //None = 0,

        /// <summary>First week of the month</summary>
        first = 1,

        /// <summary>Second week of the month</summary>
        second,

        /// <summary>Third week of the month</summary>
        third,

        /// <summary>Fourth week of the month</summary>
        fourth,

        /// <summary>Last week of the month</summary>
        last
    }

    public enum ConditionCategory
    {
        [Description("Increases")]
        Increases = 1,

        [Description("Continuously Increases")]
        ContinuousIncreases,

        [Description("Decreases")]
        Decreases,

        [Description("Continuously Decreases")]
        ContinuousDecreases,

        [Description("Value Changes")]
        ValueChanges
    }

    public enum ScheduleType
    {
        IsTimeInterval = 1,
        IsDataChanges = 2,
        IsTimeAndDatachange = 3
    }

    #region Api schedule enum properties
    public enum ApiDailyScheduleRecurrenceType
    {
        [Description("Every N days")]
        EveryNdays,

        [Description("Every Weekday")]
        EveryWeekday
    }

    public enum ApiMonthlyScheduleRecurrenceType
    {
        [Description("Day Recurrence")]
        DayRecurrence,

        [Description("Custom Recurrence")]
        CustomRecurrence
    }

    public enum ApiYearlyScheduleRecurrenceType
    {
        [Description("Month Recurrence")]
        MonthRecurrence,

        [Description("Custom Recurrence")]
        CustomRecurrence
    }
    #endregion
}