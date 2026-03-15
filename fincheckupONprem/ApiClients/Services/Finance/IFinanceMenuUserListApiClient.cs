using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Menu.UserList;
using fincheckup.ApiClients.Models.Responses.Finance.Menu.UserList;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceMenuUserListApiClient : IApiClientBase
{
    [Post("/api/finance/menu/FinanceMenuUserList/OnGet")]
    Task<GenericResult<UserListOnGetResponse>> GetAsync([Body] UserListOnGetRequest request, CancellationToken cancellationToken);
}