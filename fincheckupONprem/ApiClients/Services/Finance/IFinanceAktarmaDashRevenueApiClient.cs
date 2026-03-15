using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Finance.Aktarma.DashRevenue;
using fincheckup.ApiClients.Models.Responses.Finance.Aktarma.DashRevenue;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceAktarmaDashRevenueApiClient : IApiClientBase
{
    [Post("/api/finance/aktarma/FinanceAktarmaDashRevenue/OnGet")]
    Task<GenericResult<AktarmaDashRevenueOnGetResponse>> GetAsync([Body] AktarmaDashRevenueOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/aktarma/FinanceAktarmaDashRevenue/OnGetGraphYear")]
    Task<GenericResult<AktarmaDashRevenueOnGetGraphYearResponse>> GetGraphYearAsync([Body] AktarmaDashRevenueOnGetGraphYearRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/aktarma/FinanceAktarmaDashRevenue/OnGetMarkupMarjin")]
    Task<GenericResult<AktarmaDashRevenueOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] AktarmaDashRevenueOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}