using fincheckup.ApiClients.Models.Requests.Finance.ReportMain;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceReportMainController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceReportMainController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceReportMainClient : IApiClientBase
{
    [Post("/api/finance/FinanceReportMain/OnGet")]
    Task<GenericResult<FinanceReportMainOnGetResponse>> GetAsync([Body] FinanceReportMainOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceReportMain/OnGetMarkupMarjin")]
    Task<GenericResult<FinanceReportMainOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] FinanceReportMainOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceReportMain/OnGetEbitMarjin")]
    Task<GenericResult<FinanceReportMainOnGetEbitMarjinResponse>> GetEbitMarjinAsync([Body] FinanceReportMainOnGetEbitMarjinRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceReportMain/OnGetWorkingCapital")]
    Task<GenericResult<FinanceReportMainOnGetWorkingCapitalResponse>> GetWorkingCapitalAsync([Body] FinanceReportMainOnGetWorkingCapitalRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceReportMain/OnGetDonemselKarZarar")]
    Task<GenericResult<FinanceReportMainOnGetDonemselKarZararResponse>> GetDonemselKarZararAsync([Body] FinanceReportMainOnGetDonemselKarZararRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceReportMain/OnGetRevenue")]
    Task<GenericResult<FinanceReportMainOnGetRevenueResponse>> GetRevenueAsync([Body] FinanceReportMainOnGetRevenueRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceReportMain/OnGetGrossProfit")]
    Task<GenericResult<FinanceReportMainOnGetGrossProfitResponse>> GetGrossProfitAsync([Body] FinanceReportMainOnGetGrossProfitRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceReportMain/OnGetGraphZet")]
    Task<GenericResult<FinanceReportMainOnGetGraphZetResponse>> GetGraphZetAsync([Body] FinanceReportMainOnGetGraphZetRequest request, CancellationToken cancellationToken = default);
}
