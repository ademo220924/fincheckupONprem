using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Konsol.DashRevenueKon;
using fincheckup.ApiClients.Models.Responses.Finance.Konsol.DashRevenueKon;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceKonsolDashRevenueKonApiClient : IApiClientBase
{
    [Post("/api/finance/konsol/FinanceKonsolDashRevenueKon/OnGet")]
    Task<GenericResult<DashRevenueKonOnGetResponse>> GetAsync([Body] DashRevenueKonOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/konsol/FinanceKonsolDashRevenueKon/OnGetGraphYear")]
    Task<GenericResult<DashRevenueKonOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashRevenueKonOnGetGraphYearRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/konsol/FinanceKonsolDashRevenueKon/OnGetMarkupMarjin")]
    Task<GenericResult<DashRevenueKonOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] DashRevenueKonOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}