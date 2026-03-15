using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Finance.DashRevenue;
using fincheckup.ApiClients.Models.Responses.Finance.DashRevenue;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceDashRevenueApiClient : IApiClientBase
{
    [Post("/api/finance/FinanceDashRevenue/OnGet")]
    Task<GenericResult<FinanceDashRevenueOnGetResponse>> GetAsync([Body] FinanceDashRevenueOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceDashRevenue/OnGetChartRasyo")]
    Task<GenericResult<FinanceDashRevenueOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] FinanceDashRevenueOnGetChartRasyoRequest request, CancellationToken cancellationToken);
}