using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Jrnl.DashBilancoRevenueJrnl;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.Jrnl.DashBilancoRevenueJrnl;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanJrnlDashBilancoRevenueJrnlApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/jrnl/DashBilancoRevenueJrnl/OnGet")]
    Task<GenericResult<MizanDashBilancoRevenueJrnlOnGetResponse>> GetAsync([Body] MizanDashBilancoRevenueJrnlOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/jrnl/DashBilancoRevenueJrnl/OnGetMarkupMarjin")]
    Task<GenericResult<MizanDashBilancoRevenueJrnlOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanDashBilancoRevenueJrnlOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}