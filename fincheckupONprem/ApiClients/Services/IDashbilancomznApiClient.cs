using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.dashbilancomzn;
using fincheckup.ApiClients.Models.Responses.dashbilancomzn;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IDashbilancomznApiClient : IApiClientBase
{
    [Post("/api/dashbilancomzn")]
    Task<GenericResult<dashbilancomznOnGetResponse>> GetAsync(
        [Body] dashbilancomznOnGetRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancomzn/saler-main")]
    Task<GenericResult<dashbilancomznOnGetSalerMainResponse>> GetSalerMainAsync(
        [Body] dashbilancomznOnGetSalerMainRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancomzn/prio")]
    Task<GenericResult<dashbilancomznOnGetPrioResponse>> GetPrioAsync(
        [Body] dashbilancomznOnGetPrioRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancomzn/graph-year")]
    Task<GenericResult<dashbilancomznOnGetGraphYearResponse>> GetGraphYearAsync(
        [Body] dashbilancomznOnGetGraphYearRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancomzn/chart-rasyo")]
    Task<GenericResult<dashbilancomznOnGetChartRasyoResponse>> GetChartRasyoAsync(
        [Body] dashbilancomznOnGetChartRasyoRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancomzn/graph-comp")]
    Task<GenericResult<dashbilancomznOnGetGraphCompResponse>> GetGraphCompAsync(
        [Body] dashbilancomznOnGetGraphCompRequest request,
        CancellationToken cancellationToken);
}
