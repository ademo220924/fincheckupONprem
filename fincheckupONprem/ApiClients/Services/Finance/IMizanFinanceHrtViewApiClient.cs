using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrtView;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.FinanceHrtView;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanFinanceHrtViewApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceHrtView/OnGet")]
    Task<GenericResult<MizanFinanceHrtViewOnGetResponse>> GetAsync([Body] MizanFinanceHrtViewOnGetRequest request,
        CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceHrtView/OnGetMarkupMarjin")]
    Task<GenericResult<MizanFinanceHrtViewOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync(
        [Body] MizanFinanceHrtViewOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceHrtView/OnGetEbitMarjin")]
    Task<GenericResult<MizanFinanceHrtViewOnGetEbitMarjinResponse>> GetEbitMarjinAsync(
        [Body] MizanFinanceHrtViewOnGetEbitMarjinRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceHrtView/OnGetWorkingCapital")]
    Task<GenericResult<MizanFinanceHrtViewOnGetWorkingCapitalResponse>> GetWorkingCapitalAsync(
        [Body] MizanFinanceHrtViewOnGetWorkingCapitalRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceHrtView/OnGetDonemselKarZarar")]
    Task<GenericResult<MizanFinanceHrtViewOnGetDonemselKarZararResponse>> GetDonemselKarZararAsync(
        [Body] MizanFinanceHrtViewOnGetDonemselKarZararRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceHrtView/OnGetRevenue")]
    Task<GenericResult<MizanFinanceHrtViewOnGetRevenueResponse>> GetRevenueAsync(
        [Body] MizanFinanceHrtViewOnGetRevenueRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceHrtView/OnGetGrossProfit")]
    Task<GenericResult<MizanFinanceHrtViewOnGetGrossProfitResponse>> GetGrossProfitAsync(
        [Body] MizanFinanceHrtViewOnGetGrossProfitRequest request, CancellationToken cancellationToken);
}
