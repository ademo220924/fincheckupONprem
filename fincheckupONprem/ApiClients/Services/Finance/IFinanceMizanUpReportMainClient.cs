using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpReportMain;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanUpReportMainController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanUpReportMainController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanUpReportMainClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUpReportMain/OnGet")]
    Task<GenericResult<MizanUpReportMainOnGetResponse>> GetAsync([Body] MizanUpReportMainOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUpReportMain/OnGetSalerDate")]
    Task<GenericResult<MizanUpReportMainOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUpReportMainOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUpReportMain/OnGetSalerYear")]
    Task<GenericResult<MizanUpReportMainOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUpReportMainOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUpReportMain/OnGetSalerComp")]
    Task<GenericResult<MizanUpReportMainOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUpReportMainOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
}
