using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrtFiba;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.FinanceHrtFiba;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanFinanceHrtFibaApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceHrtFiba/OnGet")]
    Task<GenericResult<MizanFinanceHrtFibaOnGetResponse>> GetAsync([Body] MizanFinanceHrtFibaOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceHrtFiba/OnGetMarkupMarjin")]
    Task<GenericResult<MizanFinanceHrtFibaOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanFinanceHrtFibaOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceHrtFiba/OnGetMarkupMarjinA")]
    Task<GenericResult<MizanFinanceHrtFibaOnGetMarkupMarjinAResponse>> GetMarkupMarjinAAsync([Body] MizanFinanceHrtFibaOnGetMarkupMarjinARequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceHrtFiba/OnGetMarkupMarjinB")]
    Task<GenericResult<MizanFinanceHrtFibaOnGetMarkupMarjinBResponse>> GetMarkupMarjinBAsync([Body] MizanFinanceHrtFibaOnGetMarkupMarjinBRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceHrtFiba/OnGetMarkupMarjinC")]
    Task<GenericResult<MizanFinanceHrtFibaOnGetMarkupMarjinCResponse>> GetMarkupMarjinCAsync([Body] MizanFinanceHrtFibaOnGetMarkupMarjinCRequest request, CancellationToken cancellationToken);
}