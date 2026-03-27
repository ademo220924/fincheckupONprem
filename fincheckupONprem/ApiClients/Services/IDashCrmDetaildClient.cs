using fincheckup.ApiClients.Models.Requests.DashCrmDetaild;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for DashCrmDetaildController. Source: src/FinanceCheckUp.Api/Controllers/v1/DashCrmDetaildController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IDashCrmDetaildClient : IApiClientBase
{
    [Post("/api/dashcrmdetaild/OnGet")]
    Task<GenericResult<DashCrmDetaildOnGetResponse>> GetAsync([Body] DashCrmDetaildOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrmdetaild/OnGetSalerMain")]
    Task<GenericResult<DashCrmDetaildOnGetSalerMainResponse>> GetSalerMainAsync([Body] DashCrmDetaildOnGetSalerMainRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrmdetaild/OnGetChartRasyo")]
    Task<object> GetChartRasyoAsync([Body] DashCrmDetaildOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrmdetaild/OnGetGraphComp")]
    Task<GenericResult<DashCrmDetaildOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashCrmDetaildOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
}
