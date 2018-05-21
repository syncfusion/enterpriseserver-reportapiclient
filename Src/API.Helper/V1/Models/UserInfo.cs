namespace Syncfusion.Report.Server.Api.Helper.V1.Models
{
    public class UserInfo : User
    {
        /// <summary>
        /// Phone number of the user.
        /// </summary>
        public string ContactNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Display name of the user.
        /// </summary>
        public string DisplayName
        {
            get;
            set;
        }
        
        /// <summary>
        /// Returns true if the user is an active user.
        /// </summary>
        public bool IsActive
        {
            get;
            set;
        }

        /// <summary>
        /// Returns true if the user is added from Active Directory
        /// </summary>
        public bool IsActiveDirectoryUser
        {
            get;
            set;
        }

        /// <summary>
        /// Returns true if the user is added from Azure Active Directory.
        /// </summary>
        public bool IsAzureAdUser
        {
            get;
            set;
        }
        
        /// <summary>
        /// ID of the user.
        /// </summary>
        public int UserId
        {
            get;
            set;
        }

        /// <summary>
        /// Returns the status of the user.
        /// </summary>
        public UserStatus UserStatus
        {
            get;
            set;
        }
    }
}
