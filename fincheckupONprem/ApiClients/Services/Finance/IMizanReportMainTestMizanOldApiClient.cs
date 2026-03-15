using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportMainTestMizanOld;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.ReportMainTestMizanOld;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanReportMainTestMizanOldApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/ReportMainTestMizanOld/OnGet")]
    Task<GenericResult<MizanReportMainTestMizanOldOnGetResponse>> GetAsync([Body] MizanReportMainTestMizanOldOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/ReportMainTestMizanOld/OnGetSalerDate")]
    Task<GenericResult<MizanReportMainTestMizanOldOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanReportMainTestMizanOldOnGetSalerDateRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/ReportMainTestMizanOld/OnGetSalerYear")]
    Task<GenericResult<MizanReportMainTestMizanOldOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanReportMainTestMizanOldOnGetSalerYearRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/ReportMainTestMizanOld/OnGetSalerComp")]
    Task<GenericResult<MizanReportMainTestMizanOldOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanReportMainTestMizanOldOnGetSalerCompRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/ReportMainTestMizanOld/OnGetCheckRepPdf")]
    Task<GenericResult<MizanReportMainTestMizanOldOnGetCheckRepPdfResponse>> GetCheckRepPdfAsync([Body] MizanReportMainTestMizanOldOnGetCheckRepPdfRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/ReportMainTestMizanOld/OnGetCheckUrl")]
    Task<GenericResult<MizanReportMainTestMizanOldOnGetCheckUrlResponse>> GetCheckUrlAsync([Body] MizanReportMainTestMizanOldOnGetCheckUrlRequest request, CancellationToken cancellationToken);
}