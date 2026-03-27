using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashBilancoMlt;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanDashBilancoMltController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanDashBilancoMltController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanDashBilancoMltClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanDashBilancoMlt/OnGet")]
    Task<GenericResult<MizanDashBilancoMltOnGetResponse>> GetAsync([Body] MizanDashBilancoMltOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanDashBilancoMlt/OnGetChartRasyo")]
    Task<GenericResult<MizanDashBilancoMltOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] MizanDashBilancoMltOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanDashBilancoMlt/OnGetMarkupMarjin")]
    Task<GenericResult<MizanDashBilancoMltOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanDashBilancoMltOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
