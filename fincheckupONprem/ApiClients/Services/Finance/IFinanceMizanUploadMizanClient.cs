using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMizan;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanUploadMizanController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanUploadMizanController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanUploadMizanClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUploadMizan/OnGet")]
    Task<GenericResult<MizanUploadMizanOnGetResponse>> GetAsync([Body] MizanUploadMizanOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMizan/OnGetSalerMainChk")]
    Task<GenericResult<MizanUploadMizanOnGetSalerMainChkResponse>> GetSalerMainChkAsync([Body] MizanUploadMizanOnGetSalerMainChkRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMizan/OnGetSalerMainZeta")]
    Task<GenericResult<MizanUploadMizanOnGetSalerMainZetaResponse>> GetSalerMainZetaAsync([Body] MizanUploadMizanOnGetSalerMainZetaRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMizan/OnGetSalerDate")]
    Task<GenericResult<MizanUploadMizanOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUploadMizanOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMizan/OnGetSalerYear")]
    Task<GenericResult<MizanUploadMizanOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUploadMizanOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMizan/OnGetSalerComp")]
    Task<GenericResult<MizanUploadMizanOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUploadMizanOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMizan/OnGetGraphYearDel")]
    Task<GenericResult<MizanUploadMizanOnGetGraphYearDelResponse>> GetGraphYearDelAsync([Body] MizanUploadMizanOnGetGraphYearDelRequest request, CancellationToken cancellationToken = default);
}
