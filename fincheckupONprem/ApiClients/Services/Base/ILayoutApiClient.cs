using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models;
using fincheckup.ApiClients.Models.Requests.Layouts;
using fincheckup.ApiClients.Models.Responses.Layouts;
using Refit;

namespace fincheckup.ApiClients.Services.Base
{
   public interface ILayoutApiClient : IApiClientBase
    {
        [Post("/api/layouts/layout")]
        Task<GenericResult<LayoutResponse>> LayoutAsync([Body] LayoutRequest request, CancellationToken cancellationToken = default);

        [Post("/api/layouts/layout-byn")]
        Task<GenericResult<LayoutBynResponse>> LayoutBynAsync([Body] LayoutBynRequest request, CancellationToken cancellationToken = default);

        [Post("/api/layouts/layout-consult")]
        Task<GenericResult<LayoutConsultResponse>> LayoutConsultAsync([Body] LayoutConsultRequest request, CancellationToken cancellationToken = default);

        [Post("/api/layouts/layout-finance")]
        Task<GenericResult<LayoutFinanceResponse>> LayoutFinanceAsync([Body] LayoutFinanceRequest request, CancellationToken cancellationToken = default);

        [Post("/api/layouts/layout-finance-mizan")]
        Task<GenericResult<LayoutFinanceMizanResponse>> LayoutFinanceMizanAsync([Body] LayoutFinanceMizanRequest request, CancellationToken cancellationToken = default);

        [Post("/api/layouts/layout-firma")]
        Task<GenericResult<LayoutFirmaResponse>> LayoutFirmaAsync([Body] LayoutFirmaRequest request, CancellationToken cancellationToken = default);

        [Post("/api/layouts/layout-main")]
        Task<GenericResult<LayoutMainResponse>> LayoutMainAsync([Body] LayoutMainRequest request, CancellationToken cancellationToken = default);

        [Post("/api/layouts/layout-mizan")]
        Task<GenericResult<LayoutMizanResponse>> LayoutMizanAsync([Body] LayoutMizanRequest request, CancellationToken cancellationToken = default);

        [Post("/api/layouts/layout-qnb")]
        Task<GenericResult<LayoutQnbResponse>> LayoutQnbAsync([Body] LayoutQnbRequest request, CancellationToken cancellationToken = default);

        [Post("/api/layouts/layout-qnb-main")]
        Task<GenericResult<LayoutQnbMainResponse>> LayoutQnbMainAsync([Body] LayoutQnbMainRequest request, CancellationToken cancellationToken = default);

        [Post("/api/layouts/layout-report")]
        Task<GenericResult<LayoutReportResponse>> LayoutReportAsync([Body] LayoutReportRequest request, CancellationToken cancellationToken = default);
    }
}