using fincheckup.ApiClients.Models.Requests.DashCrmDetaila;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for DashCrmDetailaController. Source: src/FinanceCheckUp.Api/Controllers/v1/DashCrmDetailaController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IDashCrmDetailaClient : IApiClientBase
{
    [Post("/api/dashcrmdetaila/OnGet")]
    Task<GenericResult<DashCrmDetailaOnGetResponse>> GetAsync([Body] DashCrmDetailaOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrmdetaila/OnGetSalerMain")]
    Task<GenericResult<DashCrmDetailaOnGetSalerMainResponse>> GetSalerMainAsync([Body] DashCrmDetailaOnGetSalerMainRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrmdetaila/OnGetPrio")]
    Task<GenericResult<DashCrmDetailaOnGetPrioResponse>> GetPrioAsync([Body] DashCrmDetailaOnGetPrioRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrmdetaila/OnGetGraphYear")]
    Task<GenericResult<DashCrmDetailaOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashCrmDetailaOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrmdetaila/OnGetGraphComp")]
    Task<GenericResult<DashCrmDetailaOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashCrmDetailaOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
}
