using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalanceAkt;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpBalanceAkt;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceMizanUpBalanceAktApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUpBalanceAkt/OnGet")]
    Task<GenericResult<MizanUpBalanceAktOnGetResponse>> GetAsync([Body] MizanUpBalanceAktOnGetRequest request);
}