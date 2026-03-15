using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Finance.Aktarma.dashbilancomain;
using fincheckup.ApiClients.Models.Responses.Finance.Aktarma.dashbilancomain;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceAktarmaDashBilancoMainApiClient : IApiClientBase
{
    [Post("/api/finance/aktarma/FinanceAktarmaDashBilancoMain/OnGet")]
    Task<GenericResult<AktarmaDashbilancomainOnGetResponse>> GetAsync([Body] AktarmaDashbilancomainOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/aktarma/FinanceAktarmaDashBilancoMain/OnGetGraphYear")]
    Task<GenericResult<AktarmaDashbilancomainOnGetGraphYearResponse>> GetGraphYearAsync([Body] AktarmaDashbilancomainOnGetGraphYearRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/aktarma/FinanceAktarmaDashBilancoMain/OnGetMarkupMarjin")]
    Task<GenericResult<AktarmaDashbilancomainOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] AktarmaDashbilancomainOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}