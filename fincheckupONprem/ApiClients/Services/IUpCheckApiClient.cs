using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.upcheck;
using fincheckup.ApiClients.Models.Responses.upcheck;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IUpCheckApiClient : IApiClientBase
{
    [Post("/api/upcheck")]
    Task<GenericResult<upcheckOnGetResponse>> GetAsync(
        [Body] upcheckOnGetRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upcheck/saler-date")]
    Task<GenericResult<upcheckOnGetSalerDateResponse>> GetSalerDateAsync(
        [Body] upcheckOnGetSalerDateRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upcheck/check-rep-pdf")]
    Task<GenericResult<upcheckOnGetCheckRepPdfResponse>> GetCheckRepPdfAsync(
        [Body] upcheckOnGetCheckRepPdfRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upcheck/check-rep-xls")]
    Task<GenericResult<upcheckOnGetCheckRepXlsResponse>> GetCheckRepXlsAsync(
        [Body] upcheckOnGetCheckRepXlsRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upcheck/saler-year")]
    Task<GenericResult<upcheckOnGetSalerYearResponse>> GetSalerYearAsync(
        [Body] upcheckOnGetSalerYearRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upcheck/saler-comp")]
    Task<GenericResult<upcheckOnGetSalerCompResponse>> GetSalerCompAsync(
        [Body] upcheckOnGetSalerCompRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upcheck/graph-comp")]
    Task<GenericResult<upcheckOnGetGraphCompResponse>> GetGraphCompAsync(
        [Body] upcheckOnGetGraphCompRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upcheck/graph-year")]
    Task<GenericResult<upcheckOnGetGraphYearResponse>> GetGraphYearAsync(
        [Body] upcheckOnGetGraphYearRequest request,
        CancellationToken cancellationToken);
}