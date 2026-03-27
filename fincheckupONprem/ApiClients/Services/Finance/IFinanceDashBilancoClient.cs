using fincheckup.ApiClients.Models.Requests.Finance.DashBilanco;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceDashBilancoController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceDashBilancoController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceDashBilancoClient : IApiClientBase
{
    [Post("/api/finance/FinanceDashBilanco/OnGet")]
    Task<GenericResult<FinanceDashBilancoOnGetResponse>> GetAsync([Body] FinanceDashBilancoOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceDashBilanco/OnGetChartRasyo")]
    Task<GenericResult<FinanceDashBilancoOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] FinanceDashBilancoOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
}
