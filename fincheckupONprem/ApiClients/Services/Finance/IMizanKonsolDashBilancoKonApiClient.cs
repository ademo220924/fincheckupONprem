using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Konsol.DashBilancoKon;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.Konsol.DashBilancoKon;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanKonsolDashBilancoKonApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/konsol/DashBilancoKon/OnGet")]
    Task<GenericResult<MizanDashBilancoKonOnGetResponse>> GetAsync([Body] MizanDashBilancoKonOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/konsol/DashBilancoKon/OnGetGraphYear")]
    Task<GenericResult<MizanDashBilancoKonOnGetGraphYearResponse>> GetGraphYearAsync([Body] MizanDashBilancoKonOnGetGraphYearRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/konsol/DashBilancoKon/OnGetMarkupMarjin")]
    Task<GenericResult<MizanDashBilancoKonOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanDashBilancoKonOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}