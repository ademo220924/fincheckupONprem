using fincheckup.ApiClients.Models.Requests.Finance.DashCrmDetailc;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceDashCrmDetailcController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceDashCrmDetailcController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceDashCrmDetailcClient : IApiClientBase
{
    [Post("/api/finance/FinanceDashCrmDetailc/OnGet")]
    Task<GenericResult<FinanceDashCrmDetailcOnGetResponse>> GetAsync([Body] FinanceDashCrmDetailcOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceDashCrmDetailc/OnGetChartRasyo")]
    Task<GenericResult<FinanceDashCrmDetailcOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] FinanceDashCrmDetailcOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
}
