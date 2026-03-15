using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.UpBalanceAkt;
using fincheckup.ApiClients.Models.Responses.Finance.UpBalanceAkt;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceUpBalanceAktApiClient : IApiClientBase
{
    [Post("/api/finance/FinanceUpBalanceAkt/OnGet")]
    Task<GenericResult<FinanceUpBalanceAktOnGetResponse>> GetAsync([Body] FinanceUpBalanceAktOnGetRequest request, CancellationToken cancellationToken = default);
}