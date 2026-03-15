using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Responses.dashbilancoakt;
using fincheckup.ApiClients.Models.Requests.dashbilancoakt;
using fincheckup.ApiClients.Models.Requests.Dashbilancoakt;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IDashbilancoaktApiClient : IApiClientBase
{
    [Post("/api/dashbilancoakt")]
    Task<GenericResult<dashbilancoaktOnGetResponse>> GetAsync([Body] dashbilancoaktOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/dashbilancoakt/saler-main")]
    Task<GenericResult<dashbilancoaktOnGetSalerMainResponse>> GetSalerMainAsync([Body] dashbilancoaktOnGetSalerMainRequest request, CancellationToken cancellationToken);

    [Post("/api/dashbilancoakt/prio")]
    Task<GenericResult<dashbilancoaktOnGetPrioResponse>> GetPrioAsync([Body] dashbilancoaktOnGetPrioRequest request, CancellationToken cancellationToken);

    [Post("/api/dashbilancoakt/graph-year")]
    Task<GenericResult<dashbilancoaktOnGetGraphYearResponse>> GetGraphYearAsync([Body] dashbilancoaktOnGetGraphYearRequest request, CancellationToken cancellationToken);

    [Post("/api/dashbilancoakt/graph-comp")]
    Task<GenericResult<dashbilancoaktOnGetGraphCompResponse>> GetGraphCompAsync([Body] dashbilancoaktOnGetGraphCompRequest request, CancellationToken cancellationToken);
}