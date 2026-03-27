using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Finance.Aktarma.DashBilanco;
using fincheckup.ApiClients.Models.Responses.Finance.Aktarma.DashBilanco;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceAktarmaDashBilancoController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceAktarmaDashBilancoController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceAktarmaDashBilancoClient : IApiClientBase
{
    [Post("/api/finance/aktarma/FinanceAktarmaDashBilanco/OnGet")]
    Task<GenericResult<AktarmaDashBilancoOnGetResponse>> GetAsync([Body] AktarmaDashBilancoOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/aktarma/FinanceAktarmaDashBilanco/OnGetGraphYear")]
    Task<GenericResult<AktarmaDashBilancoOnGetGraphYearResponse>> GetGraphYearAsync([Body] AktarmaDashBilancoOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/aktarma/FinanceAktarmaDashBilanco/OnGetAktarmaResult")]
    Task<GenericResult<AktarmaDashBilancoOnGetAktarmaResultResponse>> GetAktarmaResultAsync([Body] AktarmaDashBilancoOnGetAktarmaResultRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/aktarma/FinanceAktarmaDashBilanco/OnGetDonukResult")]
    Task<GenericResult<AktarmaDashBilancoOnGetDonukResultResponse>> GetDonukResultAsync([Body] AktarmaDashBilancoOnGetDonukResultRequest request, CancellationToken cancellationToken = default);
    [Post("/api/finance/aktarma/FinanceAktarmaDashBilanco/OnGetMarkupMarjin")]
    Task<GenericResult<AktarmaDashBilancoOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] AktarmaDashBilancoOnGetMarkupMarjinRequest request, CancellationToken cancellationToken = default);
}
