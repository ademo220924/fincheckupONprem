using fincheckup.ApiClients.Models.Requests.Finance.Menu.FirmPanel;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMenuFirmPanelController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMenuFirmPanelController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMenuFirmPanelClient : IApiClientBase
{
    [Post("/api/finance/menu/FinanceMenuFirmPanel/OnGet")]
    Task<GenericResult<FirmPanelOnGetResponse>> GetAsync([Body] FirmPanelOnGetRequest request, CancellationToken cancellationToken = default);
}
