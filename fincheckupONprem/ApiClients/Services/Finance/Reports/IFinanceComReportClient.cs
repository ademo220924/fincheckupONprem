using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.ComReport;
using fincheckup.ApiClients.Models.Responses.Finance.ReportZone;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance.Reports;

/// <summary>
/// Refit client for ComReport.
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceComReportClient : IApiClientBase
{
    [Post("/api/finance/ComReport/Getreport")]
    Task<GenericResult<FinancialReportZonePayloadResponse>> GetreportAsync(
        [Body] ComReportGetreportRequest request,
        CancellationToken cancellationToken = default);
}
