using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashBilancoAkt;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanDashBilancoAktController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanDashBilancoAktController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanDashBilancoAktClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanDashBilancoAkt/OnGet")]
    Task<GenericResult<MizanDashBilancoAktOnGetResponse>> GetAsync([Body] MizanDashBilancoAktOnGetRequest request, CancellationToken cancellationToken = default);
}
