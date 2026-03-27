using fincheckup.ApiClients.Models.Requests.ChangePassword;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for ChangePasswordController. Source: src/FinanceCheckUp.Api/Controllers/v1/ChangePasswordController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IChangePasswordClient : IApiClientBase
{
    [Post("/api/chance-password")]
    Task<GenericResult<ChangePasswordOnGetResponse>> GetAsync([Body] ChangePasswordOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/chance-password/saler-main")]
    Task<GenericResult<ChangePasswordOnGetSalerMainResponse>> GetSalerMainAsync([Body] ChangePasswordOnGetSalerMainRequest request, CancellationToken cancellationToken = default);
    [Post("/api/chance-password/saler-city")]
    Task<GenericResult<ChangePasswordOnGetSalerCityResponse>> GetSalerCityAsync([Body] ChangePasswordOnGetSalerCityRequest request, CancellationToken cancellationToken = default);
    [Post("/api/chance-password/saler-company")]
    Task<GenericResult<ChangePasswordOnGetSalerCompanyResponse>> GetSalerCompanyAsync([Body] ChangePasswordOnGetSalerCompanyRequest request, CancellationToken cancellationToken = default);
    [Post("/api/chance-password/user")]
    Task<GenericResult<ChangePasswordOnGetUserResponse>> GetUserAsync([Body] ChangePasswordOnGetUserRequest request, CancellationToken cancellationToken = default);
}
