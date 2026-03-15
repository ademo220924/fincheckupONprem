using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashRevenue;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashRevenue;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanDashRevenueApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/DashRevenue/OnGet")]
    Task<GenericResult<MizanDashRevenueOnGetResponse>> GetAsync([Body] MizanDashRevenueOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/DashRevenue/OnGetChartRasyo")]
    Task<GenericResult<MizanDashRevenueOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] MizanDashRevenueOnGetChartRasyoRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/DashRevenue/OnGetMarkupMarjin")]
    Task<GenericResult<MizanDashRevenueOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanDashRevenueOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}