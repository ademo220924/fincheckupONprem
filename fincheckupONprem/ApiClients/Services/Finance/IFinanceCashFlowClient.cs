using fincheckup.ApiClients.Models.Requests.Finance.CashFlow;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceCashFlowController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceCashFlowController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceCashFlowClient : IApiClientBase
{
    [Post("/api/finance/FinanceCashFlow/OnGet")]
    Task<GenericResult<FinanceCashFlowOnGetResponse>> GetAsync([Body] FinanceCashFlowOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceCashFlow/OnGetGraphYear")]
    Task<GenericResult<FinanceCashFlowOnGetGraphYearResponse>> GetGraphYearAsync([Body] FinanceCashFlowOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceCashFlow/OnGetChartRasyo")]
    Task<GenericResult<FinanceCashFlowOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] FinanceCashFlowOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceCashFlow/OnGetMarkupMarjin")]
    Task<GenericResult<FinanceCashFlowOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] FinanceCashFlowOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
