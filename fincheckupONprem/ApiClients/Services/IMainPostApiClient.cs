using Refit;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.Main;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IMainPostApiClient : IApiClientBase
{
    [Post("/api/main-post/tblzone-error-create-or-update")]
    Task<GenericResult<HttpResponseMessage>> TblErrorZoneCreateOrUpdateAsync([Body] TblZoneErrorCreateOrUpdateRequest request, CancellationToken cancellationToken);

    [Post("/api/main-post/tbl-wzone-create")]
    Task<GenericResult<HttpResponseMessage>> TblWzoneCreateAsync([Body] TblZoneErrorCreateOrUpdateRequest request, CancellationToken cancellationToken);
}