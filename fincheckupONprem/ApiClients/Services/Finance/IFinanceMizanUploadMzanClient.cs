using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMzan;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanUploadMzanController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanUploadMzanController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanUploadMzanClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUploadMzan/OnGet")]
    Task<GenericResult<MizanUploadMzanOnGetResponse>> GetAsync([Body] MizanUploadMzanOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMzan/OnGetSalerMainChk")]
    Task<GenericResult<MizanUploadMzanOnGetSalerMainChkResponse>> GetSalerMainChkAsync([Body] MizanUploadMzanOnGetSalerMainChkRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMzan/OnGetSalerMainZeta")]
    Task<GenericResult<MizanUploadMzanOnGetSalerMainZetaResponse>> GetSalerMainZetaAsync([Body] MizanUploadMzanOnGetSalerMainZetaRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMzan/OnGetSalerDate")]
    Task<GenericResult<MizanUploadMzanOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUploadMzanOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMzan/OnGetSalerYear")]
    Task<GenericResult<MizanUploadMzanOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUploadMzanOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMzan/OnGetSalerComp")]
    Task<GenericResult<MizanUploadMzanOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUploadMzanOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
}
