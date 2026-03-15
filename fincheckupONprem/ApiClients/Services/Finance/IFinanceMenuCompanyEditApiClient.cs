using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Menu.CompanyEdit;
using fincheckup.ApiClients.Models.Responses.Finance.Menu.CompanyEdit;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceMenuCompanyEditApiClient : IApiClientBase
{
    [Post("/api/finance/menu/FinanceMenuCompanyEdit/OnGet")]
    Task<GenericResult<CompanyEditOnGetResponse>> GetAsync([Body] CompanyEditOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/menu/FinanceMenuCompanyEdit/OnGetSalerEnteg")]
    Task<GenericResult<CompanyEditOnGetSalerEntegResponse>> GetSalerEntegAsync([Body] CompanyEditOnGetSalerEntegRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/menu/FinanceMenuCompanyEdit/OnGetSalerCity")]
    Task<GenericResult<CompanyEditOnGetSalerCityResponse>> GetSalerCityAsync([Body] CompanyEditOnGetSalerCityRequest request, CancellationToken cancellationToken);
}