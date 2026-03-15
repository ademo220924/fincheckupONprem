using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.FirmPanel;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.Menu.FirmPanel;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanMenuFirmPanelApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/menu/FirmPanel/OnGet")]
    Task<GenericResult<MizanFirmPanelOnGetResponse>> GetAsync([Body] MizanFirmPanelOnGetRequest request, CancellationToken cancellationToken);
}