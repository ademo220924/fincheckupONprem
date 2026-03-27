using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Jrnl.DashBilancoJrnl;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanJrnlDashBilancoJrnlController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanJrnlDashBilancoJrnlController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanJrnlDashBilancoJrnlClient : IApiClientBase
{
    [Post("/api/finance/mizan/jrnl/FinanceMizanJrnlDashBilancoJrnl/OnGet")]
    Task<GenericResult<MizanDashBilancoJrnlOnGetResponse>> GetAsync([Body] MizanDashBilancoJrnlOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/jrnl/FinanceMizanJrnlDashBilancoJrnl/OnGetMarkupMarjin")]
    Task<GenericResult<MizanDashBilancoJrnlOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanDashBilancoJrnlOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
