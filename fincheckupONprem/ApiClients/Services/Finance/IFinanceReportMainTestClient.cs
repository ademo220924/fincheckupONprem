using fincheckup.ApiClients.Models.Requests.Finance.ReportMainTest;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceReportMainTestController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceReportMainTestController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceReportMainTestClient : IApiClientBase
{
    [Post("/api/finance/FinanceReportMainTest/OnGet")]
    Task<GenericResult<FinanceReportMainTestOnGetResponse>> GetAsync([Body] FinanceReportMainTestOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceReportMainTest/OnGetSalerDate")]
    Task<GenericResult<FinanceReportMainTestOnGetSalerDateResponse>> GetSalerDateAsync([Body] FinanceReportMainTestOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceReportMainTest/OnGetSalerYear")]
    Task<GenericResult<FinanceReportMainTestOnGetSalerYearResponse>> GetSalerYearAsync([Body] FinanceReportMainTestOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceReportMainTest/OnGetSalerComp")]
    Task<GenericResult<FinanceReportMainTestOnGetSalerCompResponse>> GetSalerCompAsync([Body] FinanceReportMainTestOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceReportMainTest/OnGetCheckRepPdf")]
    Task<GenericResult<FinanceReportMainTestOnGetCheckRepPdfResponse>> GetCheckRepPdfAsync([Body] FinanceReportMainTestOnGetCheckRepPdfRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceReportMainTest/OnGetCheckUrl")]
    Task<GenericResult<FinanceReportMainTestOnGetCheckUrlResponse>> GetCheckUrlAsync([Body] FinanceReportMainTestOnGetCheckUrlRequest request, CancellationToken cancellationToken = default);
}
