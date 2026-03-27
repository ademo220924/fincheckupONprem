using fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportPotDynamic;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanReportPotDynamicController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanReportPotDynamicController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanReportPotDynamicClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanReportPotDynamic/OnGet")]
    Task<GenericResult<MizanReportPotDynamicOnGetResponse>> GetAsync([Body] MizanReportPotDynamicOnGetRequest request, CancellationToken cancellationToken = default);
}
