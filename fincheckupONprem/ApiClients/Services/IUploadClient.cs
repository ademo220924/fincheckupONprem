using fincheckup.ApiClients.Models.Requests.Upload;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for UploadController. Source: src/FinanceCheckUp.Api/Controllers/v1/UploadController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IUploadClient : IApiClientBase
{
    [Post("/api/Upload")]
    Task<GenericResult<UploadOnGetResponse>> GetAsync([Body] UploadOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/Upload/saler-main-chk")]
    Task<GenericResult<UploadOnGetSalerMainChkResponse>> GetSalerMainChkAsync([Body] UploadOnGetSalerMainChkRequest request, CancellationToken cancellationToken = default);
    [Post("/api/Upload/saler-main-zeta")]
    Task<GenericResult<UploadOnGetSalerMainZetaResponse>> GetSalerMainZetaAsync([Body] UploadOnGetSalerMainZetaRequest request, CancellationToken cancellationToken = default);
    [Post("/api/Upload/saler-date")]
    Task<GenericResult<UploadOnGetSalerDateResponse>> GetSalerDateAsync([Body] UploadOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/Upload/saler-main-note")]
    Task<GenericResult<UploadOnGetSalerMainNoteResponse>> GetSalerMainNoteAsync([Body] UploadOnGetSalerMainNoteRequest request, CancellationToken cancellationToken = default);
    [Post("/api/Upload/saler-year")]
    Task<GenericResult<UploadOnGetSalerYearResponse>> GetSalerYearAsync([Body] UploadOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/Upload/graph-comp")]
    Task<GenericResult<UploadOnGetGraphCompResponse>> GetGraphCompAsync([Body] UploadOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/Upload/graph-year")]
    Task<GenericResult<UploadOnGetGraphYearResponse>> GetGraphYearAsync([Body] UploadOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
}
