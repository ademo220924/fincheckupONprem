using fincheckup.ApiClients.Models.Requests.Finance.DashCrmDetaila;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceDashCrmDetailaController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceDashCrmDetailaController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceDashCrmDetailaClient : IApiClientBase
{
    [Post("/api/finance/FinanceDashCrmDetaila/OnGet")]
    Task<GenericResult<FinanceDashCrmDetailaOnGetResponse>> GetAsync([Body] FinanceDashCrmDetailaOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceDashCrmDetaila/OnGetChartRasyo")]
    Task<GenericResult<FinanceDashCrmDetailaOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] FinanceDashCrmDetailaOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
}
