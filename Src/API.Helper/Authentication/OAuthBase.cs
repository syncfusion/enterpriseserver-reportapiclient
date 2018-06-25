namespace Syncfusion.Report.Server.Api.Helper.Authentication
{
    public abstract class OAuthAuthentication : Authenticate
    {
        protected readonly string Username;
        protected readonly string Password;
        protected readonly string ServerUrl;

        protected OAuthAuthentication(string serverUrl, string username, string password)
        {
            Username = username;
            Password = password;
            ServerUrl = serverUrl;
        }
    }
}
