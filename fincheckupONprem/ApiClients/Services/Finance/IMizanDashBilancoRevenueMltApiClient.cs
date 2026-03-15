using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashBilancoRevenueMlt;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashBilancoRevenueMlt;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanDashBilancoRevenueMltApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/DashBilancoRevenueMlt/OnGet")]
    Task<GenericResult<MizanDashBilancoRevenueMltOnGetResponse>> GetAsync([Body] MizanDashBilancoRevenueMltOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/DashBilancoRevenueMlt/OnGetChartRasyo")]
    Task<GenericResult<MizanDashBilancoRevenueMltOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] MizanDashBilancoRevenueMltOnGetChartRasyoRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/DashBilancoRevenueMlt/OnGetMarkupMarjin")]
    Task<GenericResult<MizanDashBilancoRevenueMltOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanDashBilancoRevenueMltOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}