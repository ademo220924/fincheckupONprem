using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Responses.Upload;
using fincheckup.ApiClients.Models.Requests.Upload;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IUploadApiClient : IApiClientBase
{
    [Post("/api/Upload")]
    Task<GenericResult<UploadOnGetResponse>> GetAsync(
        [Body] UploadOnGetRequest request,
        CancellationToken cancellationToken);

    [Post("/api/Upload/saler-main-chk")]
    Task<GenericResult<UploadOnGetSalerMainChkResponse>> GetSalerMainChkAsync(
        [Body] UploadOnGetSalerMainChkRequest request,
        CancellationToken cancellationToken);

    [Post("/api/Upload/saler-main-zeta")]
    Task<GenericResult<UploadOnGetSalerMainZetaResponse>> GetSalerMainZetaAsync(
        [Body] UploadOnGetSalerMainZetaRequest request,
        CancellationToken cancellationToken);

    [Post("/api/Upload/saler-date")]
    Task<GenericResult<UploadOnGetSalerDateResponse>> GetSalerDateAsync(
        [Body] UploadOnGetSalerDateRequest request,
        CancellationToken cancellationToken);

    [Post("/api/Upload/saler-main-note")]
    Task<GenericResult<UploadOnGetSalerMainNoteResponse>> GetSalerMainNoteAsync(
        [Body] UploadOnGetSalerMainNoteRequest request,
        CancellationToken cancellationToken);

    [Post("/api/Upload/saler-comp")]
    Task<GenericResult<UploadOnGetSalerCompResponse>> GetSalerCompAsync(
        [Body] UploadOnGetSalerCompRequest request,
        CancellationToken cancellationToken);
    
    [Post("/api/Upload/saler-year")]
    Task<GenericResult<UploadOnGetSalerYearResponse>> GetSalerYearAsync(
        [Body] UploadOnGetSalerYearRequest request,
        CancellationToken cancellationToken);

    [Post("/api/Upload/graph-comp")]
    Task<GenericResult<UploadOnGetGraphCompResponse>> GetGraphCompAsync(
        [Body] UploadOnGetGraphCompRequest request,
        CancellationToken cancellationToken);

    [Post("/api/Upload/graph-year")]
    Task<GenericResult<UploadOnGetGraphYearResponse>> GetGraphYearAsync(
        [Body] UploadOnGetGraphYearRequest request,
        CancellationToken cancellationToken);
}