using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.ReportCheckZoneMain;
using fincheckup.ApiClients.Models.Responses.Finance.ReportZone;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance.Reports;

/// <summary>
/// Refit client for ReportCheckZoneMain. Her public rapor metodu ayrı endpoint.
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceReportCheckZoneMainClient : IApiClientBase
{
    [Post("/api/finance/ReportCheckZoneMain/GetReportMizanFour")]
    Task<GenericResult<FinancialReportZonePayloadResponse>> GetReportMizanFourAsync(
        [Body] ReportCheckZoneMainStandardRequest request,
        CancellationToken cancellationToken = default);

    [Post("/api/finance/ReportCheckZoneMain/GetReportMizan")]
    Task<GenericResult<FinancialReportZonePayloadResponse>> GetReportMizanAsync(
        [Body] ReportCheckZoneMainStandardRequest request,
        CancellationToken cancellationToken = default);

    [Post("/api/finance/ReportCheckZoneMain/GetReport")]
    Task<GenericResult<FinancialReportZonePayloadResponse>> GetReportAsync(
        [Body] ReportCheckZoneMainWithYearListRequest request,
        CancellationToken cancellationToken = default);

    [Post("/api/finance/ReportCheckZoneMain/GetReportFour")]
    Task<GenericResult<FinancialReportZonePayloadResponse>> GetReportFourAsync(
        [Body] ReportCheckZoneMainWithYearListRequest request,
        CancellationToken cancellationToken = default);
}
