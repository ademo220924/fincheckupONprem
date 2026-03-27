using fincheckup.ApiClients.Models.Requests.Finance.DashLiquidity;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceDashLiquidityController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceDashLiquidityController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceDashLiquidityClient : IApiClientBase
{
    [Post("/api/finance/FinanceDashLiquidity/OnGet")]
    Task<GenericResult<FinanceDashLiquidityOnGetResponse>> GetAsync([Body] FinanceDashLiquidityOnGetRequest request, CancellationToken cancellationToken = default);
}
