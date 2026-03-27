using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Jrnl.DashBilancoRevenueJrnl;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanJrnlDashBilancoRevenueJrnlController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanJrnlDashBilancoRevenueJrnlController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanJrnlDashBilancoRevenueJrnlClient : IApiClientBase
{
    [Post("/api/finance/mizan/jrnl/FinanceMizanJrnlDashBilancoRevenueJrnl/OnGet")]
    Task<GenericResult<MizanDashBilancoRevenueJrnlOnGetResponse>> GetAsync([Body] MizanDashBilancoRevenueJrnlOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/jrnl/FinanceMizanJrnlDashBilancoRevenueJrnl/OnGetMarkupMarjin")]
    Task<GenericResult<MizanDashBilancoRevenueJrnlOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanDashBilancoRevenueJrnlOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
