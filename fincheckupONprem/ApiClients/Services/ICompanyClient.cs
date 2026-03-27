using fincheckup.ApiClients.Models.Requests;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for CompanyController. Source: src/FinanceCheckUp.Api/Controllers/v1/CompanyController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface ICompanyClient : IApiClientBase
{
    [Post("/api/company/create")]
    Task<GenericResult<CompanyCreateResponse>> CreateAsync([Body] CompanyCreateRequest request, CancellationToken cancellationToken = default);
    [Put("/api/company/update")]
    Task<GenericResult<CompanyUpdateResponse>> UpdateAsync([Body] CompanyUpdateRequest request, CancellationToken cancellationToken = default);
}
