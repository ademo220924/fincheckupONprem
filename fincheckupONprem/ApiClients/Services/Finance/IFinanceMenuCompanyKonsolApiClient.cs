using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Menu.CompanyKonsol;
using fincheckup.ApiClients.Models.Responses.Finance.Menu.CompanyKonsol;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceMenuCompanyKonsolApiClient : IApiClientBase
{
    [Post("/api/finance/menu/FinanceMenuCompanyKonsol/OnGet")]
    Task<GenericResult<CompanyKonsolOnGetResponse>> GetAsync([Body] CompanyKonsolOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/menu/FinanceMenuCompanyKonsol/OnGetSalerEnteg")]
    Task<GenericResult<CompanyKonsolOnGetSalerEntegResponse>> GetSalerEntegAsync([Body] CompanyKonsolOnGetSalerEntegRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/menu/FinanceMenuCompanyKonsol/OnGetSalerCity")]
    Task<GenericResult<CompanyKonsolOnGetSalerCityResponse>> GetSalerCityAsync([Body] CompanyKonsolOnGetSalerCityRequest request, CancellationToken cancellationToken);
}