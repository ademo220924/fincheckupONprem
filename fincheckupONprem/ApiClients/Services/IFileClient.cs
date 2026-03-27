using fincheckup.ApiClients.Models.Requests;
using fincheckup.ApiClients.Models.Requests.File;
using fincheckup.ApiClients.Models.Responses.FileOperation;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for FileController. Source: src/FinanceCheckUp.Api/Controllers/v1/FileController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFileClient : IApiClientBase
{
    [Get("/api/file/download-file")]
    Task<GenericResult<FileDownloadFromUrlResponse>> DownloadImageFromUrlAsync([Query] DownloadImageFromUrlRequest request, CancellationToken cancellationToken = default);
    // TODO: multipart — UploadImageAsync: StreamPart/MultipartBody; see controller.
    // TODO: multipart — ReadPdfFileAsync: StreamPart/MultipartBody; see controller.
    // TODO: multipart — ReadPdfFileMizanAsync: StreamPart/MultipartBody; see controller.
}
