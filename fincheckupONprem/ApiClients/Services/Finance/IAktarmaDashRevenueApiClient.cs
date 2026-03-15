using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Aktarma.DashRevenue;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.Aktarma.DashRevenue;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IAktarmaDashRevenueApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/aktarma/FinanceMizanAktarmaDashRevenue/OnGet")]
    Task<GenericResult<MizanAktarmaDashRevenueOnGetResponse>> GetAsync([Body] MizanAktarmaDashRevenueOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/aktarma/FinanceMizanAktarmaDashRevenue/OnGetMarkupMarjin")]
    Task<GenericResult<MizanAktarmaDashRevenueOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanAktarmaDashRevenueOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}