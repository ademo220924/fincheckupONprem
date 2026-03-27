using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for UpAccountController. Source: src/FinanceCheckUp.Api/Controllers/v1/upaccountController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IUpAccountClient : IApiClientBase
{
    [Post("/api/upaccount")]
    Task<GenericResult<upaccountOnGetResponse>> GetAsync([Body] UpaccountOnGetRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upaccount/saler-main-chk")]
    Task<GenericResult<upaccountOnGetSalerMainChkResponse>> GetSalerMainChkAsync([Body] upaccountOnGetSalerMainChkRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upaccount/saler-main-zeta")]
    Task<GenericResult<upaccountOnGetSalerMainZetaResponse>> GetSalerMainZetaAsync([Body] upaccountOnGetSalerMainZetaRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upaccount/saler-date")]
    Task<GenericResult<upaccountOnGetSalerDateResponse>> GetSalerDateAsync([Body] upaccountOnGetSalerDateRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upaccount/saler-year")]
    Task<GenericResult<upaccountOnGetSalerYearResponse>> GetSalerYearAsync([Body] upaccountOnGetSalerYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upaccount/saler-comp")]
    Task<GenericResult<upaccountOnGetSalerCompResponse>> GetSalerCompAsync([Body] upaccountOnGetSalerCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upaccount/graph-comp")]
    Task<GenericResult<upaccountOnGetGraphCompResponse>> GetGraphCompAsync([Body] upaccountOnGetGraphCompRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upaccount/graph-year")]
    Task<GenericResult<upaccountOnGetGraphYearResponse>> GetGraphYearAsync([Body] upaccountOnGetGraphYearRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upaccount/check-rep-pdf")]
    Task<GenericResult<upaccountOnGetCheckRepPdfResponse>> GetCheckRepPdfAsync([Body] upaccountOnGetCheckRepPdfRequest request, CancellationToken cancellationToken = default);
    [Post("/api/upaccount/check-rep-xls")]
    Task<GenericResult<upaccountOnGetCheckRepXlsResponse>> GetCheckRepXlsAsync([Body] upaccountOnGetCheckRepXlsRequest request, CancellationToken cancellationToken = default);
}
