using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadSmm;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.UploadSmm;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceMizanUploadSmmApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUploadSmm/OnGet")]
    Task<GenericResult<MizanUploadSmmOnGetResponse>> GetAsync([Body] MizanUploadSmmOnGetRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/mizan/FinanceMizanUploadSmm/OnGetSalerDate")]
    Task<GenericResult<MizanUploadSmmOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUploadSmmOnGetSalerDateRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/mizan/FinanceMizanUploadSmm/OnGetSalerYear")]
    Task<GenericResult<MizanUploadSmmOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUploadSmmOnGetSalerYearRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/mizan/FinanceMizanUploadSmm/OnGetSalerComp")]
    Task<GenericResult<MizanUploadSmmOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUploadSmmOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
}