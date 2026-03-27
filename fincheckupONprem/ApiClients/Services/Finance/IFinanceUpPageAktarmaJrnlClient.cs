using fincheckup.ApiClients.Models.Requests.Finance.UpPageAktarmaJrnl;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceUpPageAktarmaJrnlController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceUpPageAktarmaJrnlController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceUpPageAktarmaJrnlClient : IApiClientBase
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
