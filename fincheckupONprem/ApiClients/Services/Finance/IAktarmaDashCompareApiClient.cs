using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Aktarma.DashCompare;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.Aktarma.DashCompare;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;
using CancellationToken = System.Threading.CancellationToken;

namespace fincheckup.ApiClients.Services.Finance;

public interface IAktarmaDashCompareApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/aktarma/FinanceMizanAktarmaDashCompare/OnGet")]
    Task<GenericResult<MizanAktarmaDashCompareOnGetResponse>> GetAsync([Body] MizanAktarmaDashCompareOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/aktarma/FinanceMizanAktarmaDashCompare/OnGetMarkupMarjin")]
    Task<GenericResult<MizanAktarmaDashCompareOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanAktarmaDashCompareOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}