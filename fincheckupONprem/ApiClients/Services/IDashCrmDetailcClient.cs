using fincheckup.ApiClients.Models.Requests.DashCrmDetailc;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for DashCrmDetailcController. Source: src/FinanceCheckUp.Api/Controllers/v1/DashCrmDetailcController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IDashCrmDetailcClient : IApiClientBase
{
    [Post("/api/dashcrmdetailc/OnGet")]
    Task<GenericResult<DashCrmDetailcOnGetResponse>> GetAsync([Body] DashCrmDetailcOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrmdetailc/OnGetSalerMain")]
    Task<GenericResult<DashCrmDetailcOnGetSalerMainResponse>> GetSalerMainAsync([Body] DashCrmDetailcOnGetSalerMainRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrmdetailc/OnGetPrio")]
    Task<GenericResult<DashCrmDetailcOnGetPrioResponse>> GetPrioAsync([Body] DashCrmDetailcOnGetPrioRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrmdetailc/OnGetGraphYear")]
    Task<GenericResult<DashCrmDetailcOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashCrmDetailcOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrmdetailc/OnGetChartRasyo")]
    Task<GenericResult<DashCrmDetailcOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] DashCrmDetailcOnGetChartRasyoRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashcrmdetailc/OnGetGraphComp")]
    Task<GenericResult<DashCrmDetailcOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashCrmDetailcOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
}
