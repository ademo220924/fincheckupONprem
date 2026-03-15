using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.ReportMainTestOld;
using fincheckup.ApiClients.Models.Responses.Finance.ReportMainTestOld;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceReportMainTestOldApiClient : IApiClientBase
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