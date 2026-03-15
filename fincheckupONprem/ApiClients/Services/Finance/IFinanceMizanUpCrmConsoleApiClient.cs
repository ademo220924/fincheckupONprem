using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpCrmConsole;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpCrmConsole;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;
using System.Threading;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceMizanUpCrmConsoleApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUpCrmConsole/OnGet")]
    Task<GenericResult<MizanUpCrmConsoleOnGetResponse>> GetAsync([Body] MizanUpCrmConsoleOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceMizanUpCrmConsole/OnGetSalerDate")]
    Task<GenericResult<MizanUpCrmConsoleOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUpCrmConsoleOnGetSalerDateRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceMizanUpCrmConsole/OnGetSalerYear")]
    Task<GenericResult<MizanUpCrmConsoleOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUpCrmConsoleOnGetSalerYearRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceMizanUpCrmConsole/OnGetSalerComp")]
    Task<GenericResult<MizanUpCrmConsoleOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUpCrmConsoleOnGetSalerCompRequest request, CancellationToken cancellationToken);
}