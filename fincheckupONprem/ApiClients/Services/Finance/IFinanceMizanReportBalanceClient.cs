using fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportBalance;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanReportBalanceController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanReportBalanceController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanReportBalanceClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanReportBalance/OnGet")]
    Task<GenericResult<MizanReportBalanceOnGetResponse>> GetAsync([Body] MizanReportBalanceOnGetRequest request, CancellationToken cancellationToken = default);
}
