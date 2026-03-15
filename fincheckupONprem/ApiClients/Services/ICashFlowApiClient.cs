using Refit;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Models.Requests.CashFlow;
using fincheckup.ApiClients.Models.Responses.CashFlow;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface ICashFlowApiClient: IApiClientBase
{
    [Post("/api/cashflow")]
    Task<GenericResult<OnGetResponseModel>> GetAsync([Body] CashFlowOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/cashflow/saler-main")]
    Task<GenericResult<GetSalerMainResponseModel>> GetSalerMainAsync([Body] GetSalerMainRequestModel request, CancellationToken cancellationToken);

    [Post("/api/cashflow/prio")]
    Task<GenericResult<GetPrioResponseModel>> GetPrioAsync([Body] GetPrioRequestModel request, CancellationToken cancellationToken);

    [Post("/api/cashflow/graph-year")]
    Task<GenericResult<GetGraphYearResponseModel>> OnGetGraphYearAsync([Body] GetGraphYearRequestModel request, CancellationToken cancellationToken);

    [Post("/api/cashflow/chart-rasyo")]
    Task<GenericResult<GetChartRasyoResponseModel>> GetChartRasyoAsync([Body] GetChartRasyoRequestModel request, CancellationToken cancellationToken);

    [Post("/api/cashflow/markup-marjin")]
    Task<GenericResult<GetMarkupMarjinResponseModel>> GetMarkupMarjinAsync([Body] GetMarkupMarjinRequestModel request, CancellationToken cancellationToken);

    [Post("/api/cashflow/graph-comp")]
    Task<GenericResult<GetGraphCompResponseModel>> OnGetGraphCompAsync([Body] GetGraphCompRequestModel request, CancellationToken cancellationToken);

}
