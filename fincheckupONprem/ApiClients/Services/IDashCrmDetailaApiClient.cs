using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Responses.DashCrmDetaila;
using fincheckup.ApiClients.Models.Requests.DashCrmDetaila;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IDashCrmDetailaApiClient : IApiClientBase
{
    [Post("/api/dashcrmdetaila/OnGet")]
    Task<GenericResult<DashCrmDetailaOnGetResponse>> GetAsync([Body] DashCrmDetailaOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrmdetaila/OnGetSalerMain")]
    Task<GenericResult<DashCrmDetailaOnGetSalerMainResponse>> GetSalerMainAsync([Body] DashCrmDetailaOnGetSalerMainRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrmdetaila/OnGetPrio")]
    Task<GenericResult<DashCrmDetailaOnGetPrioResponse>> GetPrioAsync([Body] DashCrmDetailaOnGetPrioRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrmdetaila/OnGetGraphYear")]
    Task<GenericResult<DashCrmDetailaOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashCrmDetailaOnGetGraphYearRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrmdetaila/OnGetGraphComp")]
    Task<GenericResult<DashCrmDetailaOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashCrmDetailaOnGetGraphCompRequest request, CancellationToken cancellationToken);
}