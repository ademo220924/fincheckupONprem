using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalance;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpBalance;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;
using System.Threading;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceMizanUpBalanceApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUpBalance/OnGet")]
    Task<GenericResult<MizanUpBalanceOnGetResponse>> GetAsync([Body] MizanUpBalanceOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceMizanUpBalance/OnGetSalerDate")]
    Task<GenericResult<MizanUpBalanceOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUpBalanceOnGetSalerDateRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceMizanUpBalance/OnGetSalerYear")]
    Task<GenericResult<MizanUpBalanceOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUpBalanceOnGetSalerYearRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceMizanUpBalance/OnGetSalerComp")]
    Task<GenericResult<MizanUpBalanceOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUpBalanceOnGetSalerCompRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceMizanUpBalance/OnGetGraphYear")]
    Task<GenericResult<MizanUpBalanceOnGetGraphYearResponse>> GetGraphYearAsync([Body] MizanUpBalanceOnGetGraphYearRequest request, CancellationToken cancellationToken);
}