using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Konsol.DashBilancoKon;
using fincheckup.ApiClients.Models.Responses.Finance.Konsol.DashBilancoKon;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceKonsolDashBilancoKonApiClient : IApiClientBase
{
    [Post("/api/finance/konsol/FinanceKonsolDashBilancoKon/OnGet")]
    Task<GenericResult<DashBilancoKonOnGetResponse>> GetAsync([Body] DashBilancoKonOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/konsol/FinanceKonsolDashBilancoKon/OnGetGraphYear")]
    Task<GenericResult<DashBilancoKonOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashBilancoKonOnGetGraphYearRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/konsol/FinanceKonsolDashBilancoKon/OnGetMarkupMarjin")]
    Task<GenericResult<DashBilancoKonOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] DashBilancoKonOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}