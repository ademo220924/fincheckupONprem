using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Responses.Finance.UpCrmConsole;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Finance.UpCrmConsole;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceUpCrmConsoleApiClient : IApiClientBase
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