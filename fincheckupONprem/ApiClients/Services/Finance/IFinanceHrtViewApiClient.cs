using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.FinanceHrtView;
using fincheckup.ApiClients.Models.Responses.Finance.FinanceHrtView;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceHrtViewApiClient : IApiClientBase
{
    [Post("/api/finance/FinanceHrtView/OnGet")]
    Task<GenericResult<FinanceFinanceHrtViewOnGetResponse>> GetAsync([Body] FinanceFinanceHrtViewOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceHrtView/OnGetMarkupMarjin")]
    Task<GenericResult<FinanceFinanceHrtViewOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] FinanceFinanceHrtViewOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceHrtView/OnGetEbitMarjin")]
    Task<GenericResult<FinanceFinanceHrtViewOnGetEbitMarjinResponse>> GetEbitMarjinAsync([Body] FinanceFinanceHrtViewOnGetEbitMarjinRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceHrtView/OnGetWorkingCapital")]
    Task<GenericResult<FinanceFinanceHrtViewOnGetWorkingCapitalResponse>> GetWorkingCapitalAsync([Body] FinanceFinanceHrtViewOnGetWorkingCapitalRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceHrtView/OnGetDonemselKarZarar")]
    Task<GenericResult<FinanceFinanceHrtViewOnGetDonemselKarZararResponse>> GetDonemselKarZararAsync([Body] FinanceFinanceHrtViewOnGetDonemselKarZararRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceHrtView/OnGetRevenue")]
    Task<GenericResult<FinanceFinanceHrtViewOnGetRevenueResponse>> GetRevenueAsync([Body] FinanceFinanceHrtViewOnGetRevenueRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceHrtView/OnGetGrossProfit")]
    Task<GenericResult<FinanceFinanceHrtViewOnGetGrossProfitResponse>> GetGrossProfitAsync([Body] FinanceFinanceHrtViewOnGetGrossProfitRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceHrtView/OnGetGraphZet")]
    Task<GenericResult<FinanceFinanceHrtViewOnGetGraphZetResponse>> GetGraphZetAsync([Body] FinanceFinanceHrtViewOnGetGraphZetRequest request, CancellationToken cancellationToken);
}