using fincheckup.ApiClients.Models.Requests.Finance.DashBilancoJrnl;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceDashBilancoJrnlController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceDashBilancoJrnlController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceDashBilancoJrnlClient : IApiClientBase
{
    [Post("/api/finance/FinanceDashBilancoJrnl/OnGet")]
    Task<GenericResult<FinanceDashBilancoJrnlOnGetResponse>> GetAsync([Body] FinanceDashBilancoJrnlOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/FinanceDashBilancoJrnl/OnGetMarkupMarjin")]
    Task<GenericResult<FinanceDashBilancoJrnlOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] FinanceDashBilancoJrnlOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
