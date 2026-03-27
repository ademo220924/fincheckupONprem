using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Konsol.DashBilancoKon;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanKonsolDashBilancoKonController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanKonsolDashBilancoKonController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanKonsolDashBilancoKonClient : IApiClientBase
{
    [Post("/api/finance/mizan/konsol/FinanceMizanKonsolDashBilancoKon/OnGet")]
    Task<GenericResult<MizanDashBilancoKonOnGetResponse>> GetAsync([Body] MizanDashBilancoKonOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/konsol/FinanceMizanKonsolDashBilancoKon/OnGetGraphYear")]
    Task<GenericResult<MizanDashBilancoKonOnGetGraphYearResponse>> GetGraphYearAsync([Body] MizanDashBilancoKonOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/konsol/FinanceMizanKonsolDashBilancoKon/OnGetMarkupMarjin")]
    Task<GenericResult<MizanDashBilancoKonOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanDashBilancoKonOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
