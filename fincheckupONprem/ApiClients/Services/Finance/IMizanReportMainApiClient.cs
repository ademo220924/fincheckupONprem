using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportMain;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.ReportMain;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanReportMainApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/ReportMain/OnGet")]
    Task<GenericResult<MizanReportMainOnGetResponse>> GetAsync([Body] MizanReportMainOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/ReportMain/OnGetMarkupMarjin")]
    Task<GenericResult<MizanReportMainOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanReportMainOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/ReportMain/OnGetEbitMarjin")]
    Task<GenericResult<MizanReportMainOnGetEbitMarjinResponse>> GetEbitMarjinAsync([Body] MizanReportMainOnGetEbitMarjinRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/ReportMain/OnGetWorkingCapital")]
    Task<GenericResult<MizanReportMainOnGetWorkingCapitalResponse>> GetWorkingCapitalAsync([Body] MizanReportMainOnGetWorkingCapitalRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/ReportMain/OnGetDonemselKarZarar")]
    Task<GenericResult<MizanReportMainOnGetDonemselKarZararResponse>> GetDonemselKarZararAsync([Body] MizanReportMainOnGetDonemselKarZararRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/ReportMain/OnGetRevenue")]
    Task<GenericResult<MizanReportMainOnGetRevenueResponse>> GetRevenueAsync([Body] MizanReportMainOnGetRevenueRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/ReportMain/OnGetGrossProfit")]
    Task<GenericResult<MizanReportMainOnGetGrossProfitResponse>> GetGrossProfitAsync([Body] MizanReportMainOnGetGrossProfitRequest request, CancellationToken cancellationToken);
}