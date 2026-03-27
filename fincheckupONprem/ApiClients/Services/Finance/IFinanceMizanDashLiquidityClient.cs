using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashLiquidity;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanDashLiquidityController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanDashLiquidityController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanDashLiquidityClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanDashLiquidity/OnGet")]
    Task<GenericResult<MizanDashLiquidityOnGetResponse>> GetAsync([Body] MizanDashLiquidityOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanDashLiquidity/OnGetMarkupMarjin")]
    Task<GenericResult<MizanDashLiquidityOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanDashLiquidityOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
