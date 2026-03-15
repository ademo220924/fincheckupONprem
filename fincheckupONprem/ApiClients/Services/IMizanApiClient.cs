using Microsoft.AspNetCore.Http;
using Refit;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Mizan;
using fincheckup.ApiClients.Models.Responses.Mizan;

namespace fincheckup.ApiClients.Services;

public interface IMizanApiClient
{
    /*
    [Post("/api/mizan/upload-multiple-test")]
    [Multipart]
    Task<GenericResult<HttpResponseMessage>> TestMultipleUploadFile(
        [AliasAs("files")] IEnumerable<IFormFile> files,
        CancellationToken cancellationToken);

    [Post("/api/mizan/moodUploadMznCkeckPDFUpdate")]
    [Multipart]
    Task<GenericResult<HttpResponseMessage>> MoodUploadMznCkeckFileUpdateAsync(
        [AliasAs("files")] IEnumerable<IFormFile> files,
        [AliasAs("id")] int id,
        [AliasAs("ide")] string ide,
        [AliasAs("ideXml")] string ideXml,
        [AliasAs("caption")] string caption,
        CancellationToken cancellationToken);

    [Post("/api/mizan/moodUploadMznCkeckPDF-Create")]
    [Multipart]
    Task<GenericResult<HttpResponseMessage>> MoodUploadMznCkeckFileCreateAsync(
        [AliasAs("files")] IEnumerable<IFormFile> files,
        [AliasAs("id")] int id,
        [AliasAs("ide")] string ide,
        [AliasAs("ideXml")] string ideXml,
        [AliasAs("caption")] string caption,
        CancellationToken cancellationToken);

    [Post("/api/mizan/moodUploadMznCkeck")]
    [Multipart]
    Task<GenericResult<HttpResponseMessage>> MoodUploadMznCkeckAsync(
        [AliasAs("files")] IEnumerable<IFormFile> files,
        [AliasAs("id")] int id,
        [AliasAs("ide")] string ide,
        [AliasAs("ideXml")] string ideXml,
        [AliasAs("caption")] string caption,
        CancellationToken cancellationToken);

    [Post("/api/mizan/moodUploadMzn")]
    [Multipart]
    Task<GenericResult<HttpResponseMessage>> MoodUploadMznAsync(
        [AliasAs("files")] IEnumerable<IFormFile> files,
        [AliasAs("id")] int id,
        [AliasAs("ide")] string ide,
        [AliasAs("ideXml")] string ideXml,
        [AliasAs("caption")] string caption,
        CancellationToken cancellationToken);

    [Post("/api/mizan/moodUploadUpdateMzn")]
    [Multipart]
    Task<GenericResult<HttpResponseMessage>> MoodUploadUpdateMznAsync(
        [AliasAs("files")] IEnumerable<IFormFile> files,
        [AliasAs("id")] int id,
        [AliasAs("ide")] string ide,
        [AliasAs("ideXml")] string ideXml,
        [AliasAs("caption")] string caption,
        CancellationToken cancellationToken);
    */
    
    
    
    [Post("/api/Mizan/MoodUploadMznCkeckFileUpdate")]
    Task<GenericResult<MoodUploadMznCkeckFileUpdateResponse>> MoodUploadMznCkeckFileUpdateAsync(
        [Body] MoodUploadMznCkeckFileUpdateRequest request,
        CancellationToken cancellationToken);


    [Post("/api/Mizan/MoodUploadMznCkeckFileCreate")]
    Task<GenericResult<MoodUploadMznCkeckFileCreateResponse>> MoodUploadMznCkeckFileCreateAsync(
        [Body] MoodUploadMznCkeckFileCreateRequest request,
        CancellationToken cancellationToken);


    [Post("/api/Mizan/MoodUploadMznCkeck")]
    Task<GenericResult<MoodUploadMznCkeckResponse>> MoodUploadMznCkeckAsync(
        [Body] MoodUploadMznCkeckRequest request,
        CancellationToken cancellationToken);


    [Post("/api/Mizan/MoodUploadMzn")]
    Task<GenericResult<MoodUploadMznResponse>> MoodUploadMznAsync(
        [Body] MoodUploadMznRequest request,
        CancellationToken cancellationToken);


    [Post("/api/Mizan/MoodUploadUpdateMzn")]
    Task<GenericResult<MoodUploadUpdateMznResponse>> MoodUploadUpdateMznAsync(
        [Body] MoodUploadUpdateMznRequest request,
        CancellationToken cancellationToken);


    [Post("/api/Mizan/MoodUpdateSmm")]
    Task<GenericResult<MoodUpdateSmmResponse>> MoodUpdateSmmAsync(
        [Body] MoodUpdateSmmRequest request,
        CancellationToken cancellationToken);


    [Post("/api/Mizan/MoodUpdateSaktarma")]
    Task<GenericResult<MoodUpdatesAktarmaResponse>> MoodUpdatesAktarmaAsync(
        [Body] MoodUpdatesAktarmaRequest request,
        CancellationToken cancellationToken);


    [Post("/api/Mizan/MoodUpdateSaktarmaMzn")]
    Task<GenericResult<MoodUpdatesAktarmaMznResponse>> MoodUpdatesAktarmaMznAsync(
        [Body] MoodUpdatesAktarmaMznRequest request,
        CancellationToken cancellationToken);


    [Post("/api/Mizan/MoodUpdateSaktarmaSelected")]
    Task<GenericResult<MoodUpdatesAktarmaSelectedResponse>> MoodUpdatesAktarmaSelectedAsync(
        [Body] MoodUpdateSaktarmaSelectedRequest request,
        CancellationToken cancellationToken);


    [Post("/api/Mizan/MoodUpdateSaktarmaSelectedByN")]
    Task<GenericResult<MoodUpdatesAktarmaSelectedByNResponse>> MoodUpdatesAktarmaSelectedByNAsync(
        [Body] MoodUpdatesAktarmaSelectedByNRequest request,
        CancellationToken cancellationToken);

    
    
    
    [Post("/api/Mizan/MoodUploadMznCkeckPDFUpdate")]
    Task<GenericResult<MoodUploadMznCkeckPDFUpdateResponse>> MoodUploadMznCkeckPDFUpdateAsync(
        [Body] MoodUploadMznCkeckPDFUpdateRequest request,
        CancellationToken cancellationToken);


    [Post("/api/Mizan/MoodUpdateBalance")]
    Task<GenericResult<MoodUpdateBalanceResponse>> MoodUpdateBalanceAsync(
        [Body] MoodUpdateBalanceRequest request,
        CancellationToken cancellationToken);


    [Post("/api/Mizan/MoodUpdateSaktarmaSelectedMzn")]
    Task<GenericResult<MoodUpdatesaAtarmaSelectedMznResponse>> MoodUpdatesaktarmaselectedmznAsync(
        [Body] MoodUpdatesAktarmaSelectedMznRequest request,
        CancellationToken cancellationToken);
    
    
}
