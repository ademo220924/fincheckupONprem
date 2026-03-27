using fincheckup.ApiClients.Models.Requests.DashCpmNew;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for DashCpmNewController. Source: src/FinanceCheckUp.Api/Controllers/v1/DashCpmNewController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IDashCpmNewClient : IApiClientBase
{
    [Post("/api/dashcpmnew/OnGet")]
    Task<GenericResult<DashCpmNewOnGetResponse>> GetAsync([Body] DashCpmNewOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcpmnew/OnGetCasino")]
    Task<GenericResult<DashCpmNewOnGetCasinoResponse>> GetCasinoAsync([Body] DashCpmNewOnGetCasinoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcpmnew/OnGetChartRasyo")]
    Task<GenericResult<DashCpmNewOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] DashCpmNewOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcpmnew/OnGetChartRasyob")]
    Task<GenericResult<DashCpmNewOnGetChartRasyobResponse>> GetChartRasyobAsync([Body] DashCpmNewOnGetChartRasyobRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcpmnew/OnGetChartRasyoc")]
    Task<GenericResult<DashCpmNewOnGetChartRasyocResponse>> GetChartRasyocAsync([Body] DashCpmNewOnGetChartRasyocRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcpmnew/OnGetChartMali")]
    Task<GenericResult<DashCpmNewOnGetChartMaliResponse>> GetChartMaliAsync([Body] DashCpmNewOnGetChartMaliRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcpmnew/OnGetChartLikid")]
    Task<GenericResult<DashCpmNewOnGetChartLikidResponse>> GetChartLikidAsync([Body] DashCpmNewOnGetChartLikidRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcpmnew/OnGetDashRasyo")]
    Task<GenericResult<DashCpmNewOnGetDashRasyoResponse>> GetDashRasyoAsync([Body] DashCpmNewOnGetDashRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcpmnew/OnGetGraphYear")]
    Task<GenericResult<DashCpmNewOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashCpmNewOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcpmnew/OnGetGraphComp")]
    Task<GenericResult<DashCpmNewOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashCpmNewOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
}
