using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.upchecky;
using fincheckup.ApiClients.Models.Responses.upchecky;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IUpCheckyApiClient : IApiClientBase
{
    [Post("/api/upchecky")]
    Task<GenericResult<upcheckyOnGetResponse>> GetAsync(
        [Body] UpcheckyOnGetRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upchecky/saler-date")]
    Task<GenericResult<upcheckyOnGetSalerDateResponse>> GetSalerDateAsync(
        [Body] upcheckyOnGetSalerDateRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upchecky/saler-year")]
    Task<GenericResult<upcheckyOnGetSalerYearResponse>> GetSalerYearAsync(
        [Body] upcheckyOnGetSalerYearRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upchecky/saler-comp")]
    Task<GenericResult<upcheckyOnGetSalerCompResponse>> GetSalerCompAsync(
        [Body] upcheckyOnGetSalerCompRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upchecky/graph-comp")]
    Task<GenericResult<upcheckyOnGetGraphCompResponse>> GetGraphCompAsync(
        [Body] upcheckyOnGetGraphCompRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upchecky/graph-year")]
    Task<GenericResult<upcheckyOnGetGraphYearResponse>> GetGraphYearAsync(
        [Body] upcheckyOnGetGraphYearRequest request,
        CancellationToken cancellationToken);
}