using Refit;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.File;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IFileApiClient : IApiClientBase
{
    [Get("/api/file/download-file")]
    Task<GenericResult<HttpResponseMessage>> DownloadImageFromUrlAsync([Query] DownloadImageFromUrlRequest request, CancellationToken cancellationToken);

    [Multipart]
    [Post("/api/file/upload-file")]
    Task<GenericResult<HttpResponseMessage>> UploadImageAsync([AliasAs("formFile")] StreamPart formFile, [Query] UploadImageRequest request, CancellationToken cancellationToken);

    [Multipart]
    [Post("/api/file/read-pdf-file")]
    Task<GenericResult<HttpResponseMessage>> ReadPdfFileAsync([AliasAs("formFile")] StreamPart formFile, CancellationToken cancellationToken);

    [Multipart]
    [Post("/api/file/read-pdf-file-mizan")]
    Task<GenericResult<HttpResponseMessage>> ReadPdfFileMizanAsync([AliasAs("formFile")] StreamPart formFile, [Query] ReadPdfFileMizanRequest request, CancellationToken cancellationToken);
}