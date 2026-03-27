using fincheckup.ApiClients.Models.Requests.Finance.UpCrmConsole;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceUpCrmConsoleController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceUpCrmConsoleController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceUpCrmConsoleClient : IApiClientBase
{
    [Post("/api/finance/FinanceUpCrmConsole/OnGet")]
    Task<GenericResult<FinanceUpCrmConsoleOnGetResponse>> GetAsync([Body] FinanceUpCrmConsoleOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceUpCrmConsole/OnGetSalerDate")]
    Task<GenericResult<FinanceUpCrmConsoleOnGetSalerDateResponse>> GetSalerDateAsync([Body] FinanceUpCrmConsoleOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceUpCrmConsole/OnGetSalerYear")]
    Task<GenericResult<FinanceUpCrmConsoleOnGetSalerYearResponse>> GetSalerYearAsync([Body] FinanceUpCrmConsoleOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceUpCrmConsole/OnGetSalerComp")]
    Task<GenericResult<FinanceUpCrmConsoleOnGetSalerCompResponse>> GetSalerCompAsync([Body] FinanceUpCrmConsoleOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
}
