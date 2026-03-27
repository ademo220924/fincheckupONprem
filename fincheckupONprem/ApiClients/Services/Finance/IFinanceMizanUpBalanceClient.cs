using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalance;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanUpBalanceController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanUpBalanceController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanUpBalanceClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUpBalance/OnGet")]
    Task<GenericResult<MizanUpBalanceOnGetResponse>> GetAsync([Body] MizanUpBalanceOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUpBalance/OnGetSalerDate")]
    Task<GenericResult<MizanUpBalanceOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUpBalanceOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUpBalance/OnGetSalerYear")]
    Task<GenericResult<MizanUpBalanceOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUpBalanceOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUpBalance/OnGetSalerComp")]
    Task<GenericResult<MizanUpBalanceOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUpBalanceOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUpBalance/OnGetGraphYear")]
    Task<GenericResult<MizanUpBalanceOnGetGraphYearResponse>> GetGraphYearAsync([Body] MizanUpBalanceOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
}
