using fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashRevenue;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanDashRevenueController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanDashRevenueController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanDashRevenueClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanDashRevenue/OnGet")]
    Task<GenericResult<MizanDashRevenueOnGetResponse>> GetAsync([Body] MizanDashRevenueOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanDashRevenue/OnGetChartRasyo")]
    Task<GenericResult<MizanDashRevenueOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] MizanDashRevenueOnGetChartRasyoQuery request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanDashRevenue/OnGetMarkupMarjin")]
    Task<GenericResult<MizanDashRevenueOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanDashRevenueOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
