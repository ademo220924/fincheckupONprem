using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Services.Base;

namespace fincheckup.StartupConfigurations;

public class AuthenticatedHttpClientHandler(TokenService tokenService) : DelegatingHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var token = tokenService.GetToken();
        if (!string.IsNullOrWhiteSpace(token))
        {
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
        }

        return await base.SendAsync(request, cancellationToken);
    }
}