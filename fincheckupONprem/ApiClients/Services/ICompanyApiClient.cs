using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.Company;
using fincheckup.ApiClients.Models.Responses.Company;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface ICompanyApiClient : IApiClientBase
{
    [Post("/api/company/create")]
    Task<GenericResult<CompanyCreateResponse>> CreateAsync([Body] CompanyCreateRequest request, CancellationToken cancellationToken);

    [Put("/api/company/update")]
    Task<GenericResult<CompanyUpdateResponse>> UpdateAsync([Body] CompanyUpdateRequest request, CancellationToken cancellationToken);
}