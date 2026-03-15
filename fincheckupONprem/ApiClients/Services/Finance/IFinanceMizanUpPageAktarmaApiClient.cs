using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpPageAktarma;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpPageAktarma;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceMizanUpPageAktarmaApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUpPageAktarma/OnGet")]
    Task<GenericResult<MizanUpPageAktarmaOnGetResponse>> GetAsync([Body] MizanUpPageAktarmaOnGetRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/mizan/FinanceMizanUpPageAktarma/OnGetSalerDateMain")]
    Task<GenericResult<MizanUpPageAktarmaOnGetSalerDateMainResponse>> GetSalerDateMainAsync([Body] MizanUpPageAktarmaOnGetSalerDateMainRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/mizan/FinanceMizanUpPageAktarma/OnGetSalerDate")]
    Task<GenericResult<MizanUpPageAktarmaOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUpPageAktarmaOnGetSalerDateRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/mizan/FinanceMizanUpPageAktarma/OnGetSalerYear")]
    Task<GenericResult<MizanUpPageAktarmaOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUpPageAktarmaOnGetSalerYearRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/mizan/FinanceMizanUpPageAktarma/OnGetSalerComp")]
    Task<GenericResult<MizanUpPageAktarmaOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUpPageAktarmaOnGetSalerCompRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/mizan/FinanceMizanUpPageAktarma/OnGetCheckRepPdf")]
    Task<GenericResult<MizanUpPageAktarmaOnGetCheckRepPdfResponse>> GetCheckRepPdfAsync([Body] MizanUpPageAktarmaOnGetCheckRepPdfRequest request, CancellationToken cancellationToken = default);
}