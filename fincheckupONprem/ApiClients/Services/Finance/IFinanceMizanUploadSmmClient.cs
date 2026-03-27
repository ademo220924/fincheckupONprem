using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadSmm;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanUploadSmmController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanUploadSmmController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanUploadSmmClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUploadSmm/OnGet")]
    Task<GenericResult<MizanUploadSmmOnGetResponse>> GetAsync([Body] MizanUploadSmmOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadSmm/OnGetSalerDate")]
    Task<GenericResult<MizanUploadSmmOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUploadSmmOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadSmm/OnGetSalerYear")]
    Task<GenericResult<MizanUploadSmmOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUploadSmmOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUploadSmm/OnGetSalerComp")]
    Task<GenericResult<MizanUploadSmmOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUploadSmmOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
}
