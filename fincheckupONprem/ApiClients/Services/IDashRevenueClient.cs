using fincheckup.ApiClients.Models.Requests.DashRevenue;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for DashRevenueController. Source: src/FinanceCheckUp.Api/Controllers/v1/DashRevenueController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IDashRevenueClient : IApiClientBase
{
    [Post("/api/dashrevenue/OnGet")]
    Task<GenericResult<DashRevenueOnGetResponse>> GetAsync([Body] DashRevenueOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashrevenue/OnGetSalerMain")]
    Task<GenericResult<DashRevenueOnGetSalerMainResponse>> GetSalerMainAsync([Body] DashRevenueOnGetSalerMainRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashrevenue/OnGetPrio")]
    Task<GenericResult<DashRevenueOnGetPrioResponse>> GetPrioAsync([Body] DashRevenueOnGetPrioRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashrevenue/OnGetChartRasyo")]
    Task<GenericResult<DashRevenueOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] DashRevenueOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashrevenue/OnGetGraphYear")]
    Task<GenericResult<DashRevenueOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashRevenueOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashrevenue/OnGetGraphComp")]
    Task<GenericResult<DashRevenueOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashRevenueOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
}
