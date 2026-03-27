using fincheckup.ApiClients.Models.Requests.DashRevenueJrnl;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for DashRevenueJrnlController. Source: src/FinanceCheckUp.Api/Controllers/v1/DashRevenueJrnlController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IDashRevenueJrnlClient : IApiClientBase
{
    [Post("/api/dashrevenuejrnl/OnGet")]
    Task<GenericResult<DashRevenueJrnlOnGetResponse>> GetAsync([Body] DashRevenueJrnlOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashrevenuejrnl/OnGetSalerMain")]
    Task<GenericResult<DashRevenueJrnlOnGetSalerMainResponse>> GetSalerMainAsync([Body] DashRevenueJrnlOnGetSalerMainRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashrevenuejrnl/OnGetPrio")]
    Task<GenericResult<DashRevenueJrnlOnGetPrioResponse>> GetPrioAsync([Body] DashRevenueJrnlOnGetPrioRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashrevenuejrnl/OnGetGraphYear")]
    Task<GenericResult<DashRevenueJrnlOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashRevenueJrnlOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashrevenuejrnl/OnGetGraphComp")]
    Task<GenericResult<DashRevenueJrnlOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashRevenueJrnlOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashrevenuejrnl/OnGetMarkupMarjin")]
    Task<GenericResult<DashRevenueJrnlOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] DashRevenueJrnlOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
