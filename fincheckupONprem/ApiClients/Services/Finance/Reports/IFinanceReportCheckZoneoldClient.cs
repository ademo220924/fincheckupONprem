using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.ReportCheckZoneold;
using fincheckup.ApiClients.Models.Responses.Finance.ReportZone;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance.Reports;

/// <summary>
/// Refit client for ReportCheckZoneold. Her public rapor metodu ayrı endpoint.
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceReportCheckZoneoldClient : IApiClientBase
{
    [Post("/api/finance/ReportCheckZoneold/GetReportMizanII")]
    Task<GenericResult<FinancialReportZonePayloadResponse>> GetReportMizanIIAsync(
        [Body] ReportCheckZoneoldStandardRequest request,
        CancellationToken cancellationToken = default);

    [Post("/api/finance/ReportCheckZoneold/GetReportMizanIII")]
    Task<GenericResult<FinancialReportZonePayloadResponse>> GetReportMizanIIIAsync(
        [Body] ReportCheckZoneoldStandardRequest request,
        CancellationToken cancellationToken = default);

    [Post("/api/finance/ReportCheckZoneold/GetReportMizanIV")]
    Task<GenericResult<FinancialReportZonePayloadResponse>> GetReportMizanIVAsync(
        [Body] ReportCheckZoneoldStandardRequest request,
        CancellationToken cancellationToken = default);

    [Post("/api/finance/ReportCheckZoneold/GetReportMII")]
    Task<GenericResult<FinancialReportZonePayloadResponse>> GetReportMIIAsync(
        [Body] ReportCheckZoneoldStandardRequest request,
        CancellationToken cancellationToken = default);

    [Post("/api/finance/ReportCheckZoneold/GetReportMIII")]
    Task<GenericResult<FinancialReportZonePayloadResponse>> GetReportMIIIAsync(
        [Body] ReportCheckZoneoldStandardRequest request,
        CancellationToken cancellationToken = default);

    [Post("/api/finance/ReportCheckZoneold/GetReportMIV")]
    Task<GenericResult<FinancialReportZonePayloadResponse>> GetReportMIVAsync(
        [Body] ReportCheckZoneoldStandardRequest request,
        CancellationToken cancellationToken = default);
}
