using fincheckup.ApiClients.Models.Requests.Finance.Mizan.Jrnl.UpPageAktarmaJrnl;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services.Finance;

/// <summary>
/// Refit client for FinanceMizanJrnlUpPageAktarmaJrnlController. Source: src/FinanceCheckUp.Api/Controllers/v1/Finance/FinanceMizanJrnlUpPageAktarmaJrnlController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceMizanJrnlUpPageAktarmaJrnlClient : IApiClientBase
{
    [Post("/api/finance/mizan/jrnl/FinanceMizanJrnlUpPageAktarmaJrnl/OnGet")]
    Task<GenericResult<MizanUpPageAktarmaJrnlOnGetResponse>> GetAsync([Body] MizanUpPageAktarmaJrnlOnGetRequest request, CancellationToken cancellationToken = default);
    
    [Post("/api/finance/mizan/jrnl/FinanceMizanJrnlUpPageAktarmaJrnl/OnGetSalerDateMain")]
    Task<GenericResult<MizanUpPageAktarmaJrnlOnGetSalerDateMainResponse>> GetSalerDateMainAsync([Body] MizanUpPageAktarmaJrnlOnGetSalerDateMainQuery request, CancellationToken cancellationToken = default);
    
    [Post("/api/finance/mizan/jrnl/FinanceMizanJrnlUpPageAktarmaJrnl/OnGetSalerDateCode")]
    Task<GenericResult<MizanUpPageAktarmaJrnlOnGetSalerDateCodeResponse>> GetSalerDateCodeAsync([Body] MizanUpPageAktarmaJrnlOnGetSalerDateCodeQuery request, CancellationToken cancellationToken = default);
    
    [Post("/api/finance/mizan/jrnl/FinanceMizanJrnlUpPageAktarmaJrnl/OnGetSalerDate")]
    Task<GenericResult<MizanUpPageAktarmaJrnlOnGetSalerDateResponse>> GetSalerDateAsync([Body] MizanUpPageAktarmaJrnlOnGetSalerDateQuery request, CancellationToken cancellationToken = default);
    
    [Post("/api/finance/mizan/jrnl/FinanceMizanJrnlUpPageAktarmaJrnl/OnGetSalerYear")]
    Task<GenericResult<MizanUpPageAktarmaJrnlOnGetSalerYearResponse>> GetSalerYearAsync([Body] MizanUpPageAktarmaJrnlOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    
    [Post("/api/finance/mizan/jrnl/FinanceMizanJrnlUpPageAktarmaJrnl/OnGetSalerComp")]
    Task<GenericResult<MizanUpPageAktarmaJrnlOnGetSalerCompResponse>> GetSalerCompAsync([Body] MizanUpPageAktarmaJrnlOnGetSalerCompQuery request, CancellationToken cancellationToken = default);
    
    [Post("/api/finance/mizan/jrnl/FinanceMizanJrnlUpPageAktarmaJrnl/OnGetGraphCode")]
    Task<GenericResult<MizanUpPageAktarmaJrnlOnGetGraphCodeResponse>> GetGraphCodeAsync([Body] MizanUpPageAktarmaJrnlOnGetGraphCodeQuery request, CancellationToken cancellationToken = default);
    
    [Post("/api/finance/mizan/jrnl/FinanceMizanJrnlUpPageAktarmaJrnl/OnGetGraphCodeDel")]
    Task<GenericResult<MizanUpPageAktarmaJrnlOnGetGraphCodeDelResponse>> GetGraphCodeDelAsync([Body] MizanUpPageAktarmaJrnlOnGetGraphCodeDelQuery request, CancellationToken cancellationToken = default);
}
