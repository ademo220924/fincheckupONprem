using fincheckup.ApiClients.Models.Requests;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for BeyannameController. Source: src/FinanceCheckUp.Api/Controllers/v1/BeyannameController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IBeyannameClient : IApiClientBase
{
    // TODO: multipart — MoodUploadCreateAsync: StreamPart/MultipartBody; see controller.
    // TODO: multipart — MoodUploadUpdateAsync: StreamPart/MultipartBody; see controller.
    // TODO: multipart — MoodUploadBeyannameCreateAsync: StreamPart/MultipartBody; see controller.
    // TODO: multipart — MoodUploadBeyannameUpdateAsync: StreamPart/MultipartBody; see controller.
    // TODO: multipart — MoodUploadBeyannameChkzAsync: StreamPart/MultipartBody; see controller.
}
