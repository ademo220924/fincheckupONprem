using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.upbalanceakt;
using fincheckup.ApiClients.Models.Responses.upbalanceakt;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IUpBalanceaktApiClient : IApiClientBase
{
    [Post("/api/upbalanceakt")]
    Task<GenericResult<upbalanceaktOnGetResponse>> GetAsync(
        [Body] upbalanceaktOnGetRequest request,
        CancellationToken cancellationToken);
}