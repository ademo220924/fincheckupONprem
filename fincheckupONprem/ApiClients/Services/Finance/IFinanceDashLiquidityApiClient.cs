using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.DashLiquidity;
using fincheckup.ApiClients.Models.Responses.Finance.DashLiquidity;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceDashLiquidityApiClient : IApiClientBase
{
    [Post("/api/finance/FinanceDashLiquidity/OnGet")]
    Task<GenericResult<FinanceDashLiquidityOnGetResponse>> GetAsync([Body] FinanceDashLiquidityOnGetRequest request, CancellationToken cancellationToken);
}