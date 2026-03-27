using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashBilancoRevenueAkt;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanDashBilancoRevenueAktController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanDashBilancoRevenueAktController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanDashBilancoRevenueAktClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanDashBilancoRevenueAkt/OnGet")]
    Task<GenericResult<MizanDashBilancoRevenueAktOnGetResponse>> GetAsync([Body] MizanDashBilancoRevenueAktOnGetRequest request, CancellationToken cancellationToken = default);
}
