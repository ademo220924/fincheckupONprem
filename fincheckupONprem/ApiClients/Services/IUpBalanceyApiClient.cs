using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.upbalancey;
using fincheckup.ApiClients.Models.Responses.upbalancey;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IUpBalanceyApiClient : IApiClientBase
{
    [Post("/api/upbalancey")]
    Task<GenericResult<upbalanceyOnGetResponse>> GetAsync(
        [Body] UpbalanceyOnGetRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upbalancey/saler-date")]
    Task<GenericResult<upbalanceyOnGetSalerDateResponse>> GetSalerDateAsync(
        [Body] upbalanceyOnGetSalerDateRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upbalancey/saler-year")]
    Task<GenericResult<upbalanceyOnGetSalerYearResponse>> GetSalerYearAsync(
        [Body] upbalanceyOnGetSalerYearRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upbalancey/saler-comp")]
    Task<GenericResult<upbalanceyOnGetSalerCompResponse>> GetSalerCompAsync(
        [Body] upbalanceyOnGetSalerCompRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upbalancey/graph-comp")]
    Task<GenericResult<upbalanceyOnGetGraphCompResponse>> GetGraphCompAsync(
        [Body] upbalanceyOnGetGraphCompRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upbalancey/graph-year")]
    Task<GenericResult<upbalanceyOnGetGraphYearResponse>> GetGraphYearAsync(
        [Body] upbalanceyOnGetGraphYearRequest request,
        CancellationToken cancellationToken);
}