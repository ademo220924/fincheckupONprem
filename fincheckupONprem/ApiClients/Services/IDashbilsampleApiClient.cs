using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.dashbilsample;
using fincheckup.ApiClients.Models.Responses.dashbilsample;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IDashbilsampleApiClient : IApiClientBase
{
    [Post("/api/dashbilsample")]
    Task<GenericResult<dashbilsampleOnGetResponse>> GetAsync(
        [Body] dashbilsampleOnGetRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilsample/saler-main")]
    Task<GenericResult<dashbilsampleOnGetSalerMainResponse>> GetSalerMainAsync(
        [Body] dashbilsampleOnGetSalerMainRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilsample/prio")]
    Task<GenericResult<dashbilsampleOnGetPrioResponse>> GetPrioAsync(
        [Body] dashbilsampleOnGetPrioRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilsample/graph-year")]
    Task<GenericResult<dashbilsampleOnGetGraphYearResponse>> GetGraphYearAsync(
        [Body] dashbilsampleOnGetGraphYearRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilsample/graph-comp")]
    Task<GenericResult<dashbilsampleOnGetGraphCompResponse>> GetGraphCompAsync(
        [Body] dashbilsampleOnGetGraphCompRequest request,
        CancellationToken cancellationToken);
}