using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.DashRevenueJrnl;
using fincheckup.ApiClients.Models.Responses.DashRevenueJrnl;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IDashRevenueJrnlApiClient : IApiClientBase
{
    [Post("/api/dashrevenuejrnl/OnGet")]
    Task<GenericResult<DashRevenueJrnlOnGetResponse>> GetAsync([Body] DashRevenueJrnlOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/dashrevenuejrnl/OnGetSalerMain")]
    Task<GenericResult<DashRevenueJrnlOnGetSalerMainResponse>> GetSalerMainAsync([Body] DashRevenueJrnlOnGetSalerMainRequest request, CancellationToken cancellationToken);

    [Post("/api/dashrevenuejrnl/OnGetPrio")]
    Task<GenericResult<DashRevenueJrnlOnGetPrioResponse>> GetPrioAsync([Body] DashRevenueJrnlOnGetPrioRequest request, CancellationToken cancellationToken);

    [Post("/api/dashrevenuejrnl/OnGetGraphYear")]
    Task<GenericResult<DashRevenueJrnlOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashRevenueJrnlOnGetGraphYearRequest request, CancellationToken cancellationToken);

    [Post("/api/dashrevenuejrnl/OnGetGraphComp")]
    Task<GenericResult<DashRevenueJrnlOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashRevenueJrnlOnGetGraphCompRequest request, CancellationToken cancellationToken);

    [Post("/api/dashrevenuejrnl/OnGetMarkupMarjin")]
    Task<GenericResult<DashRevenueJrnlOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] DashRevenueJrnlOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}