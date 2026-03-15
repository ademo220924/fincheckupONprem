using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashBilancoMlt;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashBilancoMlt;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanDashBilancoMltApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/DashBilancoMlt/OnGet")]
    Task<GenericResult<MizanDashBilancoMltOnGetResponse>> GetAsync([Body] MizanDashBilancoMltOnGetRequest request, CancellationToken cancellationToken);
    
    [Post("/api/finance/mizan/DashBilancoMlt/OnGetChartRasyo")]
    Task<GenericResult<MizanDashBilancoMltOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] MizanDashBilancoMltOnGetChartRasyoRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/DashBilancoMlt/OnGetMarkupMarjin")]
    Task<GenericResult<MizanDashBilancoMltOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanDashBilancoMltOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}