using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpPageAktarma;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanUpPageAktarmaController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanUpPageAktarmaController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanUpPageAktarmaClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUpPageAktarma/OnGet")]
    Task<GenericResult<MizanUpPageAktarmaOnGetResponse>> GetAsync([Body] MizanUpPageAktarmaOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUpPageAktarma/OnGetSalerDateMain")]
    Task<GenericResult<MizanUpPageAktarmaOnGetSalerDateMainResponse>> GetSalerDateMainAsync([Body] MizanUpPageAktarmaOnGetSalerDateMainQuery request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUpPageAktarma/OnGetSalerDate")]
    Task<GenericResult<MizanUpPageAktarmaOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUpPageAktarmaOnGetSalerDateQuery request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUpPageAktarma/OnGetSalerYear")]
    Task<GenericResult<MizanUpPageAktarmaOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUpPageAktarmaOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUpPageAktarma/OnGetSalerComp")]
    Task<GenericResult<MizanUpPageAktarmaOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUpPageAktarmaOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/mizan/FinanceMizanUpPageAktarma/OnGetCheckRepPdf")]
    Task<GenericResult<MizanUpPageAktarmaOnGetCheckRepPdfResponse>> GetCheckRepPdfAsync([Body] MizanUpPageAktarmaOnGetCheckRepPdfRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/mizan/FinanceMizanUpPageAktarma/OnGetMarkupMarjin")]
    Task<GenericResult<MizanUpPageAktarmaOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanUpPageAktarmaOnGetMarkupMarjinQuery request, CancellationToken cancellationToken = default);
}
