using System.Threading.Tasks;
using System.Threading;
using Refit;
using System.IO;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Responses.Beyanname;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IBeyannameApiClient: IApiClientBase
{

    [Post("/mood-upload-create/{idValue}/{ideValue}/{idexmlValue}/{captionValue}")]
    Task<GenericResult<MoodUploadCreateResponse>> MoodUploadCreateAsync(
        [Body] Stream formFileValue,
        [AliasAs("idValue")] int idValue,
        [AliasAs("ideValue")] string ideValue,
        [AliasAs("idexmlValue")] string idexmlValue,
        [AliasAs("captionValue")] string captionValue,
        [Header("user-id")] string userId,
        CancellationToken cancellationToken = default);

    [Put("/mood-upload-update/{idValue}/{ideValue}/{idexmlValue}/{captionValue}")]
    Task<GenericResult<MoodUploadUpdateResponse>> MoodUploadUpdateAsync(
        [Body] Stream formFileValue,
        [AliasAs("idValue")] int idValue,
        [AliasAs("ideValue")] string ideValue,
        [AliasAs("idexmlValue")] string idexmlValue,
        [AliasAs("captionValue")] string captionValue,
        [Header("user-id")] string userId,
        CancellationToken cancellationToken = default);


    [Post("/mood-upload-beyanname-create/{idValue}/{ideValue}/{idexmlValue}/{captionValue}")]
    Task<GenericResult<BeyannameMoodUploadCreateResponse>> MoodUploadBeyannameCreateAsync(
        [Body] Stream formFileValue,
        [AliasAs("idValue")] int idValue,
        [AliasAs("ideValue")] string ideValue,
        [AliasAs("idexmlValue")] string idexmlValue,
        [AliasAs("captionValue")] string captionValue,
        [Header("user-id")] string userId,
        CancellationToken cancellationToken = default);

    [Put("/mood-upload-beyanname-update/{idValue}/{ideValue}/{idexmlValue}/{captionValue}")]
    Task<GenericResult<BeyannameMoodUploadUpdateResponse>> MoodUploadBeyannameUpdateAsync(
        [Body] Stream formFileValue,
        [AliasAs("idValue")] int idValue,
        [AliasAs("ideValue")] string ideValue,
        [AliasAs("idexmlValue")] string idexmlValue,
        [AliasAs("captionValue")] string captionValue,
        [Header("user-id")] string userId,
        CancellationToken cancellationToken = default);

    [Post("/api/beyanname/mood-upload-beyanname-chkz")]
    Task<GenericResult<BeyannameMoodUploadCheckResponse>> MoodUploadBeyannameChkzAsync(
        [Body] Stream formFileValue,
        [AliasAs("idValue")] int idValue,
        [AliasAs("ideValue")] string ideValue,
        [AliasAs("idexmlValue")] string idexmlValue,
        [AliasAs("captionValue")] string captionValue,
        [Header("user-id")] string userId,
        [Query] CancellationToken cancellationToken = default);
}
