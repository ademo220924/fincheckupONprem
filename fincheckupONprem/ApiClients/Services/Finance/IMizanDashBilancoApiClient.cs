using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashBilanco;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashBilanco;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanDashBilancoApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/DashBilanco/OnGet")]
    Task<GenericResult<MizanDashBilancoOnGetResponse>> GetAsync([Body] MizanDashBilancoOnGetRequest request, CancellationToken cancellationToken);
    
    [Post("/api/finance/mizan/DashBilanco/OnGetChartRasyo")]
    Task<GenericResult<MizanDashBilancoOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] MizanDashBilancoOnGetChartRasyoRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/DashBilanco/OnGetMarkupMarjin")]
    Task<GenericResult<MizanDashBilancoOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanDashBilancoOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}