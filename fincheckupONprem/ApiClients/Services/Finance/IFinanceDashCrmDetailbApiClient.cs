using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.DashCrmDetailb;
using fincheckup.ApiClients.Models.Responses.Finance.DashCrmDetailb;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceDashCrmDetailbApiClient : IApiClientBase
{
    [Post("/api/finance/FinanceDashCrmDetailb/OnGet")]
    Task<GenericResult<FinanceDashCrmDetailbOnGetResponse>> GetAsync([Body] FinanceDashCrmDetailbOnGetRequest request, CancellationToken cancellationToken);
}