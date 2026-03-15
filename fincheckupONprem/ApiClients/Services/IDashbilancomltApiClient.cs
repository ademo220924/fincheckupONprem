using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Models.Requests.dashbilancomlt;
using fincheckup.ApiClients.Models.Responses.dashbilancomlt;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IDashbilancomltApiClient : IApiClientBase
{
    [Post("/api/dashbilancomlt")]
    Task<GenericResult<dashbilancomltOnGetResponse>> GetAsync(
        [Body] dashbilancomltOnGetRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancomlt/saler-main")]
    Task<GenericResult<dashbilancomltOnGetSalerMainResponse>> GetSalerMainAsync(
        [Body] dashbilancomltOnGetSalerMainRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancomlt/prio")]
    Task<GenericResult<dashbilancomltOnGetPrioResponse>> GetPrioAsync(
        [Body] dashbilancomltOnGetPrioRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancomlt/graph-year")]
    Task<GenericResult<dashbilancomltOnGetGraphYearResponse>> GetGraphYearAsync(
        [Body] dashbilancomltOnGetGraphYearRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancomlt/chart-rasyo")]
    Task<GenericResult<dashbilancomltOnGetChartRasyoResponse>> GetChartRasyoAsync(
        [Body] dashbilancomltOnGetChartRasyoRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancomlt/markup-marjin")]
    Task<GenericResult<dashbilancomltOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync(
        [Body] dashbilancomltOnGetMarkupMarjinRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancomlt/graph-comp")]
    Task<GenericResult<dashbilancomltOnGetGraphCompResponse>> GetGraphCompAsync(
        [Body] dashbilancomltOnGetGraphCompRequest request,
        CancellationToken cancellationToken);
}