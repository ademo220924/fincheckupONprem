using fincheckup.ApiClients.Models.Requests.Finance.Menu.UserList;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMenuUserListController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMenuUserListController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMenuUserListClient : IApiClientBase
{
    [Post("/api/finance/menu/FinanceMenuUserList/OnGet")]
    Task<GenericResult<UserListOnGetResponse>> GetAsync([Body] UserListOnGetRequest request, CancellationToken cancellationToken = default);
}
