using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.CompanyEdit;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.Menu.CompanyEdit;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanMenuCompanyEditApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/menu/CompanyEdit/OnGet")]
    Task<GenericResult<MizanCompanyEditOnGetResponse>> GetAsync([Body] MizanCompanyEditOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/menu/CompanyEdit/OnGetSalerEnteg")]
    Task<GenericResult<MizanCompanyEditOnGetSalerEntegResponse>> GetSalerEntegAsync([Body] MizanCompanyEditOnGetSalerEntegRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/menu/CompanyEdit/OnGetSalerCity")]
    Task<GenericResult<MizanCompanyEditOnGetSalerCityResponse>> GetSalerCityAsync([Body] MizanCompanyEditOnGetSalerCityRequest request, CancellationToken cancellationToken);
}