using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMain;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanUploadMainController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanUploadMainController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanUploadMainClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUploadMain/OnGet")]
    Task<GenericResult<MizanUploadMainOnGetResponse>> GetAsync([Body] MizanUploadMainOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMain/OnGetSalerMainChk")]
    Task<GenericResult<MizanUploadMainOnGetSalerMainChkResponse>> GetSalerMainChkAsync([Body] MizanUploadMainOnGetSalerMainChkRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMain/OnGetSalerMainZeta")]
    Task<GenericResult<MizanUploadMainOnGetSalerMainZetaResponse>> GetSalerMainZetaAsync([Body] MizanUploadMainOnGetSalerMainZetaRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMain/OnGetSalerDate")]
    Task<GenericResult<MizanUploadMainOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUploadMainOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMain/OnGetSalerYear")]
    Task<GenericResult<MizanUploadMainOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUploadMainOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMain/OnGetSalerComp")]
    Task<GenericResult<MizanUploadMainOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUploadMainOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
}
