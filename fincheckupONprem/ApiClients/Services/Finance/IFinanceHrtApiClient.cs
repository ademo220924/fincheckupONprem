using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Finance.FinanceHrt;
using fincheckup.ApiClients.Models.Responses.Finance.FinanceHrt;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceHrtApiClient : IApiClientBase
{
    [Post("/api/finance/FinanceHrt/OnGet")]
    Task<GenericResult<FinanceFinanceHrtOnGetResponse>> GetAsync([Body] FinanceFinanceHrtOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceHrt/OnGetChartRasyo")]
    Task<GenericResult<FinanceFinanceHrtOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] FinanceFinanceHrtOnGetChartRasyoRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceHrt/OnGetMarkupMarjin")]
    Task<GenericResult<FinanceFinanceHrtOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] FinanceFinanceHrtOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceHrt/OnGetMarkupMarjinA")]
    Task<GenericResult<FinanceFinanceHrtOnGetMarkupMarjinAResponse>> GetMarkupMarjinAAsync([Body] FinanceFinanceHrtOnGetMarkupMarjinARequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceHrt/OnGetMarkupMarjinB")]
    Task<GenericResult<FinanceFinanceHrtOnGetMarkupMarjinBResponse>> GetMarkupMarjinBAsync([Body] FinanceFinanceHrtOnGetMarkupMarjinBRequest request, CancellationToken cancellationToken);
}