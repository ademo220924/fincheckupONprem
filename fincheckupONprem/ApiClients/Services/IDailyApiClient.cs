using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Models.Responses.Daily;
using fincheckup.ApiClients.Models.Requests.Daily;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IDailyApiClient
{
    [Post("/api/daily/create")]
    Task<GenericResult<DailyCreateResponse>> CreateAsync([Body] DailyCreateRequest request, CancellationToken cancellationToken);

    [Put("/api/daily/{id:int}/update")]
    Task<GenericResult<DailyUpdateResponse>> UpdateAsync(int id, [Body] DailyUpdateRequest request, CancellationToken cancellationToken);

    [Delete("/api/daily/{id:int}/delete")]
    Task<GenericResult<DailyDeleteResponse>> DeleteAsync(int id, CancellationToken cancellationToken);

    [Post("/api/daily/{year:int}/list")]
    Task<GenericResult<DailyGetListResponse>> GetListAsync(int year, [Body] DailyGetListRequest request, CancellationToken cancellationToken);

    [Post("/api/daily/Priority")]
    Task<GenericResult<DailyGetPriorityResponse>> GetPriorityAsync([Body] DailyPrioritytRequest request, CancellationToken cancellationToken);
}
