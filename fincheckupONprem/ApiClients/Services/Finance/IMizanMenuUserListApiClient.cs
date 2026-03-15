using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.UserList;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.Menu.UserList;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanMenuUserListApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/menu/UserList/OnGet")]
    Task<GenericResult<MizanUserListOnGetResponse>> GetAsync([Body] MizanUserListOnGetRequest request, CancellationToken cancellationToken);
}