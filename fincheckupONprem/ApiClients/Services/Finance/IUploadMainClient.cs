using fincheckup.ApiClients.Models.Requests.Finance.Upload;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for UploadMainController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceUploadController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IUploadMainClient : IApiClientBase
{
    [Post("/api/finance/UploadMain/OnGet")]
    Task<GenericResult<FinanceUploadMainOnGetResponse>> GetAsync([Body] FinanceUploadMainOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/UploadMain/OnGetSalerMainChk")]
    Task<GenericResult<FinanceUploadMainOnGetSalerMainChkResponse>> GetSalerMainChkAsync([Body] FinanceUploadMainOnGetSalerMainChkRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/UploadMain/OnGetSalerMainZeta")]
    Task<GenericResult<FinanceUploadMainOnGetSalerMainZetaResponse>> GetSalerMainZetaAsync([Body] FinanceUploadMainOnGetSalerMainZetaRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/UploadMain/OnGetSalerDate")]
    Task<GenericResult<FinanceUploadMainOnGetSalerDateResponse>> GetSalerDateAsync([Body] FinanceUploadMainOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/UploadMain/OnGetSalerMainNote")]
    Task<GenericResult<FinanceUploadMainOnGetSalerMainNoteResponse>> GetSalerMainNoteAsync([Body] FinanceUploadMainOnGetSalerMainNoteRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/UploadMain/OnGetresult")]
    Task<GenericResult<FinanceUploadMainOnGetresultResponse>> GetresultAsync([Body] FinanceUploadMainOnGetresultRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/UploadMain/OnGetSalerYear")]
    Task<GenericResult<FinanceUploadMainOnGetSalerYearResponse>> GetSalerYearAsync([Body] FinanceUploadMainOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/UploadMain/OnGetSalerComp")]
    Task<GenericResult<FinanceUploadMainOnGetSalerCompResponse>> GetSalerCompAsync([Body] FinanceUploadMainOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
}
