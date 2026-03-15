using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.upaccount;
using fincheckup.ApiClients.Models.Responses.upaccount;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IUpAccountApiClient : IApiClientBase
{
    [Post("/api/upaccount")]
    Task<GenericResult<upaccountOnGetResponse>> GetAsync(
        [Body] UpaccountOnGetRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upaccount/saler-main-chk")]
    Task<GenericResult<upaccountOnGetSalerMainChkResponse>> GetSalerMainChkAsync(
        [Body] upaccountOnGetSalerMainChkRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upaccount/saler-main-zeta")]
    Task<GenericResult<upaccountOnGetSalerMainZetaResponse>> GetSalerMainZetaAsync(
        [Body] upaccountOnGetSalerMainZetaRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upaccount/saler-date")]
    Task<GenericResult<upaccountOnGetSalerDateResponse>> GetSalerDateAsync(
        [Body] upaccountOnGetSalerDateRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upaccount/saler-year")]
    Task<GenericResult<upaccountOnGetSalerYearResponse>> GetSalerYearAsync(
        [Body] upaccountOnGetSalerYearRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upaccount/saler-comp")]
    Task<GenericResult<upaccountOnGetSalerCompResponse>> GetSalerCompAsync(
        [Body] upaccountOnGetSalerCompRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upaccount/graph-comp")]
    Task<GenericResult<upaccountOnGetGraphCompResponse>> GetGraphCompAsync(
        [Body] upaccountOnGetGraphCompRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upaccount/graph-year")]
    Task<GenericResult<upaccountOnGetGraphYearResponse>> GetGraphYearAsync(
        [Body] upaccountOnGetGraphYearRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upaccount/check-rep-pdf")]
    Task<GenericResult<upaccountOnGetCheckRepPdfResponse>> GetCheckRepPdfAsync(
        [Body] upaccountOnGetCheckRepPdfRequest request,
        CancellationToken cancellationToken);

    [Post("/api/upaccount/check-rep-xls")]
    Task<GenericResult<upaccountOnGetCheckRepXlsResponse>> GetCheckRepXlsAsync(
        [Body] upaccountOnGetCheckRepXlsRequest request,
        CancellationToken cancellationToken);
}