using fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportMainTestMizanOld;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanReportMainTestMizanOldController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanReportMainTestMizanOldController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanReportMainTestMizanOldClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanReportMainTestMizanOld/OnGet")]
    Task<GenericResult<MizanReportMainTestMizanOldOnGetResponse>> GetAsync([Body] MizanReportMainTestMizanOldOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanReportMainTestMizanOld/OnGetSalerDate")]
    Task<GenericResult<MizanReportMainTestMizanOldOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanReportMainTestMizanOldOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanReportMainTestMizanOld/OnGetSalerYear")]
    Task<GenericResult<MizanReportMainTestMizanOldOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanReportMainTestMizanOldOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanReportMainTestMizanOld/OnGetSalerComp")]
    Task<GenericResult<MizanReportMainTestMizanOldOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanReportMainTestMizanOldOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanReportMainTestMizanOld/OnGetCheckRepPdf")]
    Task<GenericResult<MizanReportMainTestMizanOldOnGetCheckRepPdfResponse>> GetCheckRepPdfAsync([Body] MizanReportMainTestMizanOldOnGetCheckRepPdfRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanReportMainTestMizanOld/OnGetCheckUrl")]
    Task<GenericResult<MizanReportMainTestMizanOldOnGetCheckUrlResponse>> GetCheckUrlAsync([Body] MizanReportMainTestMizanOldOnGetCheckUrlRequest request, CancellationToken cancellationToken = default);
}
