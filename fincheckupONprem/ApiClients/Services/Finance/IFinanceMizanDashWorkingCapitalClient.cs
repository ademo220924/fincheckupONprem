using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashWorkingCapital;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanDashWorkingCapitalController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanDashWorkingCapitalController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanDashWorkingCapitalClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanDashWorkingCapital/OnGet")]
    Task<GenericResult<MizanDashWorkingCapitalOnGetResponse>> GetAsync([Body] MizanDashWorkingCapitalOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanDashWorkingCapital/OnGetMarkupMarjin")]
    Task<GenericResult<MizanDashWorkingCapitalOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanDashWorkingCapitalOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
