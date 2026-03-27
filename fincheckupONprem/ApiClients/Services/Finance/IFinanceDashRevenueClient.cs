using fincheckup.ApiClients.Models.Requests.Finance.DashRevenue;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceDashRevenueController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceDashRevenueController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceDashRevenueClient : IApiClientBase
{
    [Post("/api/finance/FinanceDashRevenue/OnGet")]
    Task<GenericResult<FinanceDashRevenueOnGetResponse>> GetAsync([Body] FinanceDashRevenueOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceDashRevenue/OnGetChartRasyo")]
    Task<GenericResult<FinanceDashRevenueOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] FinanceDashRevenueOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
}
