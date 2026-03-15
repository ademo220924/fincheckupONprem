using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrtNeo;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.FinanceHrtNeo;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanFinanceHrtNeoApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceHrtNeo/OnGet")]
    Task<GenericResult<MizanFinanceHrtNeoOnGetResponse>> GetAsync([Body] FinanceHrtNeoOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceHrtNeo/OnGetMarkupMarjin")]
    Task<GenericResult<MizanFinanceHrtNeoOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanFinanceHrtNeoOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceHrtNeo/OnGetMarkupMarjinA")]
    Task<GenericResult<MizanFinanceHrtNeoOnGetMarkupMarjinAResponse>> GetMarkupMarjinAAsync([Body] MizanFinanceHrtNeoOnGetMarkupMarjinARequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceHrtNeo/OnGetMarkupMarjinB")]
    Task<GenericResult<MizanFinanceHrtNeoOnGetMarkupMarjinBResponse>> GetMarkupMarjinBAsync([Body] MizanFinanceHrtNeoOnGetMarkupMarjinBRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceHrtNeo/OnGetChartRasyo")]
    Task<GenericResult<MizanFinanceHrtNeoOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] MizanFinanceHrtNeoOnGetChartRasyoRequest request, CancellationToken cancellationToken);
}