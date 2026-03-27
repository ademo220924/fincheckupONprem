using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashBilancoRevenueMlt;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanDashBilancoRevenueMltController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanDashBilancoRevenueMltController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanDashBilancoRevenueMltClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanDashBilancoRevenueMlt/OnGet")]
    Task<GenericResult<MizanDashBilancoRevenueMltOnGetResponse>> GetAsync([Body] MizanDashBilancoRevenueMltOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanDashBilancoRevenueMlt/OnGetChartRasyo")]
    Task<GenericResult<MizanDashBilancoRevenueMltOnGetChartRasyoResponse>> GetGetChartRasyoAsync([Body] MizanDashBilancoRevenueMltOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanDashBilancoRevenueMlt/OnGetMarkupMarjin")]
    Task<GenericResult<MizanDashBilancoRevenueMltOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanDashBilancoRevenueMltOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
