using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.DashWorkingCapital;
using fincheckup.ApiClients.Models.Responses.DashWorkingCapital;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IDashWorkingCapitalApiClient : IApiClientBase
{
    [Post("/api/dashworkingcapital/OnGet")]
    Task<GenericResult<DashWorkingCapitalOnGetResponse>> GetAsync([Body] DashWorkingCapitalOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/dashworkingcapital/OnGetSalerMain")]
    Task<GenericResult<DashWorkingCapitalOnGetSalerMainResponse>> GetSalerMainAsync([Body] DashWorkingCapitalOnGetSalerMainRequest request, CancellationToken cancellationToken);

    [Post("/api/dashworkingcapital/OnGetPrio")]
    Task<GenericResult<DashWorkingCapitalOnGetPrioResponse>> GetPrioAsync([Body] DashWorkingCapitalOnGetPrioRequest request, CancellationToken cancellationToken);

    [Post("/api/dashworkingcapital/OnGetGraphYear")]
    Task<GenericResult<DashWorkingCapitalOnGetGraphYearResponse>> GetGraphYearAsync([Body] DashWorkingCapitalOnGetGraphYearRequest request, CancellationToken cancellationToken);

    [Post("/api/dashworkingcapital/OnGetGraphComp")]
    Task<GenericResult<DashWorkingCapitalOnGetGraphCompResponse>> GetGraphCompAsync([Body] DashWorkingCapitalOnGetGraphCompRequest request, CancellationToken cancellationToken);
}