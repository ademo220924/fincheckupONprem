using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportMainTestMizan;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.ReportMainTestMizan;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanReportMainTestMizanApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/ReportMainTestMizan/OnGet")]
    Task<GenericResult<MizanReportMainTestMizanOnGetResponse>> GetAsync([Body] MizanReportMainTestMizanOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/ReportMainTestMizan/OnGetSalerDate")]
    Task<GenericResult<MizanReportMainTestMizanOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanReportMainTestMizanOnGetSalerDateRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/ReportMainTestMizan/OnGetSalerYear")]
    Task<GenericResult<MizanReportMainTestMizanOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanReportMainTestMizanOnGetSalerYearRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/ReportMainTestMizan/OnGetSalerComp")]
    Task<GenericResult<MizanReportMainTestMizanOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanReportMainTestMizanOnGetSalerCompRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/ReportMainTestMizan/OnGetCheckRepPdf")]
    Task<GenericResult<MizanReportMainTestMizanOnGetCheckRepPdfResponse>> GetCheckRepPdfAsync([Body] MizanReportMainTestMizanOnGetCheckRepPdfRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/ReportMainTestMizan/OnGetCheckUrl")]
    Task<GenericResult<MizanReportMainTestMizanOnGetCheckUrlResponse>> GetCheckUrlAsync([Body] MizanReportMainTestMizanOnGetCheckUrlRequest request, CancellationToken cancellationToken);
}