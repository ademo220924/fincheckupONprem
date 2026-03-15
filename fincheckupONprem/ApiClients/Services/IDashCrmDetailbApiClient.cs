using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Responses.DashCrmDetailb;
using fincheckup.ApiClients.Models.Requests.DashCrmDetailb;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IDashCrmDetailbApiClient : IApiClientBase
{
    [Post("/api/dashcrmdetailb/OnGet")]
    Task<GenericResult<DashCrmDetailbOnGetResponse>> GetAsync([Body] DashCrmDetailbOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrmdetailb/OnGetSalerMain")]
    Task<GenericResult<DashCrmDetailbOnGetSalerMainResponse>> GetSalerMainAsync([Body] DashCrmDetailbOnGetSalerMainRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrmdetailb/OnGetPrio")]
    Task<GenericResult<DashCrmDetailbOnGetPrioResponse>> GetPrioAsync([Body] DashCrmDetailbOnGetPrioRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrmdetailb/OnGetGraphYear")]
    Task<GenericResult<DashCrmDetailbOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashCrmDetailbOnGetGraphYearRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrmdetailb/OnGetRasyoChart")]
    Task<GenericResult<DashCrmDetailbOnGetChartRasyoResponse>> GetRasyoChartAsync([Body] DashCrmDetailbOnGetChartRasyoRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrmdetailb/OnGetGraphComp")]
    Task<GenericResult<DashCrmDetailbOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashCrmDetailbOnGetGraphCompRequest request, CancellationToken cancellationToken);
}