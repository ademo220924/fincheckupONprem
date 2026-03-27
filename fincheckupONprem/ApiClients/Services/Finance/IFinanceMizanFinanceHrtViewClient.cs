using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrtView;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.FinanceHrtView;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanFinanceHrtViewController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanFinanceHrtViewController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanFinanceHrtViewClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanFinanceHrtView/OnGet")]
    Task<GenericResult<MizanFinanceHrtViewOnGetResponse>> GetAsync([Body] MizanFinanceHrtViewOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinanceHrtView/OnGetMarkupMarjin")]
    Task<GenericResult<MizanFinanceHrtViewOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanFinanceHrtViewOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinanceHrtView/OnGetEbitMarjin")]
    Task<GenericResult<MizanFinanceHrtViewOnGetEbitMarjinResponse>> GetEbitMarjinAsync([Body] MizanFinanceHrtViewOnGetEbitMarjinRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinanceHrtView/OnGetWorkingCapital")]
    Task<GenericResult<MizanFinanceHrtViewOnGetWorkingCapitalResponse>> GetWorkingCapitalAsync([Body] MizanFinanceHrtViewOnGetWorkingCapitalRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinanceHrtView/OnGetDonemselKarZarar")]
    Task<GenericResult<MizanFinanceHrtViewOnGetDonemselKarZararResponse>> GetDonemselKarZararAsync([Body] MizanFinanceHrtViewOnGetDonemselKarZararRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinanceHrtView/OnGetRevenue")]
    Task<GenericResult<MizanFinanceHrtViewOnGetRevenueResponse>> GetRevenueAsync([Body] MizanFinanceHrtViewOnGetRevenueRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinanceHrtView/OnGetGrossProfit")]
    Task<GenericResult<MizanFinanceHrtViewOnGetGrossProfitResponse>> GetGrossProfitAsync([Body] MizanFinanceHrtViewOnGetGrossProfitRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanFinanceHrtView/OnGetGraphZet")]
    Task<GenericResult<MizanFinanceHrtViewOnGetGraphZetResponse>> GetGraphZetAsync([Body] MizanFinanceHrtViewOnGetGraphZetRequest request, CancellationToken cancellationToken = default);
}
