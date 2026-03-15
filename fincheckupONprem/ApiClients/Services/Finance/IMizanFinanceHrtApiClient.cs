using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrt;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.FinanceHrt;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanFinanceHrtApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceHrt/OnGet")]
    Task<GenericResult<MizanFinanceHrtOnGetResponse>> GetAsync([Body] MizanFinanceHrtOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceHrt/OnGetMarkupMarjin")]
    Task<GenericResult<MizanFinanceHrtOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanFinanceHrtOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceHrt/OnGetMarkupMarjinA")]
    Task<GenericResult<MizanFinanceHrtOnGetMarkupMarjinAResponse>> GetMarkupMarjinAAsync([Body] MizanFinanceHrtOnGetMarkupMarjinARequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceHrt/OnGetMarkupMarjinB")]
    Task<GenericResult<MizanFinanceHrtOnGetMarkupMarjinBResponse>> GetMarkupMarjinBAsync([Body] MizanFinanceHrtOnGetMarkupMarjinBRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceHrt/OnGetChartRasyo")]
    Task<GenericResult<MizanFinanceHrtOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] MizanFinanceHrtOnGetChartRasyoRequest request, CancellationToken cancellationToken);
}