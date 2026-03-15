using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.dashbilancorvnakt;
using fincheckup.ApiClients.Models.Responses.dashbilancorvnakt;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;
public interface IDashbilancorvnaktApiClient : IApiClientBase
{
    [Post("/api/dashbilancorvnakt")]
    Task<GenericResult<dashbilancorvnaktOnGetResponse>> GetAsync(
        [Body] dashbilancorvnaktOnGetRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancorvnakt/saler-main")]
    Task<GenericResult<dashbilancorvnaktOnGetSalerMainResponse>> GetSalerMainAsync(
        [Body] dashbilancorvnaktOnGetSalerMainRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancorvnakt/prio")]
    Task<GenericResult<dashbilancorvnaktOnGetPrioResponse>> GetPrioAsync(
        [Body] dashbilancorvnaktOnGetPrioRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancorvnakt/graph-year")]
    Task<GenericResult<dashbilancorvnaktOnGetGraphYearResponse>> GetGraphYearAsync(
        [Body] dashbilancorvnaktOnGetGraphYearRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancorvnakt/chart-rasyo")]
    Task<GenericResult<dashbilancorvnaktOnGetChartRasyoResponse>> GetChartRasyoAsync(
        [Body] dashbilancorvnaktOnGetChartRasyoRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancorvnakt/graph-comp")]
    Task<GenericResult<dashbilancorvnaktOnGetGraphCompResponse>> GetGraphCompAsync(
        [Body] dashbilancorvnaktOnGetGraphCompRequest request,
        CancellationToken cancellationToken);
}