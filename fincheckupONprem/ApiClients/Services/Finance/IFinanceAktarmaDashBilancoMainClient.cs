using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Finance.Aktarma.dashbilancomain;
using fincheckup.ApiClients.Models.Responses.Finance.Aktarma.dashbilancomain;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceAktarmaDashBilancoMainController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceAktarmaDashBilancoMainController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceAktarmaDashBilancoMainClient : IApiClientBase
{
    [Post("/api/finance/aktarma/FinanceAktarmaDashBilancoMain/OnGet")]
    Task<GenericResult<AktarmaDashbilancomainOnGetResponse>> GetAsync([Body] AktarmaDashbilancomainOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/aktarma/FinanceAktarmaDashBilancoMain/OnGetGraphYear")]
    Task<GenericResult<AktarmaDashbilancomainOnGetGraphYearResponse>> GetGraphYearAsync([Body] AktarmaDashbilancomainOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/aktarma/FinanceAktarmaDashBilancoMain/OnGetMarkupMarjin")]
    Task<GenericResult<AktarmaDashbilancomainOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] AktarmaDashbilancomainOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
