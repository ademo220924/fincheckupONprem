using fincheckup.ApiClients.Models.Requests.Finance.Mizan.CashFlow;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanCashFlowController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanCashFlowController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanCashFlowClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanCashFlow/OnGet")]
    Task<GenericResult<MizanCashFlowOnGetResponse>> GetAsync([Body] MizanCashFlowOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanCashFlow/OnGetGraphYear")]
    Task<GenericResult<MizanCashFlowOnGetGraphYearResponse>> GetGraphYearAsync([Body] MizanCashFlowOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanCashFlow/OnGetChartRasyo")]
    Task<GenericResult<MizanCashFlowOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] MizanCashFlowOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanCashFlow/OnGetMarkupMarjin")]
    Task<GenericResult<MizanCashFlowOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanCashFlowOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
