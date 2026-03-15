using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinancesHrtfibapr;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.FinancesHrtfibapr;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanFinancesHrtfibaprApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinancesHrtfibapr/OnGet")]
    Task<GenericResult<MizanFinancesHrtfibaprOnGetResponse>> GetAsync([Body] MizanFinancesHrtfibaprOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinancesHrtfibapr/OnGetMarkupMarjin")]
    Task<GenericResult<MizanFinancesHrtfibaprOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanFinancesHrtfibaprOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinancesHrtfibapr/OnGetMarkupMarjinA")]
    Task<GenericResult<MizanFinancesHrtfibaprOnGetMarkupMarjinAResponse>> GetMarkupMarjinAAsync([Body] MizanFinancesHrtfibaprOnGetMarkupMarjinARequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinancesHrtfibapr/OnGetMarkupMarjinB")]
    Task<GenericResult<MizanFinancesHrtfibaprOnGetMarkupMarjinBResponse>> GetMarkupMarjinBAsync([Body] MizanFinancesHrtfibaprOnGetMarkupMarjinBRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinancesHrtfibapr/OnGetMarkupMarjinC")]
    Task<GenericResult<MizanFinancesHrtfibaprOnGetMarkupMarjinCResponse>> GetMarkupMarjinCAsync([Body] MizanFinancesHrtfibaprOnGetMarkupMarjinCRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinancesHrtfibapr/OnGetChartRasyo")]
    Task<GenericResult<MizanFinancesHrtfibaprOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] MizanFinancesHrtfibaprOnGetChartRasyoRequest request, CancellationToken cancellationToken);
}