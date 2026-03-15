using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Responses.Finance.UpPageAktarmaJrnl;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Finance.UpPageAktarmaJrnl;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance;

public interface IFinanceUpPageAktarmaJrnlApiClient : IApiClientBase
    {
        [Post("/api/finance/FinanceUpPageAktarmaJrnl/OnGet")]
        Task<GenericResult<FinanceUpPageAktarmaJrnlOnGetResponse>> GetAsync([Body] FinanceUpPageAktarmaJrnlOnGetRequest request, CancellationToken cancellationToken = default);

        [Post("/api/finance/FinanceUpPageAktarmaJrnl/OnGetSalerDateMain")]
        Task<GenericResult<FinanceUpPageAktarmaJrnlOnGetSalerDateMainResponse>> GetSalerDateMainAsync([Body] FinanceUpPageAktarmaJrnlOnGetSalerDateMainRequest request, CancellationToken cancellationToken = default);

        [Post("/api/finance/FinanceUpPageAktarmaJrnl/OnGetSalerDateCode")]
        Task<GenericResult<FinanceUpPageAktarmaJrnlOnGetSalerDateCodeResponse>> GetSalerDateCodeAsync([Body] FinanceUpPageAktarmaJrnlOnGetSalerDateCodeRequest request, CancellationToken cancellationToken = default);

        [Post("/api/finance/FinanceUpPageAktarmaJrnl/OnGetSalerDate")]
        Task<GenericResult<FinanceUpPageAktarmaJrnlOnGetSalerDateResponse>> GetSalerDateAsync([Body] FinanceUpPageAktarmaJrnlOnGetSalerDateRequest request, CancellationToken cancellationToken = default);

        [Post("/api/finance/FinanceUpPageAktarmaJrnl/OnGetSalerYear")]
        Task<GenericResult<FinanceUpPageAktarmaJrnlOnGetSalerYearResponse>> GetSalerYearAsync([Body] FinanceUpPageAktarmaJrnlOnGetSalerYearRequest request, CancellationToken cancellationToken = default);

        [Post("/api/finance/FinanceUpPageAktarmaJrnl/OnGetSalerComp")]
        Task<GenericResult<FinanceUpPageAktarmaJrnlOnGetSalerCompResponse>> GetSalerCompAsync([Body] FinanceUpPageAktarmaJrnlOnGetSalerCompRequest request, CancellationToken cancellationToken = default);

        [Post("/api/finance/FinanceUpPageAktarmaJrnl/OnGetGraphCode")]
        Task<GenericResult<FinanceUpPageAktarmaJrnlOnGetGraphCodeResponse>> GetGraphCodeAsync([Body] FinanceUpPageAktarmaJrnlOnGetGraphCodeRequest request, CancellationToken cancellationToken = default);

        [Post("/api/finance/FinanceUpPageAktarmaJrnl/OnGetGraphCodeDel")]
        Task<GenericResult<FinanceUpPageAktarmaJrnlOnGetGraphCodeDelResponse>> GetGraphCodeDelAsync([Body] FinanceUpPageAktarmaJrnlOnGetGraphCodeDelRequest request, CancellationToken cancellationToken = default);
    }