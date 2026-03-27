using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.FirmPanel;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanMenuFirmPanelController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanMenuFirmPanelController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanMenuFirmPanelClient : IApiClientBase
{
    [Post("/api/finance/mizan/menu/FinanceMizanMenuFirmPanel/OnGet")]
    Task<GenericResult<MizanFirmPanelOnGetResponse>> GetAsync([Body] MizanFirmPanelOnGetRequest request, CancellationToken cancellationToken = default);
}
