using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.reportpot;
using fincheckup.ApiClients.Models.Responses.reportpot;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IReportpotApiClient : IApiClientBase
{
    [Post("/api/reportpot")]
    Task<GenericResult<reportpotOnGetResponse>> GetAsync(
        [Body] reportpotOnGetRequest request,
        CancellationToken cancellationToken);
}