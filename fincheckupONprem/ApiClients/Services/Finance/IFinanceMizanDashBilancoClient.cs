using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashBilanco;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanDashBilancoController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanDashBilancoController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanDashBilancoClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanDashBilanco/OnGet")]
    Task<GenericResult<MizanDashBilancoOnGetResponse>> GetAsync([Body] MizanDashBilancoOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanDashBilanco/OnGetChartRasyo")]
    Task<GenericResult<MizanDashBilancoOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] MizanDashBilancoOnGetChartRasyoQuery request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanDashBilanco/OnGetMarkupMarjin")]
    Task<GenericResult<MizanDashBilancoOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanDashBilancoOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
