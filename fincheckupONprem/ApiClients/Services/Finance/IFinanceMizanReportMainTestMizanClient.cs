using fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportMainTestMizan;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.ReportMainTestMizan;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanReportMainTestMizanController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanReportMainTestMizanController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanReportMainTestMizanClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanReportMainTestMizan/OnGet")]
    Task<GenericResult<MizanReportMainTestMizanOnGetResponse>> GetAsync([Body] MizanReportMainTestMizanOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanReportMainTestMizan/OnGetSalerDate")]
    Task<GenericResult<MizanReportMainTestMizanOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanReportMainTestMizanOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanReportMainTestMizan/OnGetSalerYear")]
    Task<GenericResult<MizanReportMainTestMizanOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanReportMainTestMizanOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanReportMainTestMizan/OnGetSalerComp")]
    Task<GenericResult<MizanReportMainTestMizanOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanReportMainTestMizanOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanReportMainTestMizan/OnGetCheckRepPdf")]
    Task<GenericResult<MizanReportMainTestMizanOnGetCheckRepPdfResponse>> GetCheckRepPdfAsync([Body] MizanReportMainTestMizanOnGetCheckRepPdfQuery request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanReportMainTestMizan/OnGetCheckUrl")]
    Task<GenericResult<MizanReportMainTestMizanOnGetCheckUrlResponse>> GetCheckUrlAsync([Body] MizanReportMainTestMizanOnGetCheckUrlRequest request, CancellationToken cancellationToken = default);
}
