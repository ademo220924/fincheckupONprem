using fincheckup.ApiClients.Models.Requests.Finance.Konsol.DashBilancoKon;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceKonsolDashBilancoKonController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceKonsolDashBilancoKonController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceKonsolDashBilancoKonClient : IApiClientBase
{
    [Post("/api/finance/konsol/FinanceKonsolDashBilancoKon/OnGet")]
    Task<GenericResult<DashBilancoKonOnGetResponse>> GetAsync([Body] DashBilancoKonOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/konsol/FinanceKonsolDashBilancoKon/OnGetGraphYear")]
    Task<GenericResult<DashBilancoKonOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashBilancoKonOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/konsol/FinanceKonsolDashBilancoKon/OnGetMarkupMarjin")]
    Task<GenericResult<DashBilancoKonOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] DashBilancoKonOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
