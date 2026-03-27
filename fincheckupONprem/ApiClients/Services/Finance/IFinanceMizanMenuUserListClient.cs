using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.UserList;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanMenuUserListController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanMenuUserListController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanMenuUserListClient : IApiClientBase
{
    [Post("/api/finance/mizan/menu/FinanceMizanMenuUserList/OnGet")]
    Task<GenericResult<MizanUserListOnGetResponse>> GetAsync([Body] MizanUserListOnGetRequest request, CancellationToken cancellationToken = default);
}
