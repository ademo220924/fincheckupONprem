using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Finance.DashCrmDetailc;
using fincheckup.ApiClients.Models.Responses.Finance.DashCrmDetailc;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceDashCrmDetailcApiClient : IApiClientBase
{
    [Post("/api/finance/FinanceDashCrmDetailc/OnGet")]
    Task<GenericResult<FinanceDashCrmDetailcOnGetResponse>> GetAsync([Body] FinanceDashCrmDetailcOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceDashCrmDetailc/OnGetChartRasyo")]
    Task<GenericResult<FinanceDashCrmDetailcOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] FinanceDashCrmDetailcOnGetChartRasyoRequest request, CancellationToken cancellationToken);
}