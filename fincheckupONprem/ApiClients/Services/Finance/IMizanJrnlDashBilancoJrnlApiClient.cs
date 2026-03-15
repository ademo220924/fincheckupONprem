using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Jrnl.DashBilancoJrnl;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.Jrnl.DashBilancoJrnl;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanJrnlDashBilancoJrnlApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/jrnl/DashBilancoJrnl/OnGet")]
    Task<GenericResult<MizanDashBilancoJrnlOnGetResponse>> GetAsync([Body] MizanDashBilancoJrnlOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/jrnl/DashBilancoJrnl/OnGetMarkupMarjin")]
    Task<GenericResult<MizanDashBilancoJrnlOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanDashBilancoJrnlOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}