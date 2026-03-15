using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalanceAkt;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpBalanceAkt;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanUpBalanceAktApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/UpBalanceAkt/OnGet")]
    Task<GenericResult<MizanUpBalanceAktOnGetResponse>> GetAsync([Body] MizanUpBalanceAktOnGetRequest request, CancellationToken cancellationToken);
}