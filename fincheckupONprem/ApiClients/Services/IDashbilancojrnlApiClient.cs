using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Models.Responses.dashbilancojrnl;
using fincheckup.ApiClients.Models.Requests.dashbilancojrnl;
using fincheckup.ApiClients.Models.Responses.dashbilancojrnl;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IDashbilancojrnlApiClient : IApiClientBase
{
    [Post("/api/dashbilancojrnl")]
    Task<GenericResult<dashbilancojrnlOnGetResponse>> GetAsync(
        [Body] dashbilancojrnlOnGetRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancojrnl/saler-main")]
    Task<GenericResult<dashbilancojrnlOnGetSalerMainResponse>> GetSalerMainAsync(
        [Body] dashbilancojrnlOnGetSalerMainRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancojrnl/prio")]
    Task<GenericResult<dashbilancojrnlOnGetPrioResponse>> GetPrioAsync(
        [Body] dashbilancojrnlOnGetPrioRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancojrnl/graph-year")]
    Task<GenericResult<dashbilancojrnlOnGetGraphYearResponse>> GetGraphYearAsync(
        [Body] dashbilancojrnlGetGraphYearRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancojrnl/graph-comp")]
    Task<GenericResult<dashbilancojrnlOnGetGraphCompResponse>> GetGraphCompAsync(
        [Body] dashbilancojrnlOnGetGraphCompRequest request,
        CancellationToken cancellationToken);

    [Post("/api/dashbilancojrnl/markup-marjin")]
    Task<GenericResult<dashbilancojrnlOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync(
        [Body] dashbilancojrnlOnGetMarkupMarjinRequest request,
        CancellationToken cancellationToken);
}