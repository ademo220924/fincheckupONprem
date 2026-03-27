using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Models.Responses.DashBoard;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.DashBoard;
using fincheckup.ApiClients.Models.Responses.DashBoard;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IDashBoardApiClient : IApiClientBase
{
    [Post("/api/DashBoard")]
    Task<GenericResult<DashBoardOnGetResponse>> GetAsync([Body] DashBoardOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/DashBoard/shedule")]
    Task<GenericResult<DashBoardOnGetSheduleResponse>> GetSheduleAsync([Body] DashBoardOnGetSheduleRequest request, CancellationToken cancellationToken);

    [Post("/api/DashBoard/prio")]
    Task<GenericResult<DashBoardOnGetPrioResponse>> GetPrioAsync([Body] DashBoardOnGetPrioRequest request, CancellationToken cancellationToken);

    [Post("/api/DashBoard/graph-zet")]
    Task<GenericResult<DashBoardOnGetGraphZetResponse>> GetGraphZetAsync([Body] DashBoardOnGetGraphZetRequest request, CancellationToken cancellationToken);

    [Post("/api/DashBoard/graph-zetm")]
    Task<GenericResult<DashBoardOnGetGraphZetMResponse>> GetGraphZetMAsync([Body] DashBoardOnGetGraphZetMRequest request, CancellationToken cancellationToken);

    [Post("/api/DashBoard/GetGraphYear")]
    Task<GenericResult<DashBoardOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashBoardOnGetGraphYearRequest request, CancellationToken cancellationToken);

    [Post("/api/DashBoard/graph-comp")]
    Task<GenericResult<DashBoardOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashBoardOnGetGraphCompRequest request, CancellationToken cancellationToken);
}
