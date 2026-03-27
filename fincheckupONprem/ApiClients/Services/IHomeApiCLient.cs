using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Home;
using fincheckup.ApiClients.Models.Responses.Home;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services;

public interface IHomeApiCLient: IApiClientBase
 {
        [Post("/api/Main/MoodUpdate")]
        Task<GenericResult<MoodUpdateResponse>> MoodUpdateAsync(
            [Body] MoodUpdateRequest request,
            CancellationToken cancellationToken);

        [Post("/api/Main/MoodUpload")]
        Task<GenericResult<MoodUploadResponse>> MoodUploadAsync(
            [Body] MoodUploadRequest request,
            CancellationToken cancellationToken);

        [Post("/api/Main/MoodUploadNwMizan")]
        Task<GenericResult<MoodUploadNwMizanResponse>> MoodUploadNwMizanAsync(
            [Body] MoodUploadNwMizanRequest request,
            CancellationToken cancellationToken);

        [Post("/api/Main/MoodUploadNwUpdateMizan")]
        Task<GenericResult<MoodUploadNwUpdateMizanResponse>> MoodUploadNwUpdateMizanAsync(
            [Body] MoodUploadNwUpdateMizanRequest request,
            CancellationToken cancellationToken);

        [Post("/api/Main/MoodUploadOneProcess")]
        Task<GenericResult<MoodUploadOneProcessResponse>> MoodUploadOneProcessAsync(
            [Body] MoodUploadOneProcessRequest request,
            CancellationToken cancellationToken);

        [Post("/api/Main/MoodUploadOne")]
        Task<GenericResult<MoodUploadOneResponse>> MoodUploadOneAsync(
            [Body] MoodUploadOneRequest request,
            CancellationToken cancellationToken);

        [Post("/api/Main/MoodUploadOneUpdate")]
        Task<GenericResult<MoodUploadOneUpdateResponse>> MoodUploadOneUpdateAsync(
            [Body] MoodUploadOneUpdateRequest request,
            CancellationToken cancellationToken);

        [Post("/api/Main/MoodUploadOneGoOn")]
        Task<GenericResult<MoodUploadOneGoOnResponse>> MoodUploadOneGoOnAsync(
            [Body] MoodUploadOneGoOnRequest request,
            CancellationToken cancellationToken);

        [Post("/api/Main/MoodUploadUpdate")]
        Task<GenericResult<MoodUploadUpdateResponse>> MoodUploadUpdateAsync(
            [Body] MoodUploadUpdateRequest request,
            CancellationToken cancellationToken);

        [Post("/api/Main/MoodUpdateTax")]
        Task<GenericResult<MoodUpdateTaxResponse>> MoodUpdateTaxAsync(
            [Body] MoodUpdateTaxRequest request,
            CancellationToken cancellationToken);

        [Post("/api/Main/MoodUpdateReport")]
        Task<GenericResult<MoodUpdateReportResponse>> MoodUpdateReportAsync(
            [Body] MoodUpdateReportRequest request,
            CancellationToken cancellationToken);

        [Post("/api/Main/MoodUpdateBalance")]
        Task<GenericResult<MoodUpdateBalanceResponse>> MoodUpdateBalanceAsync(
            [Body] MoodUpdateBalanceRequest request,
            CancellationToken cancellationToken);

        [Post("/api/Main/MoodUpdateKonsol")]
        Task<GenericResult<MoodUpdateKonsolResponse>> MoodUpdateKonsolAsync(
            [Body] MoodUpdateKonsolRequest request,
            CancellationToken cancellationToken);

        [Post("/api/Main/MoodUpdateKonsolMizan")]
        Task<GenericResult<MoodUpdateKonsolMizanResponse>> MoodUpdateKonsolMizanAsync(
            [Body] MoodUpdateKonsolMizanRequest request,
            CancellationToken cancellationToken);

        [Post("/api/Main/MoodUpdateAccountCheck")]
        Task<GenericResult<MoodUpdateAccountCheckResponse>> MoodUpdateAccountCheckAsync(
            [Body] MoodUpdateAccountCheckRequest request,
            CancellationToken cancellationToken);

        [Post("/api/Main/MoodUpdateReportmain")]
        Task<GenericResult<MoodUpdateReportmainResponse>> MoodUpdateReportmainAsync(
            [Body] MoodUpdateReportmainRequest request,
            CancellationToken cancellationToken);

        [Post("/api/Main/MoodUpdateReportmainQnb")]
        Task<GenericResult<MoodUpdateReportmainQnbResponse>> MoodUpdateReportmainQnbAsync(
            [Body] MoodUpdateReportmainQnbRequest request,
            CancellationToken cancellationToken);

        [Post("/api/Main/GetHtml")]
        Task<GenericResult<GetHtmlResponse>> GetHtmlAsync(
            [Body] GetHtmlRequest request,
            CancellationToken cancellationToken);
    }