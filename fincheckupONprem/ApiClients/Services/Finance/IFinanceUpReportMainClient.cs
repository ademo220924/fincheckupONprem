using fincheckup.ApiClients.Models.Requests.Finance.UpReportMain;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceUpReportMainController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceUpReportMainController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceUpReportMainClient : IApiClientBase
{
    [Post("/api/finance/FinanceUpReportMain/OnGet")]
    Task<GenericResult<FinanceUpReportMainOnGetResponse>> GetAsync([Body] FinanceUpReportMainOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceUpReportMain/OnGetSalerDate")]
    Task<GenericResult<FinanceUpReportMainOnGetSalerDateResponse>> GetSalerDateAsync([Body] FinanceUpReportMainOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceUpReportMain/OnGetSalerYear")]
    Task<GenericResult<FinanceUpReportMainOnGetSalerYearResponse>> GetSalerYearAsync([Body] FinanceUpReportMainOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceUpReportMain/OnGetSalerComp")]
    Task<GenericResult<FinanceUpReportMainOnGetSalerCompResponse>> GetSalerCompAsync([Body] FinanceUpReportMainOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceUpReportMain/OnGetCheckRepPdf")]
    Task<GenericResult<FinanceUpReportMainOnGetCheckRepPdfResponse>> GetCheckRepPdfAsync([Body] FinanceUpReportMainOnGetCheckRepPdfRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceUpReportMain/OnGetCheckRepXls")]
    Task<GenericResult<FinanceUpReportMainOnGetCheckRepXlsResponse>> GetCheckRepXlsAsync([Body] FinanceUpReportMainOnGetCheckRepXlsRequest request, CancellationToken cancellationToken = default);
}
