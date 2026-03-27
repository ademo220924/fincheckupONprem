using fincheckup.ApiClients.Models.Requests.Finance.DashCrmDetailb;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceDashCrmDetailbController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceDashCrmDetailbController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceDashCrmDetailbClient : IApiClientBase
{
    [Post("/api/finance/FinanceDashCrmDetailb/OnGet")]
    Task<GenericResult<FinanceDashCrmDetailbOnGetResponse>> GetAsync([Body] FinanceDashCrmDetailbOnGetRequest request, CancellationToken cancellationToken = default);
}
