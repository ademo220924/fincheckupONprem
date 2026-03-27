using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for BultenController. Source: src/FinanceCheckUp.Api/Controllers/v1/BultenController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IBultenClient : IApiClientBase
{
    [Post("/api/bulten/save")]
    Task<object> CreateAsync([Body] BultenCreateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/bulten/update")]
    Task<object> UpdateAsync([Body] BultenUpdateRequest request, CancellationToken cancellationToken = default);
}
