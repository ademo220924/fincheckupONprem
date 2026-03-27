using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpCrmConsole;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanUpCrmConsoleController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanUpCrmConsoleController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanUpCrmConsoleClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUpCrmConsole/OnGet")]
    Task<GenericResult<MizanUpCrmConsoleOnGetResponse>> GetAsync([Body] MizanUpCrmConsoleOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUpCrmConsole/OnGetSalerDate")]
    Task<GenericResult<MizanUpCrmConsoleOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUpCrmConsoleOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUpCrmConsole/OnGetSalerYear")]
    Task<GenericResult<MizanUpCrmConsoleOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUpCrmConsoleOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUpCrmConsole/OnGetSalerComp")]
    Task<GenericResult<MizanUpCrmConsoleOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUpCrmConsoleOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
}
