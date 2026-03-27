using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalanceAkt;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanUpBalanceAktController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanUpBalanceAktController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanUpBalanceAktClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUpBalanceAkt/OnGet")]
    Task<GenericResult<MizanUpBalanceAktOnGetResponse>> GetAsync([Body] MizanUpBalanceAktOnGetRequest request, CancellationToken cancellationToken = default);
}
