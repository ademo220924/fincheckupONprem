using fincheckup.ApiClients.Models.Requests;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for MainPostController. Source: src/FinanceCheckUp.Api/Controllers/v1/MainPostController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IMainPostClient : IApiClientBase
{
    [Post("/api/main-post/tblzone-error-create-or-update")]
    Task<GenericResult<HttpResponseMessage>> TblErrorZoneCreateOrUpdateAsync([Body] TblZoneErrorCreateOrUpdateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/main-post/tbl-wzone-create")]
    Task<GenericResult<HttpResponseMessage>> TblWzoneCreateAsync([Body] TblZoneErrorCreateOrUpdateRequest request, CancellationToken cancellationToken = default);
}
