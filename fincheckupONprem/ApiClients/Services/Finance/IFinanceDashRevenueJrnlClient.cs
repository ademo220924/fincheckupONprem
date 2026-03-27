using fincheckup.ApiClients.Models.Requests.Finance.DashRevenueJrnl;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceDashRevenueJrnlController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceDashRevenueJrnlController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceDashRevenueJrnlClient : IApiClientBase
{
    [Post("/api/finance/FinanceDashRevenueJrnl/OnGet")]
    Task<GenericResult<FinanceDashRevenueJrnlOnGetResponse>> GetAsync([Body] FinanceDashRevenueJrnlOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceDashRevenueJrnl/OnGetMarkupMarjin")]
    Task<GenericResult<FinanceDashRevenueJrnlOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] FinanceDashRevenueJrnlOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
