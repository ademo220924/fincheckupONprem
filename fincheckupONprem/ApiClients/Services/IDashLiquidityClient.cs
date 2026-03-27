using fincheckup.ApiClients.Models.Requests.DashLiquidity;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for DashLiquidityController. Source: src/FinanceCheckUp.Api/Controllers/v1/DashLiquidityController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IDashLiquidityClient : IApiClientBase
{
    [Post("/api/dashliquidity/OnGet")]
    Task<GenericResult<DashLiquidityOnGetResponse>> GetAsync([Body] DashLiquidityOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashliquidity/OnGetSalerMain")]
    Task<GenericResult<DashLiquidityOnGetSalerMainResponse>> GetSalerMainAsync([Body] DashLiquidityOnGetSalerMainRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashliquidity/OnGetPrio")]
    Task<GenericResult<DashLiquidityOnGetPrioResponse>> GetPrioAsync([Body] DashLiquidityOnGetPrioRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashliquidity/OnGetGraphYear")]
    Task<GenericResult<DashLiquidityOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashLiquidityOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashliquidity/OnGetGraphComp")]
    Task<GenericResult<DashLiquidityOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashLiquidityOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
}
