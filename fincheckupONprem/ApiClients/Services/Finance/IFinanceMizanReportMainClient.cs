using fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportMain;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanReportMainController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanReportMainController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanReportMainClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanReportMain/OnGet")]
    Task<GenericResult<MizanReportMainOnGetResponse>> GetAsync([Body] MizanReportMainOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanReportMain/OnGetMarkupMarjin")]
    Task<GenericResult<MizanReportMainOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanReportMainOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanReportMain/OnGetEbitMarjin")]
    Task<GenericResult<MizanReportMainOnGetEbitMarjinResponse>> GetEbitMarjinAsync([Body] MizanReportMainOnGetEbitMarjinRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanReportMain/OnGetWorkingCapital")]
    Task<GenericResult<MizanReportMainOnGetWorkingCapitalResponse>> GetWorkingCapitalAsync([Body] MizanReportMainOnGetWorkingCapitalRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanReportMain/OnGetDonemselKarZarar")]
    Task<GenericResult<MizanReportMainOnGetDonemselKarZararResponse>> GetDonemselKarZararAsync([Body] MizanReportMainOnGetDonemselKarZararRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanReportMain/OnGetRevenue")]
    Task<GenericResult<MizanReportMainOnGetRevenueResponse>> GetRevenueAsync([Body] MizanReportMainOnGetRevenueRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanReportMain/OnGetGrossProfit")]
    Task<GenericResult<MizanReportMainOnGetGrossProfitResponse>> GetGrossProfitAsync([Body] MizanReportMainOnGetGrossProfitRequest request, CancellationToken cancellationToken = default);
}
