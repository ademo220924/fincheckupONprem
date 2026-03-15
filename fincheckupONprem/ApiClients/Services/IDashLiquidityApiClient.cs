using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Responses.DashLiquidity;
using fincheckup.ApiClients.Models.Requests.DashLiquidity;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;


public interface IDashLiquidityApiClient : IApiClientBase
{
    [Post("/api/dashliquidity/OnGet")]
    Task<GenericResult<DashLiquidityOnGetResponse>> GetAsync([Body] DashLiquidityOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/dashliquidity/OnGetSalerMain")]
    Task<GenericResult<DashLiquidityOnGetSalerMainResponse>> GetSalerMainAsync([Body] DashLiquidityOnGetSalerMainRequest request, CancellationToken cancellationToken);

    [Post("/api/dashliquidity/OnGetPrio")]
    Task<GenericResult<DashLiquidityOnGetPrioResponse>> GetPrioAsync([Body] DashLiquidityOnGetPrioRequest request, CancellationToken cancellationToken);

    [Post("/api/dashliquidity/OnGetGraphYear")]
    Task<GenericResult<DashLiquidityOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashLiquidityOnGetGraphYearRequest request, CancellationToken cancellationToken);

    [Post("/api/dashliquidity/OnGetGraphComp")]
    Task<GenericResult<DashLiquidityOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashLiquidityOnGetGraphCompRequest request, CancellationToken cancellationToken);
}