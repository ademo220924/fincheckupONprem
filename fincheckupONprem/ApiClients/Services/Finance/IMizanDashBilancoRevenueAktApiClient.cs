using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashBilancoRevenueAkt;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashBilancoRevenueAkt;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanDashBilancoRevenueAktApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/DashBilancoRevenueAkt/OnGet")]
    Task<GenericResult<MizanDashBilancoRevenueAktOnGetResponse>> GetAsync([Body] MizanDashBilancoRevenueAktOnGetRequest request, CancellationToken cancellationToken);
}