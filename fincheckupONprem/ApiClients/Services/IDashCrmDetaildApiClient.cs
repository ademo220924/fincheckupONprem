using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.DashCrmDetaild;
using fincheckup.ApiClients.Models.Responses.DashCrmDetaild;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IDashCrmDetaildApiClient : IApiClientBase
{
    [Post("/api/dashcrmdetaild/OnGet")]
    Task<GenericResult<DashCrmDetaildOnGetResponse>> GetAsync([Body] DashCrmDetaildOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrmdetaild/OnGetSalerMain")]
    Task<GenericResult<DashCrmDetaildOnGetSalerMainResponse>> GetSalerMainAsync([Body] DashCrmDetaildOnGetSalerMainRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrmdetaild/OnGetChartRasyo")]
    Task<GenericResult<DashCrmDetaildOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] DashCrmDetaildOnGetChartRasyoRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcrmdetaild/OnGetGraphComp")]
    Task<GenericResult<DashCrmDetaildOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashCrmDetaildOnGetGraphCompRequest request, CancellationToken cancellationToken);
}