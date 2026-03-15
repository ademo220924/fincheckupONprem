using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.upbalance;
using fincheckup.ApiClients.Models.Responses.upbalance;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IUpBalanceApiClient : IApiClientBase
{
    [Post("/api/upbalance")]
    Task<GenericResult<upbalanceOnGetResponse>> GetAsync(
        [Body] UpbalanceOnGetRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upbalance/check-rep-pdf")]
    Task<GenericResult<upbalanceOnGetResponse>> GetCheckRepPdfAsync(
        [Body] upbalanceOnGetCheckRepPdfRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upbalance/check-rep-xls")]
    Task<GenericResult<upbalanceOnGetResponse>> GetCheckRepXlsAsync(
        [Body] upbalanceOnGetCheckRepXlsRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upbalance/graph-comp")]
    Task<GenericResult<upbalanceOnGetResponse>> GetGraphCompAsync(
        [Body] upbalanceOnGetGraphCompRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upbalance/graph-year")]
    Task<GenericResult<upbalanceOnGetResponse>> GetGraphYearAsync(
        [Body] upbalanceOnGetGraphYearRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upbalance/saler-comp")]
    Task<GenericResult<upbalanceOnGetResponse>> GetSalerCompAsync(
        [Body] upbalanceOnGetSalerCompRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upbalance/saler-date")]
    Task<GenericResult<upbalanceOnGetResponse>> GetSalerDateAsync(
        [Body] upbalanceOnGetSalerDateRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upbalance/saler-year")]
    Task<GenericResult<upbalanceOnGetResponse>> GetSalerYearAsync(
        [Body] upbalanceOnGetSalerYearRequest request,
        CancellationToken cancellationToken);
}