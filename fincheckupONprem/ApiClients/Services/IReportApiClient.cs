using fincheckup.ApiClients.Models.Requests.ReportApis;
using fincheckup.ApiClients.Models.Responses.ReportApis;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace fincheckup.ApiClients.Services;

/// <summary>
/// Refit client for ReportApiController. Source: src/FinanceCheckUp.Api/Controllers/v1/ReportApiController.cs
/// API version header: x-api-version: 1.0
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IReportApiClient : IApiClientBase
{
    [Post("/api/report/GetList")]
    Task<GenericResult<ReportGetListResponse>> GetListAsync([Body] ReportGetListRequest request, CancellationToken cancellationToken = default);
    [Put("/api/report")]
    Task<GenericResult<object>> PutOrderItemAsync([Body] ReportPutOrderItemRequest request, CancellationToken cancellationToken = default);
    [Get("/api/report/GetListOrderItem")]
    Task<GenericResult<GetListOrderItemResponse>> GetListOrderItemAsync([Query] GetListOrderItemRequest request, CancellationToken cancellationToken = default);
    [Get("/api/report/GetListItem")]
    Task<GenericResult<GetListItemResponse>> GetListItemAsync([Query] GetListItemRequest request, CancellationToken cancellationToken = default);
    [Get("/api/report/GetListDailyInOrderItem")]
    Task<GenericResult<GetListDailyInOrderItemResponse>> GetListDailyInOrderItemAsync([Query] GetListDailyInOrderItemRequest request, CancellationToken cancellationToken = default);
}
