using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Responses.Finance.UpReportMain;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Finance.UpReportMain;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceUpReportMainApiClient : IApiClientBase
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