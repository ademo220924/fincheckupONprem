using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Konsol.DashRevenueKon;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.Konsol.DashRevenueKon;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;
 

public interface IMizanKonsolDashRevenueKonApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/konsol/DashRevenueKon/OnGet")]
    Task<GenericResult<MizanDashRevenueKonOnGetResponse>> GetAsync([Body] MizanDashRevenueKonOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/konsol/DashRevenueKon/OnGetGraphYear")]
    Task<GenericResult<MizanDashRevenueKonOnGetGraphYearResponse>> GetGraphYearAsync([Body] MizanDashRevenueKonOnGetGraphYearRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/konsol/DashRevenueKon/OnGetMarkupMarjin")]
    Task<GenericResult<MizanDashRevenueKonOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanDashRevenueKonOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}