using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalanceNew;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanUpBalanceNewController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanUpBalanceNewController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanUpBalanceNewClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUpBalanceNew/OnGet")]
    Task<GenericResult<MizanUpBalanceNewOnGetResponse>> GetAsync([Body] MizanUpBalanceNewOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUpBalanceNew/OnGetSalerDate")]
    Task<GenericResult<MizanUpBalanceNewOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUpBalanceNewOnGetSalerDateQuery request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUpBalanceNew/OnGetSalerYear")]
    Task<GenericResult<MizanUpBalanceNewOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUpBalanceNewOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUpBalanceNew/OnGetSalerComp")]
    Task<GenericResult<MizanUpBalanceNewOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUpBalanceNewOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUpBalanceNew/OnGetCheckRepPdf")]
    Task<GenericResult<MizanUpBalanceNewOnGetCheckRepPdfResponse>> GetCheckRepPdfAsync([Body] MizanUpBalanceNewOnGetCheckRepPdfRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUpBalanceNew/OnGetCheckRepXls")]
    Task<GenericResult<MizanUpBalanceNewOnGetCheckRepXlsResponse>> GetCheckRepXlsAsync([Body] MizanUpBalanceNewOnGetCheckRepXlsRequest request, CancellationToken cancellationToken = default);
}
