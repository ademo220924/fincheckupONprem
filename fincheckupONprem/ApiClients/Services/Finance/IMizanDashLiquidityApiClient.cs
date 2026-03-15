using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashLiquidity;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.DashLiquidity;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanDashLiquidityApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/DashLiquidity/OnGet")]
    Task<GenericResult<MizanDashLiquidityOnGetResponse>> GetAsync([Body] MizanDashLiquidityOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/DashLiquidity/OnGetMarkupMarjin")]
    Task<GenericResult<MizanDashLiquidityOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanDashLiquidityOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}