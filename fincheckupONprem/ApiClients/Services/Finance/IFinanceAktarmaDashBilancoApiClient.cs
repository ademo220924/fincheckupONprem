using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Aktarma.DashBilanco;
using fincheckup.ApiClients.Models.Responses.Finance.Aktarma.DashBilanco;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceAktarmaDashBilancoApiClient : IApiClientBase
{
    [Post("/api/finance/aktarma/FinanceAktarmaDashBilanco/OnGet")]
    Task<GenericResult<AktarmaDashBilancoOnGetResponse>> GetAsync([Body] AktarmaDashBilancoOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/aktarma/FinanceAktarmaDashBilanco/OnGetGraphYear")]
    Task<GenericResult<AktarmaDashBilancoOnGetGraphYearResponse>> GetGraphYearAsync([Body] AktarmaDashBilancoOnGetGraphYearRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/aktarma/FinanceAktarmaDashBilanco/OnGetAktarmaResult")]
    Task<GenericResult<AktarmaDashBilancoOnGetAktarmaResultResponse>> GetAktarmaResultAsync([Body] AktarmaDashBilancoOnGetAktarmaResultRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/aktarma/FinanceAktarmaDashBilanco/OnGetDonukResult")]
    Task<GenericResult<AktarmaDashBilancoOnGetDonukResultResponse>> GetDonukResultAsync([Body] AktarmaDashBilancoOnGetDonukResultRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/aktarma/FinanceAktarmaDashBilanco/OnGetMarkupMarjin")]
    Task<GenericResult<AktarmaDashBilancoOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] AktarmaDashBilancoOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}