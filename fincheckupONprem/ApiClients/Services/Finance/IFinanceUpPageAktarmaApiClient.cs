using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Responses.Finance.UpPageAktarma;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Finance.UpPageAktarma;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceUpPageAktarmaApiClient : IApiClientBase
{
    [Post("/api/finance/FinanceUpPageAktarma/OnGet")]
    Task<GenericResult<FinanceUpPageAktarmaOnGetResponse>> GetAsync([Body] FinanceUpPageAktarmaOnGetRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/FinanceUpPageAktarma/OnGetSalerDateMain")]
    Task<GenericResult<FinanceUpPageAktarmaOnGetSalerDateMainResponse>> GetSalerDateMainAsync([Body] FinanceUpPageAktarmaOnGetSalerDateMainRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/FinanceUpPageAktarma/OnGetCheckRepPdf")]
    Task<GenericResult<FinanceUpPageAktarmaOnGetCheckRepPdfResponse>> GetCheckRepPdfAsync([Body] FinanceUpPageAktarmaOnGetCheckRepPdfRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/FinanceUpPageAktarma/OnGetSalerDate")]
    Task<GenericResult<FinanceUpPageAktarmaOnGetSalerDateResponse>> GetSalerDateAsync([Body] FinanceUpPageAktarmaOnGetSalerDateRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/FinanceUpPageAktarma/OnGetSalerYear")]
    Task<GenericResult<FinanceUpPageAktarmaOnGetSalerYearResponse>> GetSalerYearAsync([Body] FinanceUpPageAktarmaOnGetSalerYearRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/FinanceUpPageAktarma/OnGetSalerComp")]
    Task<GenericResult<FinanceUpPageAktarmaOnGetSalerCompResponse>> GetSalerCompAsync([Body] FinanceUpPageAktarmaOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
}