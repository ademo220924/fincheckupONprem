using fincheckup.ApiClients.Models.Requests.Finance.ReportMainTestOld;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceReportMainTestOldController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceReportMainTestOldController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceReportMainTestOldClient : IApiClientBase
{
    [Post("/api/finance/FinanceReportMainTestOld/OnGet")]
    Task<GenericResult<FinanceReportMainTestOldOnGetResponse>> GetAsync([Body] FinanceReportMainTestOldOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceReportMainTestOld/OnGetSalerDate")]
    Task<GenericResult<FinanceReportMainTestOldOnGetSalerDateResponse>> GetSalerDateAsync([Body] FinanceReportMainTestOldOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceReportMainTestOld/OnGetSalerYear")]
    Task<GenericResult<FinanceReportMainTestOldOnGetSalerYearResponse>> GetSalerYearAsync([Body] FinanceReportMainTestOldOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceReportMainTestOld/OnGetSalerComp")]
    Task<GenericResult<FinanceReportMainTestOldOnGetSalerCompResponse>> GetSalerCompAsync([Body] FinanceReportMainTestOldOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceReportMainTestOld/OnGetCheckRepPdf")]
    Task<GenericResult<FinanceReportMainTestOldOnGetCheckRepPdfResponse>> GetCheckRepPdfAsync([Body] FinanceReportMainTestOldOnGetCheckRepPdfRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceReportMainTestOld/OnGetCheckUrl")]
    Task<GenericResult<FinanceReportMainTestOldOnGetCheckUrlResponse>> GetCheckUrlAsync([Body] FinanceReportMainTestOldOnGetCheckUrlRequest request, CancellationToken cancellationToken = default);
}
