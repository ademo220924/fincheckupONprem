using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Finance.DashBilanco;
using fincheckup.ApiClients.Models.Responses.Finance.DashBilanco;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceDashBilancoApiClient : IApiClientBase
{
    [Post("/api/finance/FinanceDashBilanco/OnGet")]
    Task<GenericResult<FinanceDashBilancoOnGetResponse>> GetAsync([Body] FinanceDashBilancoOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceDashBilanco/OnGetChartRasyo")]
    Task<GenericResult<FinanceDashBilancoOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] FinanceDashBilancoOnGetChartRasyoRequest request, CancellationToken cancellationToken);
}