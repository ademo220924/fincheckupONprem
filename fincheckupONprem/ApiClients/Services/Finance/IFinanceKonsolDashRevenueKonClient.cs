using fincheckup.ApiClients.Models.Requests.Finance.Konsol.DashRevenueKon;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceKonsolDashRevenueKonController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceKonsolDashRevenueKonController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceKonsolDashRevenueKonClient : IApiClientBase
{
    [Post("/api/finance/konsol/FinanceKonsolDashRevenueKon/OnGet")]
    Task<GenericResult<DashRevenueKonOnGetResponse>> GetAsync([Body] DashRevenueKonOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/konsol/FinanceKonsolDashRevenueKon/OnGetGraphYear")]
    Task<GenericResult<DashRevenueKonOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashRevenueKonOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/konsol/FinanceKonsolDashRevenueKon/OnGetMarkupMarjin")]
    Task<GenericResult<DashRevenueKonOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] DashRevenueKonOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
