using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMizan;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.UploadMizan;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;
using System.Threading;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceMizanUploadMizanApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUploadMizan/OnGet")]
    Task<GenericResult<MizanUploadMizanOnGetResponse>> GetAsync([Body] MizanUploadMizanOnGetRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceMizanUploadMizan/OnGetSalerMainChk")]
    Task<GenericResult<MizanUploadMizanOnGetSalerMainChkResponse>> GetSalerMainChkAsync([Body] MizanUploadMizanOnGetSalerMainChkRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceMizanUploadMizan/OnGetSalerMainZeta")]
    Task<GenericResult<MizanUploadMizanOnGetSalerMainZetaResponse>> GetSalerMainZetaAsync([Body] MizanUploadMizanOnGetSalerMainZetaRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceMizanUploadMizan/OnGetSalerDate")]
    Task<GenericResult<MizanUploadMizanOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUploadMizanOnGetSalerDateRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceMizanUploadMizan/OnGetSalerYear")]
    Task<GenericResult<MizanUploadMizanOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUploadMizanOnGetSalerYearRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceMizanUploadMizan/OnGetSalerComp")]
    Task<GenericResult<MizanUploadMizanOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUploadMizanOnGetSalerCompRequest request, CancellationToken cancellationToken);

    [Post("/api/finance/mizan/FinanceMizanUploadMizan/OnGetGraphYearDel")]
    Task<GenericResult<MizanUploadMizanOnGetGraphYearDelResponse>> GetGraphYearDelAsync([Body] MizanUploadMizanOnGetGraphYearDelRequest request, CancellationToken cancellationToken);
}