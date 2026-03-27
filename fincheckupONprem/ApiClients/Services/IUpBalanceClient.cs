using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for UpBalanceController. Source: src/FinanceCheckUp.Api/Controllers/v1/upbalanceController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IUpBalanceClient : IApiClientBase
{
    [Post("/api/upbalance")]
    Task<GenericResult<upbalanceOnGetResponse>> GetAsync([Body] UpbalanceOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upbalance/check-rep-pdf")]
    Task<GenericResult<upbalanceOnGetCheckRepPdfResponse>> GetCheckRepPdfAsync([Body] upbalanceOnGetCheckRepPdfRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upbalance/check-rep-xls")]
    Task<GenericResult<upbalanceOnGetCheckRepXlsResponse>> GetCheckRepXlsAsync([Body] upbalanceOnGetCheckRepXlsRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upbalance/graph-comp")]
    Task<GenericResult<upbalanceOnGetGraphCompResponse>> GetGraphCompAsync([Body] upbalanceOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upbalance/graph-year")]
    Task<GenericResult<upbalanceOnGetGraphYearResponse>> GetGraphYearAsync([Body] upbalanceOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upbalance/saler-comp")]
    Task<GenericResult<upbalanceOnGetSalerCompResponse>> GetSalerCompAsync([Body] upbalanceOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upbalance/saler-date")]
    Task<GenericResult<upbalanceOnGetSalerDateResponse>> GetSalerDateAsync([Body] upbalanceOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upbalance/saler-year")]
    Task<GenericResult<upbalanceOnGetSalerYearResponse>> GetSalerYearAsync([Body] upbalanceOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
}
