using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for UpBalanceyController. Source: src/FinanceCheckUp.Api/Controllers/v1/upbalanceyController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IUpBalanceyClient : IApiClientBase
{
    [Post("/api/upbalancey")]
    Task<GenericResult<upbalanceyOnGetResponse>> GetAsync([Body] UpbalanceyOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upbalancey/saler-date")]
    Task<GenericResult<upbalanceyOnGetSalerDateResponse>> GetSalerDateAsync([Body] upbalanceyOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upbalancey/saler-year")]
    Task<GenericResult<upbalanceyOnGetSalerYearResponse>> GetSalerYearAsync([Body] upbalanceyOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upbalancey/saler-comp")]
    Task<GenericResult<upbalanceyOnGetSalerCompResponse>> GetSalerCompAsync([Body] upbalanceyOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upbalancey/graph-comp")]
    Task<GenericResult<upbalanceyOnGetGraphCompResponse>> GetGraphCompAsync([Body] upbalanceyOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upbalancey/graph-year")]
    Task<GenericResult<upbalanceyOnGetGraphYearResponse>> GetGraphYearAsync([Body] upbalanceyOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
}
