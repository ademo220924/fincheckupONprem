using fincheckup.ApiClients.Models.Requests.DashCrmDetaila;
using fincheckup.ApiClients.Models.Requests.DashCrmDetailb;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for DashCrmDetailbController. Source: src/FinanceCheckUp.Api/Controllers/v1/DashCrmDetailbController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IDashCrmDetailbClient : IApiClientBase
{
    [Post("/api/dashcrmdetailb/OnGet")]
    Task<GenericResult<DashCrmDetailbOnGetResponse>> GetAsync([Body] DashCrmDetailbOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrmdetailb/OnGetSalerMain")]
    Task<GenericResult<DashCrmDetailbOnGetSalerMainResponse>> GetSalerMainAsync([Body] DashCrmDetailbOnGetSalerMainRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrmdetailb/OnGetPrio")]
    Task<GenericResult<DashCrmDetailbOnGetPrioResponse>> GetPrioAsync([Body] DashCrmDetailbOnGetPrioRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrmdetailb/OnGetGraphYear")]
    Task<GenericResult<DashCrmDetailbOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashCrmDetailbOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrmdetailb/OnGetRasyoChart")]
    Task<GenericResult<DashCrmDetailaOnGetChartRasyoResponse>> GetRasyoChartAsync([Body] DashCrmDetailbOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrmdetailb/OnGetGraphComp")]
    Task<GenericResult<DashCrmDetailbOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashCrmDetailbOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
}
