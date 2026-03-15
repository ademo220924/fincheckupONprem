using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.DashCpmNew;
using fincheckup.ApiClients.Models.Responses.DashCpmNew;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IDashCpmNewApiClient : IApiClientBase
{
    [Post("/api/dashcpmnew/OnGet")]
    Task<GenericResult<DashCpmNewOnGetResponse>> GetAsync([Body] DashCpmNewOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcpmnew/OnGetCasino")]
    Task<GenericResult<DashCpmNewOnGetCasinoResponse>> GetCasinoAsync([Body] DashCpmNewOnGetCasinoRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcpmnew/OnGetChartRasyo")]
    Task<GenericResult<DashCpmNewOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] DashCpmNewOnGetChartRasyoRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcpmnew/OnGetChartRasyob")]
    Task<GenericResult<DashCpmNewOnGetChartRasyobResponse>> GetChartRasyobAsync([Body] DashCpmNewOnGetChartRasyobRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcpmnew/OnGetChartRasyoc")]
    Task<GenericResult<DashCpmNewOnGetChartRasyocResponse>> GetChartRasyocAsync([Body] DashCpmNewOnGetChartRasyocRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcpmnew/OnGetChartMali")]
    Task<GenericResult<DashCpmNewOnGetChartMaliResponse>> GetChartMaliAsync([Body] DashCpmNewOnGetChartMaliRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcpmnew/OnGetChartLikid")]
    Task<GenericResult<DashCpmNewOnGetChartLikidResponse>> GetChartLikidAsync([Body] DashCpmNewOnGetChartLikidRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcpmnew/OnGetDashRasyo")]
    Task<GenericResult<DashCpmNewOnGetDashRasyoResponse>> GetDashRasyoAsync([Body] DashCpmNewOnGetDashRasyoRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcpmnew/OnGetGraphYear")]
    Task<GenericResult<DashCpmNewOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashCpmNewOnGetGraphYearRequest request, CancellationToken cancellationToken);

    [Post("/api/dashcpmnew/OnGetGraphComp")]
    Task<GenericResult<DashCpmNewOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashCpmNewOnGetGraphCompRequest request, CancellationToken cancellationToken);
}