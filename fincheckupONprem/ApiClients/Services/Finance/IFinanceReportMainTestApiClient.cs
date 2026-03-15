using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.ReportMainTest;
using fincheckup.ApiClients.Models.Responses.Finance.ReportMainTest;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceReportMainTestApiClient : IApiClientBase
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