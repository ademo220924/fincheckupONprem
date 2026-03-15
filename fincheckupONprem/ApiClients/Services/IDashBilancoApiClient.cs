using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Responses.DashBilanco;
using fincheckup.ApiClients.Models.Requests.DashBilanco;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IDashBilancoApiClient : IApiClientBase
{
    [Post("/api/dashbilanco")]
    Task<GenericResult<DashBilancoOnGetResponse>> GetAsync([Body] DashBilancoOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/dashbilanco/saler-main")]
    Task<GenericResult<DashBilancoOnGetSalerMainResponse>> GetSalerMainAsync([Body] DashBilancoOnGetSalerMainRequest request, CancellationToken cancellationToken);

    [Post("/api/dashbilanco/prio")]
    Task<GenericResult<DashBilancoOnGetPrioResponse>> GetPrioAsync([Body] DashBilancoOnGetPrioRequest request, CancellationToken cancellationToken);

    [Post("/api/dashbilanco/graph-year")]
    Task<GenericResult<DashBilancoOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashBilancoOnGetGraphYearRequest request, CancellationToken cancellationToken);

    [Post("/api/dashbilanco/chart-rasyo")]
    Task<GenericResult<DashBilancoOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] DashBilancoOnGetChartRasyoRequest request, CancellationToken cancellationToken);

    [Post("/api/dashbilanco/graph-comp")]
    Task<GenericResult<DashBilancoOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashBilancoOnGetGraphCompRequest request, CancellationToken cancellationToken);
}
