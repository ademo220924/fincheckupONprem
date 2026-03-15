using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Responses.Finance.UpBalance;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Finance.UpBalance;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceUpBalanceApiClient : IApiClientBase
{
    [Post("/api/finance/FinanceUpBalance/OnGet")]
    Task<GenericResult<FinanceUpBalanceOnGetResponse>> GetAsync([Body] FinanceUpBalanceOnGetRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/FinanceUpBalance/OnGetSalerDate")]
    Task<GenericResult<FinanceUpBalanceOnGetSalerDateResponse>> GetSalerDateAsync([Body] FinanceUpBalanceOnGetSalerDateRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/FinanceUpBalance/OnGetSalerYear")]
    Task<GenericResult<FinanceUpBalanceOnGetSalerYearResponse>> GetSalerYearAsync([Body] FinanceUpBalanceOnGetSalerYearRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/FinanceUpBalance/OnGetSalerComp")]
    Task<GenericResult<FinanceUpBalanceOnGetSalerCompResponse>> GetSalerCompAsync([Body] FinanceUpBalanceOnGetSalerCompRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/FinanceUpBalance/OnGetCheckRepPdf")]
    Task<GenericResult<FinanceUpBalanceOnGetCheckRepPdfResponse>> GetCheckRepPdfAsync([Body] FinanceUpBalanceOnGetCheckRepPdfRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/FinanceUpBalance/OnGetCheckRepXls")]
    Task<GenericResult<FinanceUpBalanceOnGetCheckRepXlsResponse>> GetCheckRepXlsAsync([Body] FinanceUpBalanceOnGetCheckRepXlsRequest request, CancellationToken cancellationToken = default);
}