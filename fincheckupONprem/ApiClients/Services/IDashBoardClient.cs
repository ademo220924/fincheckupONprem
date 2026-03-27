using fincheckup.ApiClients.Models.Requests.DashBoard;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for DashBoardController. Source: src/FinanceCheckUp.Api/Controllers/v1/DashBoardController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IDashBoardClient : IApiClientBase
{
    [Post("/api/DashBoard")]
    Task<GenericResult<DashBoardOnGetResponse>> GetAsync([Body] DashBoardOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/DashBoard/shedule")]
    Task<GenericResult<DashBoardOnGetSheduleResponse>> GetSheduleAsync([Body] DashBoardOnGetSheduleRequest request, CancellationToken cancellationToken = default);
    [Post("/api/DashBoard/prio")]
    Task<GenericResult<DashBoardOnGetPrioResponse>> GetPrioAsync([Body] DashBoardOnGetPrioRequest request, CancellationToken cancellationToken = default);
    [Post("/api/DashBoard/graph-zet")]
    Task<GenericResult<DashBoardOnGetGraphZetResponse>> GetGraphZetAsync([Body] DashBoardOnGetGraphZetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/DashBoard/graph-zetm")]
    Task<GenericResult<DashBoardOnGetGraphZetMResponse>> GetGraphZetMAsync([Body] DashBoardOnGetGraphZetMRequest request, CancellationToken cancellationToken = default);
    [Post("/api/DashBoard/GetGraphYear")]
    Task<GenericResult<DashBoardOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashBoardOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/DashBoard/graph-comp")]
    Task<GenericResult<DashBoardOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashBoardOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
}
