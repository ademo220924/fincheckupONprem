using fincheckup.ApiClients.Models.Requests.DashCrm;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for DashCrmController. Source: src/FinanceCheckUp.Api/Controllers/v1/DashCrmController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IDashCrmClient : IApiClientBase
{
    [Post("/api/dashcrm/OnGet")]
    Task<GenericResult<DashCrmOnGetResponse>> GetAsync([Body] DashCrmOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrm/OnGetCasino")]
    Task<GenericResult<DashCrmOnGetCasinoResponse>> GetCasinoAsync([Body] DashCrmOnGetCasinoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrm/OnGetRasyo")]
    Task<GenericResult<DashCrmOnGetChartRasyoResponse>> GetRasyoAsync([Body] DashCrmOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrm/OnGetRasyoa")]
    Task<GenericResult<DashCrmOnGetChartRasyoaResponse>> GetRasyoaAsync([Body] DashCrmOnGetChartRasyoaRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrm/OnGetRasyob")]
    Task<GenericResult<DashCrmOnGetChartRasyobResponse>> GetRasyobAsync([Body] DashCrmOnGetChartRasyobRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrm/OnGetRasyod")]
    Task<GenericResult<DashCrmOnGetChartRasyodResponse>> GetRasyodAsync([Body] DashCrmOnGetChartRasyodRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrm/OnGetRasyoc")]
    Task<GenericResult<DashCrmOnGetChartRasyocResponse>> GetRasyocAsync([Body] DashCrmOnGetChartRasyocRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrm/OnGetChartMali")]
    Task<GenericResult<DashCrmOnGetChartMaliResponse>> GetChartMaliAsync([Body] DashCrmOnGetChartMaliRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrm/OnGetChartLikid")]
    Task<GenericResult<DashCrmOnGetChartLikidResponse>> GetChartLikidAsync([Body] DashCrmOnGetChartLikidRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrm/OnGetDashRasyo")]
    Task<GenericResult<DashCrmOnGetDashRasyoResponse>> GetDashRasyoAsync([Body] DashCrmOnGetDashRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrm/OnGetGraphYear")]
    Task<GenericResult<DashCrmOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashCrmOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrm/OnGetGraphComp")]
    Task<GenericResult<DashCrmOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashCrmOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
}
