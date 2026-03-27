using fincheckup.ApiClients.Models.Requests.DashWorkingCapital;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for DashWorkingCapitalController. Source: src/FinanceCheckUp.Api/Controllers/v1/DashWorkingCapitalController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IDashWorkingCapitalClient : IApiClientBase
{
    [Post("/api/dashworkingcapital/OnGet")]
    Task<GenericResult<DashWorkingCapitalOnGetResponse>> GetAsync([Body] DashWorkingCapitalOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashworkingcapital/OnGetSalerMain")]
    Task<GenericResult<DashWorkingCapitalOnGetSalerMainResponse>> GetSalerMainAsync([Body] DashWorkingCapitalOnGetSalerMainRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashworkingcapital/OnGetPrio")]
    Task<GenericResult<DashWorkingCapitalOnGetPrioResponse>> GetPrioAsync([Body] DashWorkingCapitalOnGetPrioRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashworkingcapital/OnGetGraphYear")]
    Task<GenericResult<DashWorkingCapitalOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashWorkingCapitalOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/dashworkingcapital/OnGetGraphComp")]
    Task<GenericResult<DashWorkingCapitalOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashWorkingCapitalOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
}
