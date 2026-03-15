using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.upbalancemzn;
using fincheckup.ApiClients.Models.Responses.upbalancemzn;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IUpBalancemznApiClient : IApiClientBase
{
    [Post("/api/upbalancemzn")]
    Task<GenericResult<upbalancemznOnGetResponse>> GetAsync(
        [Body] upbalancemznOnGetRequest request,
        CancellationToken cancellationToken);
}