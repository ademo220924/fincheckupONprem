using System.Threading.Tasks;
using System.Threading;
using Refit;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Responses.Authentication;
using fincheckup.ApiClients.Models.Requests.Authentication;
using fincheckup.ApiClients.Services.Base;

namespace fincheckup.ApiClients.Services;

public interface IAuthenticationApiClient: IApiClientBase
{
    [Post("/api/auth/login")]
    Task<GenericResult<LoginResponse>> LoginAsync([Body] LoginRequest request, CancellationToken cancellationToken = default);

    [Post("/api/auth/GetAuthorizationToken")]
    Task<GenericResult<TokenResponse>> AuthorizationTokenAsync([Body] Settings settings, CancellationToken cancellationToken = default);

    [Get("/api/auth/logout")]
    Task<bool> LogoutAsync(CancellationToken cancellationToken = default);
}