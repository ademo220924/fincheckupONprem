using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMznOldYedek;
using fincheckup.ApiClients.Models.Responses.Finance.Mizan.UploadMznOldYedek;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceMizanUploadMznOldYedekApiClient : IApiClientBase
{
    [Post("/api/finance/mizan/FinanceMizanUploadMznOldYedek/OnGet")]
    Task<GenericResult<MizanUploadMznOldYedekOnGetResponse>> GetAsync([Body] MizanUploadMznOldYedekOnGetRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/mizan/FinanceMizanUploadMznOldYedek/OnGetSalerDate")]
    Task<GenericResult<MizanUploadMznOldYedekOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUploadMznOldYedekOnGetSalerDateRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/mizan/FinanceMizanUploadMznOldYedek/OnGetSalerYear")]
    Task<GenericResult<MizanUploadMznOldYedekOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUploadMznOldYedekOnGetSalerYearRequest request, CancellationToken cancellationToken = default);

    [Post("/api/finance/mizan/FinanceMizanUploadMznOldYedek/OnGetSalerComp")]
    Task<GenericResult<MizanUploadMznOldYedekOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUploadMznOldYedekOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
}