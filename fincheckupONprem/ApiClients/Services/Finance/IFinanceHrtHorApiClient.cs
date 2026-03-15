using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.FinanceHrtHor;
using fincheckup.ApiClients.Models.Responses.Finance.FinanceHrtHor;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceHrtHorApiClient : IApiClientBase
{
    [Post("/api/finance/FinanceHrtHor/OnGet")]
    Task<GenericResult<FinanceFinanceHrtHorOnGetResponse>> GetAsync([Body] FinanceFinanceHrtHorOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceHrtHor/OnGetChartRasyo")]
    Task<GenericResult<FinanceFinanceHrtHorOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] FinanceFinanceHrtHorOnGetChartRasyoRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceHrtHor/OnGetMarkupMarjin")]
    Task<GenericResult<FinanceFinanceHrtHorOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] FinanceFinanceHrtHorOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceHrtHor/OnGetMarkupMarjinA")]
    Task<GenericResult<FinanceFinanceHrtHorOnGetMarkupMarjinAResponse>> GetMarkupMarjinAAsync([Body] FinanceFinanceHrtHorOnGetMarkupMarjinARequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceHrtHor/OnGetMarkupMarjinB")]
    Task<GenericResult<FinanceFinanceHrtHorOnGetMarkupMarjinBResponse>> GetMarkupMarjinBAsync([Body] FinanceFinanceHrtHorOnGetMarkupMarjinBRequest request, CancellationToken cancellationToken);
}