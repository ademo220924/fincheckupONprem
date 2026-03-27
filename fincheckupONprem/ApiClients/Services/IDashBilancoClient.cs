using fincheckup.ApiClients.Models.Requests.DashBilanco;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for DashBilancoController. Source: src/FinanceCheckUp.Api/Controllers/v1/DashBilancoController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IDashBilancoClient : IApiClientBase
{
    [Post("/api/dashbilanco")]
    Task<GenericResult<DashBilancoOnGetResponse>> GetAsync([Body] DashBilancoOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilanco/saler-main")]
    Task<GenericResult<DashBilancoOnGetSalerMainResponse>> GetSalerMainAsync([Body] DashBilancoOnGetSalerMainRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilanco/prio")]
    Task<GenericResult<DashBilancoOnGetPrioResponse>> GetPrioAsync([Body] DashBilancoOnGetPrioRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilanco/graph-year")]
    Task<GenericResult<DashBilancoOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashBilancoOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilanco/chart-rasyo")]
    Task<GenericResult<DashBilancoOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] DashBilancoOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashbilanco/graph-comp")]
    Task<GenericResult<DashBilancoOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashBilancoOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
}
