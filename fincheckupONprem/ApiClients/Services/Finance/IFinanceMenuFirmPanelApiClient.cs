using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Menu.FirmPanel;
using fincheckup.ApiClients.Models.Responses.Finance.Menu.FirmPanel;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceMenuFirmPanelApiClient : IApiClientBase
{
    [Post("/api/finance/menu/FinanceMenuFirmPanel/OnGet")]
    Task<GenericResult<FirmPanelOnGetResponse>> GetAsync([Body] FirmPanelOnGetRequest request, CancellationToken cancellationToken);
}