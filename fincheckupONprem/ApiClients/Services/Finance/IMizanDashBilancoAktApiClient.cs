using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashBilancoAkt;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashBilancoAkt;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanDashBilancoAktApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/DashBilancoAkt/OnGet")]
    Task<GenericResult<MizanDashBilancoAktOnGetResponse>> GetAsync([Body] MizanDashBilancoAktOnGetRequest request, CancellationToken cancellationToken);
}