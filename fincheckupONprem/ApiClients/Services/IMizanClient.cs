using fincheckup.ApiClients.Models.Requests.Mizan;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for MizanController. Source: src/FinanceCheckUp.Api/Controllers/v1/MizanController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IMizanClient : IApiClientBase
{
    // TODO: multipart — TestMultipleUploadFile: StreamPart/MultipartBody; see controller.
    // TODO: multipart — MoodUploadMznCkeckFileUpdateAsync: StreamPart/MultipartBody; see controller.
    // TODO: multipart — MoodUploadMznCkeckFileCreateAsync: StreamPart/MultipartBody; see controller.
    // TODO: multipart — MoodUploadMznCkeckAsync: StreamPart/MultipartBody; see controller.
    // TODO: multipart — MoodUploadMznAsync: StreamPart/MultipartBody; see controller.
    // TODO: multipart — MoodUploadUpdateMznAsync: StreamPart/MultipartBody; see controller.
    [Post("/api/mizan/moodUpdateBalance")]
    Task<GenericResult<MoodUpdateBalanceResponse>> MoodUploadMznAsync([Body] MoodUpdateBalanceRequest request, CancellationToken cancellationToken = default);
    [Post("/api/mizan/moodUpdatesaktarma")]
    Task<GenericResult<MoodUpdatesAktarmaResponse>> MoodUpdatesAktarmaAsync([Body] MoodUpdatesAktarmaRequest request, CancellationToken cancellationToken = default);
    [Post("/api/mizan/moodUpdatesaktarmamzn")]
    Task<GenericResult<MoodUpdatesAktarmaMznResponse>> MoodUpdatesAktarmaMznAsync([Body] MoodUpdatesAktarmaMznRequest request, CancellationToken cancellationToken = default);
    [Post("/api/mizan/moodUpdatesaktarmaselected")]
    Task<GenericResult<MoodUpdatesAktarmaSelectedResponse>> MoodUpdatesAktarmaSelectedAsync([Body] MoodUpdateSaktarmaSelectedRequest request, CancellationToken cancellationToken = default);
    [Post("/api/mizan/moodUpdatesaktarmaselectedbyn")]
    Task<GenericResult<MoodUpdatesAktarmaSelectedByNResponse>> MoodUpdatesAktarmaSelectedBynAsync([Body] MoodUpdatesAktarmaSelectedByNRequest request, CancellationToken cancellationToken = default);
    [Post("/api/mizan/moodUpdatesaktarmaselectedmzn")]
    Task<GenericResult<MoodUpdatesAktarmaSelectedMznResponse>> MoodUpdatesAktarmaSelectedMznAsync([Body] MoodUpdatesAktarmaSelectedMznRequest request, CancellationToken cancellationToken = default);
    [Post("/api/mizan/moodUpdatesmm")]
    Task<GenericResult<MoodUpdateSmmResponse>> MoodUpdateSmmAsync([Body] MoodUpdateSmmRequest request, CancellationToken cancellationToken = default);
}
