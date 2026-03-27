using fincheckup.ApiClients.Models.Requests.Finance.DashCrmDetail;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceDashCrmDetailController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceDashCrmDetailController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceDashCrmDetailClient : IApiClientBase
{
    [Post("/api/finance/FinanceDashCrmDetail/OnGet")]
    Task<GenericResult<FinanceDashCrmDetailOnGetResponse>> GetAsync([Body] FinanceDashCrmDetailOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceDashCrmDetail/OnGetChartRasyo")]
    Task<GenericResult<FinanceDashCrmDetailOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] FinanceDashCrmDetailOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
}
