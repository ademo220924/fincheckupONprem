using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalanceNew;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpBalanceNew;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;
using System.Threading;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceMizanUpBalanceNewApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUpBalanceNew/OnGet")]
    Task<GenericResult<MizanUpBalanceNewOnGetResponse>> GetAsync([Body] MizanUpBalanceNewOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceMizanUpBalanceNew/OnGetSalerDate")]
    Task<GenericResult<MizanUpBalanceNewOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUpBalanceNewOnGetSalerDateQuery request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceMizanUpBalanceNew/OnGetSalerYear")]
    Task<GenericResult<MizanUpBalanceNewOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUpBalanceNewOnGetSalerYearRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceMizanUpBalanceNew/OnGetSalerComp")]
    Task<GenericResult<MizanUpBalanceNewOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUpBalanceNewOnGetSalerCompRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceMizanUpBalanceNew/OnGetCheckRepPdf")]
    Task<GenericResult<MizanUpBalanceNewOnGetCheckRepPdfResponse>> GetCheckRepPdfAsync([Body] MizanUpBalanceNewOnGetCheckRepPdfRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceMizanUpBalanceNew/OnGetCheckRepXls")]
    Task<GenericResult<MizanUpBalanceNewOnGetCheckRepXlsResponse>> GetCheckRepXlsAsync([Body] MizanUpBalanceNewOnGetCheckRepXlsRequest request, CancellationToken cancellationToken);
}