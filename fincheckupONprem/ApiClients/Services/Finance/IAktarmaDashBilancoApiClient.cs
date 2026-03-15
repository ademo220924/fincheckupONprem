using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Aktarma.DashBilanco;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.Aktarma.DashBilanco;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.Aktarma.DashBilanco;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IAktarmaDashBilancoApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/aktarma/AktarmaDashBilanco/OnGet")]
    Task<GenericResult<MizanAktarmaDashBilancoOnGetResponse>> GetAsync([Body] MizanAktarmaDashBilancoOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/aktarma/AktarmaDashBilanco/OnGetMarkupMarjin")]
    Task<GenericResult<MizanAktarmaDashBilancoOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanAktarmaDashBilancoOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}