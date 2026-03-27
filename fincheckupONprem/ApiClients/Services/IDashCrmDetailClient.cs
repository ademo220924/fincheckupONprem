using fincheckup.ApiClients.Models.Requests.DashCrmDetail;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for DashCrmDetailController. Source: src/FinanceCheckUp.Api/Controllers/v1/DashCrmDetailController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IDashCrmDetailClient : IApiClientBase
{
    [Post("/api/dashcrmdetail/OnGet")]
    Task<GenericResult<DashCrmDetailOnGetResponse>> GetAsync([Body] DashCrmDetailOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrmdetail/OnGetSalerMain")]
    Task<GenericResult<DashCrmDetailOnGetSalerMainResponse>> GetSalerMainAsync([Body] DashCrmDetailOnGetSalerMainRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrmdetail/OnGetPrio")]
    Task<GenericResult<DashCrmDetailOnGetPrioResponse>> GetPrioAsync([Body] DashCrmDetailOnGetPrioRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrmdetail/OnGetGraphYear")]
    Task<GenericResult<DashCrmDetailOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashCrmDetailOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrmdetail/OnGetChartRasyo")]
    Task<GenericResult<DashCrmDetailOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] DashCrmDetailOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
}
