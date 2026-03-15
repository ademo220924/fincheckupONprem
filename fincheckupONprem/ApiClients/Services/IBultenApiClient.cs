using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Bulten;
using fincheckup.ApiClients.Models.Responses.Bulten;
using fincheckup.ApiClients.Services.Base;
using Refit;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

public interface IBultenApiClient: IApiClientBase
{
    [Post("/api/bulten/save")]
    Task<GenericResult<BultenCreateResponse>> CreateAsync([Body] BultenCreateRequest request,[Header("user-id")] string userId);
    
    [Post("/api/bulten/update")]
    Task<GenericResult<BultenCreateResponse>> UpdateAsync([Body] BultenUpdateRequest request,[Header("user-id")] string userId);
}
