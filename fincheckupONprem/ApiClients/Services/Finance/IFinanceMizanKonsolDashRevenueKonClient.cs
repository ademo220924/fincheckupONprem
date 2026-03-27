using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Konsol.DashRevenueKon;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanKonsolDashRevenueKonController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanKonsolDashRevenueKonController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanKonsolDashRevenueKonClient : IApiClientBase
{
    [Post("/api/finance/mizan/konsol/FinanceMizanKonsolDashRevenueKon/OnGet")]
    Task<GenericResult<MizanDashRevenueKonOnGetResponse>> GetAsync([Body] MizanDashRevenueKonOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/konsol/FinanceMizanKonsolDashRevenueKon/OnGetGraphYear")]
    Task<GenericResult<MizanDashRevenueKonOnGetGraphYearResponse>> GetGraphYearAsync([Body] MizanDashRevenueKonOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/konsol/FinanceMizanKonsolDashRevenueKon/OnGetMarkupMarjin")]
    Task<GenericResult<MizanDashRevenueKonOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanDashRevenueKonOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
