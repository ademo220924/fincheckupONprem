using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.CashFlow;
using fincheckup.ApiClients.Models.Responses.Finance.CashFlow;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceCashFlowApiClient : IApiClientBase
{
    [Post("/api/finance/FinanceCashFlow/OnGet")]
    Task<GenericResult<FinanceCashFlowOnGetResponse>> GetAsync([Body] FinanceCashFlowOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceCashFlow/OnGetGraphYear")]
    Task<GenericResult<FinanceCashFlowOnGetGraphYearResponse>> GetGraphYearAsync([Body] FinanceCashFlowOnGetGraphYearRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceCashFlow/OnGetChartRasyo")]
    Task<GenericResult<FinanceCashFlowOnGetChartRasyoResponse>> GetChartRasyoAsync([Body] FinanceCashFlowOnGetChartRasyoRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/FinanceCashFlow/OnGetMarkupMarjin")]
    Task<GenericResult<FinanceCashFlowOnGetMarkupMarjinResponse>> GetMarkupMarjinAsync([Body] FinanceCashFlowOnGetMarkupMarjinRequest request, CancellationToken cancellationToken);
}