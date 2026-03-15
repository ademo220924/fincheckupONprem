using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Responses.Finance.UpPageAktarmaMzn;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Finance.UpPageAktarmaMzn;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceUpPageAktarmaMznApiClient : IApiClientBase
{
    [Post("/api/finance/FinanceUpPageAktarmaMzn/OnGet")]
    Task<GenericResult<FinanceUpPageAktarmaMznOnGetResponse>> GetAsync([Body] FinanceUpPageAktarmaMznOnGetRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/FinanceUpPageAktarmaMzn/OnGetSalerDateMain")]
    Task<GenericResult<FinanceUpPageAktarmaMznOnGetSalerDateMainResponse>> GetSalerDateMainAsync([Body] FinanceUpPageAktarmaMznOnGetSalerDateMainRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/FinanceUpPageAktarmaMzn/OnGetSalerDate")]
    Task<GenericResult<FinanceUpPageAktarmaMznOnGetSalerDateResponse>> GetSalerDateAsync([Body] FinanceUpPageAktarmaMznOnGetSalerDateRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/FinanceUpPageAktarmaMzn/OnGetSalerYear")]
    Task<GenericResult<FinanceUpPageAktarmaMznOnGetSalerYearResponse>> GetSalerYearAsync([Body] FinanceUpPageAktarmaMznOnGetSalerYearRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/FinanceUpPageAktarmaMzn/OnGetSalerComp")]
    Task<GenericResult<FinanceUpPageAktarmaMznOnGetSalerCompResponse>> GetSalerCompAsync([Body] FinanceUpPageAktarmaMznOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
}