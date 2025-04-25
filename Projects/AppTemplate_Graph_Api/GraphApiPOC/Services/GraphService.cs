using Microsoft.Graph;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Abstractions;
using GraphApiTemplate.Models;



namespace GraphApiTemplate.Services
{
    public class GraphService
    {
        private readonly GraphServiceClient _graphClient;

        public GraphService()
        {
            var mockToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.MockedTokenPayload"; // This is a fake token for testing
            var authProvider = new MockAuthenticationProvider(mockToken);
            _graphClient = new GraphServiceClient(authProvider);
        }

        public async Task<object> CreateApplicationWithSamlAsync(ApplicationTemplateRequest request)
        {
            var app = new Application
            {
                DisplayName = request.DisplayName,
                Web = new Microsoft.Graph.Models.WebApplication
                {
                    RedirectUris = new List<string> { request.RedirectUri }
                },
                IdentifierUris = new List<string> { request.IdentifierUris },
                SignInAudience = "AzureADMyOrg"
            };

            var createdApp = await _graphClient.Applications.PostAsync(app);

            if (createdApp == null || string.IsNullOrEmpty(createdApp.AppId))
            {
                throw new Exception("Failed to create application.");
            }

            var servicePrincipal = new ServicePrincipal
            {
                AppId = createdApp.AppId
            };

            var createdSp = await _graphClient.ServicePrincipals.PostAsync(servicePrincipal);

            return new
            {
                ApplicationId = createdApp.AppId,
                ObjectId = createdApp.Id,
                SAMLSetupRequired = true,
                Message = "App and SP created. Configure SAML manually or extend automation."
            };
        }
    }

    public class MockAuthenticationProvider : IAuthenticationProvider
    {
        private readonly string _mockToken;

        public MockAuthenticationProvider(string mockToken)
        {
            _mockToken = mockToken;
        }

        public Task AuthenticateRequestAsync(
        RequestInformation request,
        Dictionary<string, object>? additionalAuthenticationContext = null,
        CancellationToken cancellationToken = default)
        {
            var token = "Bearer MOCKED_ACCESS_TOKEN";
            request.Headers.Add("Authorization", token);
            return Task.CompletedTask;
        }

    }
}
