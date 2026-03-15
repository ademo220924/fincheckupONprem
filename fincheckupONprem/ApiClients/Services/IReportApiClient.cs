using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using fincheckup.ApiClients.Services.Base;
using fincheckup.ApiClients.Models.Requests.ReportApis;
using fincheckup.ApiClients.Models.Responses.ReportApis;
using fincheckup.ApiClients.Models;

namespace fincheckup.ApiClients.Services;

public interface IReportApiClient : IApiClientBase
{
    [Post("/api/report/GetList")]
    Task<GenericResult<ReportGetListResponse>> GetListAsync(
        [Body] ReportGetListRequest request,
        CancellationToken cancellationToken);

    [Put("/api/report")]
    Task<GenericResult<ReportPutOrderItemResponse>> PutOrderItemAsync(
        [Body] ReportPutOrderItemRequest request,
        CancellationToken cancellationToken);

    [Get("/api/report/GetListOrderItem")]
    Task<GenericResult<List<GetListOrderItemResponse>>> GetListOrderItemAsync(
        [Query] GetListOrderItemRequest request,
        CancellationToken cancellationToken);

    [Get("/api/report/GetListItem")]
    Task<GenericResult<List<GetListItemResponse>>> GetListItemAsync(
        [Query] GetListItemRequest request,
        CancellationToken cancellationToken);

    [Get("/api/report/GetListDailyInOrderItem")]
    Task<GenericResult<List<GetListDailyInOrderItemResponse>>> GetListDailyInOrderItemAsync(
        [Query] GetListDailyInOrderItemRequest request,
        CancellationToken cancellationToken);
}