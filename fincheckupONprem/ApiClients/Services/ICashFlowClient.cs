using fincheckup.ApiClients.Models.Requests.CashFlow;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for CashFlowController. Source: src/FinanceCheckUp.Api/Controllers/v1/CashFlowController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface ICashFlowClient : IApiClientBase
{
    [Post("/api/cashflow")]
    Task<GenericResult<OnGetResponseModel>> GetAsync([Body] CashFlowOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/cashflow/saler-main")]
    Task<GenericResult<GetSalerMainResponseModel>> GetSalerMainAsync([Body] GetSalerMainRequestModel request, CancellationToken cancellationToken = default);
    [Post("/api/cashflow/prio")]
    Task<GenericResult<GetPrioResponseModel>> GetPrioAsync([Body] GetPrioRequestModel request, CancellationToken cancellationToken = default);
    [Post("/api/cashflow/graph-year")]
    Task<GenericResult<GetGraphYearResponseModel>> OnGetGraphYearAsync([Body] GetGraphYearRequestModel request, CancellationToken cancellationToken = default);
    [Post("/api/cashflow/chart-rasyo")]
    Task<GenericResult<GetChartRasyoResponseModel>> GetChartRasyoAsync([Body] GetChartRasyoRequestModel request, CancellationToken cancellationToken = default);
    [Post("/api/cashflow/markup-marjin")]
    Task<GenericResult<GetMarkupMarjinResponseModel>> GetMarkupMarjinAsync([Body] GetMarkupMarjinRequestModel request, CancellationToken cancellationToken = default);
    [Post("/api/cashflow/graph-comp")]
    Task<GenericResult<GetGraphCompResponseModel>> OnGetGraphCompAsync([Body] GetGraphCompRequestModel request, CancellationToken cancellationToken = default);
}
