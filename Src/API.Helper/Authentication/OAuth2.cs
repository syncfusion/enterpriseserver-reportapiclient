using RestSharp;
using RestSharp.Authenticators;

namespace Syncfusion.Report.Server.Api.Helper.Authentication
{
    public class OAuth2 : OAuthAuthentication
    {
        private const string TokenType = "Bearer";
        private readonly string _tokenUrl = "/api/token";
        private string _token;
        public OAuth2(string serverUrl, string userName, string password)
            : base(serverUrl, userName, password)
        {
            _tokenUrl = serverUrl.TrimEnd('/') + _tokenUrl;
        }

        public void GetToken()
        {
            var tokenClient = new RestClient(_tokenUrl);
            var request = new RestRequest
            {
                Method = Method.POST
            };

            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddHeader("Accept", "application/json");
                  
            request.AddParameter("grant_type", "password");
            request.AddParameter("username", Username);
            request.AddParameter("password", Password);

            var response = tokenClient.Execute<Token>(request);
            _token = response.Data.AccessToken;
          

            Client = new RestClient(ServerUrl)
            {
                Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(_token, TokenType)
            };
        }
    }
}
