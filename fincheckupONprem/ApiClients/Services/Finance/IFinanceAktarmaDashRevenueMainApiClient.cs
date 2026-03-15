using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Aktarma.DashRevenueMain;
using fincheckup.ApiClients.Models.Responses.Finance.Aktarma.DashRevenueMain;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceAktarmaDashRevenueMainApiClient : IApiClientBase
{
    [Post("/api/finance/aktarma/FinanceAktarmaDashRevenueMain/OnGet")]
    Task<GenericResult<AktarmaDashRevenueMainOnGetResponse>> GetAsync([Body] AktarmaDashRevenueMainOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/aktarma/FinanceAktarmaDashRevenueMain/OnGetGraphYear")]
    Task<GenericResult<AktarmaDashRevenueMainOnGetGraphYearResponse>> GetGraphYearAsync([Body] AktarmaDashRevenueMainOnGetGraphYearRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/aktarma/FinanceAktarmaDashRevenueMain/OnGetMarkupMarjin")]
    Task<GenericResult<AktarmaDashRevenueMainOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] AktarmaDashRevenueMainOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}