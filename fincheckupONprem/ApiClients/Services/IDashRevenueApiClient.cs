using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.DashRevenue;
using fincheckup.ApiClients.Models.Responses.DashRevenue;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IDashRevenueApiClient : IApiClientBase
{
    [Post("/api/dashrevenue/OnGet")]
    Task<GenericResult<DashRevenueOnGetResponse>> GetAsync([Body] DashRevenueOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/dashrevenue/OnGetSalerMain")]
    Task<GenericResult<DashRevenueOnGetSalerMainResponse>> GetSalerMainAsync([Body] DashRevenueOnGetSalerMainRequest request, CancellationToken cancellationToken);

    [Post("/api/dashrevenue/OnGetPrio")]
    Task<GenericResult<DashRevenueOnGetPrioResponse>> GetPrioAsync([Body] DashRevenueOnGetPrioRequest request, CancellationToken cancellationToken);

    [Post("/api/dashrevenue/OnGetChartRasyo")]
    Task<GenericResult<DashRevenueOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] DashRevenueOnGetChartRasyoRequest request, CancellationToken cancellationToken);

    [Post("/api/dashrevenue/OnGetGraphYear")]
    Task<GenericResult<DashRevenueOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashRevenueOnGetGraphYearRequest request, CancellationToken cancellationToken);

    [Post("/api/dashrevenue/OnGetGraphComp")]
    Task<GenericResult<DashRevenueOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashRevenueOnGetGraphCompRequest request, CancellationToken cancellationToken);
}