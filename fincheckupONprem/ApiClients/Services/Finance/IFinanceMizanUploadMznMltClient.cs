using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMznMlt;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanUploadMznMltController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanUploadMznMltController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanUploadMznMltClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUploadMznMlt/OnGet")]
    Task<GenericResult<MizanUploadMznMltOnGetResponse>> GetAsync([Body] MizanUploadMznMltOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMznMlt/OnGetSalerDate")]
    Task<GenericResult<MizanUploadMznMltOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUploadMznMltOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMznMlt/OnGetSalerYear")]
    Task<GenericResult<MizanUploadMznMltOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUploadMznMltOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadMznMlt/OnGetSalerComp")]
    Task<GenericResult<MizanUploadMznMltOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUploadMznMltOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
}
