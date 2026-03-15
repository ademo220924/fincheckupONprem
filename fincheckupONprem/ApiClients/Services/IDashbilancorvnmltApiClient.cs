using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Models.Requests.dashbilancorvnmlt;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Responses.dashbilancorvnmlt;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IDashbilancorvnmltApiClient : IApiClientBase
{
    [Post("/api/dashbilancorvnmlt")]
    Task<GenericResult<dashbilancorvnmltOnGetResponse>> GetAsync(
        [Body] DashbilancorvnmltOnGetRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancorvnmlt/saler-main")]
    Task<GenericResult<dashbilancorvnmltOnGetSalerMainResponse>> GetSalerMainAsync(
        [Body] dashbilancorvnmltOnGetSalerMainRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancorvnmlt/prio")]
    Task<GenericResult<dashbilancorvnmltOnGetPrioResponse>> GetPrioAsync(
        [Body] dashbilancorvnmltOnGetPrioRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancorvnmlt/graph-year")]
    Task<GenericResult<dashbilancorvnmltOnGetGraphYearResponse>> GetGraphYearAsync(
        [Body] dashbilancorvnmltOnGetGraphYearRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancorvnmlt/chart-rasyo")]
    Task<GenericResult<dashbilancorvnmltOnGetChartRasyoResponse>> GetChartRasyoAsync(
        [Body] dashbilancorvnmltOnGetChartRasyoRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancorvnmlt/markup-marjin")]
    Task<GenericResult<dashbilancorvnmltOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync(
        [Body] dashbilancorvnmltOnGetMarkupMarjinRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancorvnmlt/graph-comp")]
    Task<GenericResult<dashbilancorvnmltOnGetGraphCompResponse>> GetGraphCompAsync(
        [Body] dashbilancorvnmltOnGetGraphCompRequest request,
        CancellationToken cancellationToken);
}