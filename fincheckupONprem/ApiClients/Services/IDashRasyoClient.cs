using fincheckup.ApiClients.Models.Requests.DashRasyo;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for DashRasyoController. Source: src/FinanceCheckUp.Api/Controllers/v1/DashRasyoController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IDashRasyoClient : IApiClientBase
{
    [Post("/api/dashrasyo/OnGet")]
    Task<GenericResult<DashRasyoOnGetResponse>> GetAsync([Body] DashRasyoOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashrasyo/OnGetCasino")]
    Task<GenericResult<DashRasyoOnGetCasinoResponse>> GetCasinoAsync([Body] DashRasyoOnGetCasinoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashrasyo/OnGetChartRasyo")]
    Task<GenericResult<DashRasyoOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] DashRasyoOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashrasyo/OnGetChartRasyoa")]
    Task<object> GetChartRasyoaAsync([Body] DashRasyoOnGetChartRasyoaRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashrasyo/OnGetChartRasyob")]
    Task<GenericResult<DashRasyoOnGetChartRasyobResponse>> GetChartRasyobAsync([Body] DashRasyoOnGetChartRasyobRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashrasyo/OnGetChartMali")]
    Task<GenericResult<DashRasyoOnGetChartMaliResponse>> GetChartMaliAsync([Body] DashRasyoOnGetChartMaliRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashrasyo/OnGetChartLikid")]
    Task<GenericResult<DashRasyoOnGetChartLikidResponse>> GetChartLikidAsync([Body] DashRasyoOnGetChartLikidRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashrasyo/OnGetDashRasyo")]
    Task<GenericResult<DashRasyoOnGetDashRasyoResponse>> GetDashRasyoAsync([Body] DashRasyoOnGetDashRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashrasyo/OnGetGraphYear")]
    Task<GenericResult<DashRasyoOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashRasyoOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashrasyo/OnGetGraphComp")]
    Task<GenericResult<DashRasyoOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashRasyoOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
}
