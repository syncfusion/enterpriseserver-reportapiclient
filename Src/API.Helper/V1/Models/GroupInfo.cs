namespace Syncfusion.Report.Server.Api.Helper.V1.Models
{
    public class GroupInfo : Group
    {
        /// <summary>
        /// Id of the group.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Returns true if the user is added from Windows Active Directory.
        /// </summary>
        public bool IsActiveDirectoryGroup { get; set; }

        /// <summary>
        /// Returns true if the user is added from Azure Active Directory.
        /// </summary>
        public bool IsAzureADGroup { get; set; }

    }
}
