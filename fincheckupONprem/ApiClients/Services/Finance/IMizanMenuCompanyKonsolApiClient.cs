using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.CompanyKonsol;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.Menu.CompanyKonsol;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanMenuCompanyKonsolApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/menu/CompanyKonsol/OnGet")]
    Task<GenericResult<MizanCompanyKonsolOnGetResponse>> GetAsync([Body] MizanCompanyKonsolOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/menu/CompanyKonsol/OnGetSalerEnteg")]
    Task<GenericResult<MizanCompanyKonsolOnGetSalerEntegResponse>> GetSalerEntegAsync([Body] MizanCompanyKonsolOnGetSalerEntegRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/menu/CompanyKonsol/OnGetSalerCity")]
    Task<GenericResult<MizanCompanyKonsolOnGetSalerCityResponse>> GetSalerCityAsync([Body] MizanCompanyKonsolOnGetSalerCityRequest request, CancellationToken cancellationToken);
}