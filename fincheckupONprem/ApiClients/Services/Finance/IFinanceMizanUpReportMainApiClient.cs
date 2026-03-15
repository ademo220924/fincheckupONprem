using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpReportMain;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.UpReportMain;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceMizanUpReportMainApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUpReportMain/OnGet")]
    Task<GenericResult<MizanUpReportMainOnGetResponse>> GetAsync([Body] MizanUpReportMainOnGetRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/mizan/FinanceMizanUpReportMain/OnGetSalerDate")]
    Task<GenericResult<MizanUpReportMainOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUpReportMainOnGetSalerDateRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/mizan/FinanceMizanUpReportMain/OnGetSalerYear")]
    Task<GenericResult<MizanUpReportMainOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUpReportMainOnGetSalerYearRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/mizan/FinanceMizanUpReportMain/OnGetSalerComp")]
    Task<GenericResult<MizanUpReportMainOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUpReportMainOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
}