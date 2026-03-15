using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.CashFlow;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.CashFlow;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IMizanCashFlowApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/CashFlow/OnGet")]
    Task<GenericResult<MizanCashFlowOnGetResponse>> GetAsync([Body] MizanCashFlowOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/CashFlow/OnGetGraphYear")]
    Task<GenericResult<MizanCashFlowOnGetGraphYearResponse>> GetGraphYearAsync([Body] MizanCashFlowOnGetGraphYearRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/CashFlow/OnGetChartRasyo")]
    Task<GenericResult<MizanCashFlowOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] MizanCashFlowOnGetChartRasyoRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/CashFlow/OnGetMarkupMarjin")]
    Task<GenericResult<MizanCashFlowOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] MizanCashFlowOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}