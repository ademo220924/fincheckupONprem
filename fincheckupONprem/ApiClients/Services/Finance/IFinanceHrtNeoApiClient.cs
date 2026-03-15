using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Finance.FinanceHrtNeo;
using fincheckup.ApiClients.Models.Responses.Finance.FinanceHrtNeo;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceHrtNeoApiClient : IApiClientBase
{
    [Post("/api/finance/FinanceHrtNeo/OnGet")]
    Task<GenericResult<FinanceFinanceHrtNeoOnGetResponse>> GetAsync([Body] FinanceFinanceHrtNeoOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceHrtNeo/OnGetChartRasyo")]
    Task<GenericResult<FinanceFinanceHrtNeoOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] FinanceFinanceHrtNeoOnGetChartRasyoRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceHrtNeo/OnGetMarkupMarjin")]
    Task<GenericResult<FinanceFinanceHrtNeoOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] FinanceFinanceHrtNeoOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceHrtNeo/OnGetMarkupMarjinA")]
    Task<GenericResult<FinanceFinanceHrtNeoOnGetMarkupMarjinAResponse>> GetMarkupMarjinAAsync([Body] FinanceFinanceHrtNeoOnGetMarkupMarjinARequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceHrtNeo/OnGetMarkupMarjinB")]
    Task<GenericResult<FinanceFinanceHrtNeoOnGetMarkupMarjinBResponse>> GetMarkupMarjinBAsync([Body] FinanceFinanceHrtNeoOnGetMarkupMarjinBRequest request, CancellationToken cancellationToken);
}