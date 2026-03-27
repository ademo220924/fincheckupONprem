using fincheckup.ApiClients.Models.Requests;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for AuthenticationController. Source: src/FinanceCheckUp.Api/Controllers/v1/AuthenticationController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IAuthenticationClient : IApiClientBase
{
    [Post("/api/auth/login")]
    Task<GenericResult<LoginResponse>> LoginAsync([Body] LoginRequest request, CancellationToken cancellationToken = default);
    [Post("/api/auth/GetAuthorizationToken")]
    Task<GenericResult<TokenResponse>> AuthorizationTokenAsync([Body] Settings settings, CancellationToken cancellationToken = default);
    // TODO: non-JSON / no MediatR — LogoutAsync (GET /api/auth/logout)
}
