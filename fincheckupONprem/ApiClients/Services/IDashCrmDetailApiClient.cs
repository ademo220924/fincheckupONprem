using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Models.Responses.DashCrmDetail;
using fincheckup.ApiClients.Models.Requests.DashCrmDetail;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IDashCrmDetailApiClient : IApiClientBase
{
    [Post("/api/dashcrmdetail/OnGet")]
    Task<GenericResult<DashCrmDetailOnGetResponse>> GetAsync([Body] DashCrmDetailOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrmdetail/OnGetSalerMain")]
    Task<GenericResult<DashCrmDetailOnGetSalerMainResponse>> GetSalerMainAsync([Body] DashCrmDetailOnGetSalerMainRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrmdetail/OnGetPrio")]
    Task<GenericResult<DashCrmDetailOnGetPrioResponse>> GetPrioAsync([Body] DashCrmDetailOnGetPrioRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrmdetail/OnGetGraphYear")]
    Task<GenericResult<DashCrmDetailOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashCrmDetailOnGetGraphYearRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrmdetail/OnGetChartRasyo")]
    Task<GenericResult<DashCrmDetailOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] DashCrmDetailOnGetChartRasyoRequest request, CancellationToken cancellationToken);
}