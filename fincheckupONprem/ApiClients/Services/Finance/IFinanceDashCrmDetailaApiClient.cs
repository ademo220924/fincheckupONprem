using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Finance.DashCrmDetaila;
using fincheckup.ApiClients.Models.Responses.Finance.DashCrmDetaila;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceDashCrmDetailaApiClient : IApiClientBase
{
    [Post("/api/finance/FinanceDashCrmDetaila/OnGet")]
    Task<GenericResult<FinanceDashCrmDetailaOnGetResponse>> GetAsync([Body] FinanceDashCrmDetailaOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceDashCrmDetaila/OnGetChartRasyo")]
    Task<GenericResult<FinanceDashCrmDetailaOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] FinanceDashCrmDetailaOnGetChartRasyoRequest request, CancellationToken cancellationToken);
}