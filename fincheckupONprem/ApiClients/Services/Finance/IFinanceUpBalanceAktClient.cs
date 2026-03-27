using fincheckup.ApiClients.Models.Requests.Finance.UpBalanceAkt;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceUpBalanceAktController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceUpBalanceAktController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceUpBalanceAktClient : IApiClientBase
{
    [Post("/api/finance/FinanceUpBalanceAkt/OnGet")]
    Task<GenericResult<FinanceUpBalanceAktOnGetResponse>> GetAsync([Body] FinanceUpBalanceAktOnGetRequest request, CancellationToken cancellationToken = default);
}
