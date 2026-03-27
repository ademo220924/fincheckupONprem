using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMzn;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanUploadMznController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanUploadMznController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanUploadMznClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUploadMzn/OnGet")]
    Task<GenericResult<MizanUploadMznOnGetResponse>> GetAsync([Body] MizanUploadMznOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMzn/OnGetSalerMainChk")]
    Task<GenericResult<MizanUploadMznOnGetSalerMainChkResponse>> GetSalerMainChkAsync([Body] MizanUploadMznOnGetSalerMainChkRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMzn/OnGetSalerMainZeta")]
    Task<GenericResult<MizanUploadMznOnGetSalerMainZetaResponse>> GetSalerMainZetaAsync([Body] MizanUploadMznOnGetSalerMainZetaRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMzn/OnGetSalerDate")]
    Task<GenericResult<MizanUploadMznOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUploadMznOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMzn/OnGetSalerYear")]
    Task<GenericResult<MizanUploadMznOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUploadMznOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMzn/OnGetSalerComp")]
    Task<GenericResult<MizanUploadMznOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUploadMznOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
}
