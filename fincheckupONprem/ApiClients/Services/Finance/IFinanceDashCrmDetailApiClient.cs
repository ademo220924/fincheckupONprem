using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Finance.DashCrmDetail;
using fincheckup.ApiClients.Models.Responses.Finance.DashCrmDetail;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceDashCrmDetailApiClient : IApiClientBase
{
    [Post("/api/finance/FinanceDashCrmDetail/OnGet")]
    Task<GenericResult<FinanceDashCrmDetailOnGetResponse>> GetAsync([Body] FinanceDashCrmDetailOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceDashCrmDetail/OnGetChartRasyo")]
    Task<GenericResult<FinanceDashCrmDetailOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] FinanceDashCrmDetailOnGetChartRasyoRequest request, CancellationToken cancellationToken);
}