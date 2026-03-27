using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for UpAccountyController. Source: src/FinanceCheckUp.Api/Controllers/v1/upaccountyController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IUpAccountyClient : IApiClientBase
{
    [Post("/api/upaccounty")]
    Task<GenericResult<upaccountyOnGetResponse>> GetAsync([Body] UpaccountyOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upaccounty/saler-main-chk")]
    Task<GenericResult<upaccountyOnGetSalerMainChkResponse>> GetSalerMainChkAsync([Body] upaccountyOnGetSalerMainChkRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upaccounty/saler-main-zeta")]
    Task<GenericResult<upaccountyOnGetSalerMainZetaResponse>> GetSalerMainZetaAsync([Body] upaccountyOnGetSalerMainZetaRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upaccounty/saler-date")]
    Task<GenericResult<upaccountyOnGetSalerDateResponse>> GetSalerDateAsync([Body] upaccountyOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upaccounty/saler-year")]
    Task<GenericResult<upaccountyOnGetSalerYearResponse>> GetSalerYearAsync([Body] upaccountyOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upaccounty/GetSalerComp")]
    Task<GenericResult<upaccountyOnGetSalerCompResponse>> GetSalerCompAsync([Body] upaccountyOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upaccounty/graph-comp")]
    Task<GenericResult<upaccountyOnGetGraphCompResponse>> GetGraphCompAsync([Body] upaccountyOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upaccounty/graph-year")]
    Task<GenericResult<upaccountyOnGetGraphYearResponse>> GetGraphYearAsync([Body] upaccountyOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
}
