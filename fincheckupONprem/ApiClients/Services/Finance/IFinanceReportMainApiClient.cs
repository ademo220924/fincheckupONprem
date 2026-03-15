using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.ReportMain;
using fincheckup.ApiClients.Models.Responses.Finance.ReportMain;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceReportMainApiClient : IApiClientBase
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