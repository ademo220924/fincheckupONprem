using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Models.Responses.dashbilancorvnmzn;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.dashbilancorvnmzn;
using fincheckup.ApiClients.Models.Responses.dashbilancorvnmzn;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IDashbilancorvnmznApiClient : IApiClientBase
{
    [Post("/api/dashbilancorvnmzn")]
    Task<GenericResult<dashbilancorvnmznOnGetResponse>> GetAsync(
        [Body] dashbilancorvnmznOnGetRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancorvnmzn/saler-main")]
    Task<GenericResult<dashbilancorvnmznOnGetSalerMainResponse>> GetSalerMainAsync(
        [Body] dashbilancorvnmznOnGetSalerMainRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancorvnmzn/prio")]
    Task<GenericResult<dashbilancorvnmznOnGetPrioResponse>> GetPrioAsync(
        [Body] dashbilancorvnmznOnGetPrioRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancorvnmzn/graph-year")]
    Task<GenericResult<dashbilancorvnmznOnGetGraphYearResponse>> GetGraphYearAsync(
        [Body] dashbilancorvnmznOnGetGraphYearRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancorvnmzn/chart-rasyo")]
    Task<GenericResult<dashbilancorvnmznOnGetChartRasyoResponse>> GetChartRasyoAsync(
        [Body] dashbilancorvnmznOnGetChartRasyoRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancorvnmzn/graph-comp")]
    Task<GenericResult<dashbilancorvnmznOnGetGraphCompResponse>> GetGraphCompAsync(
        [Body] dashbilancorvnmznOnGetGraphCompRequest request,
        CancellationToken cancellationToken);
}