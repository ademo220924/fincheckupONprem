using System.Threading;
using System.Threading.Tasks;
using fincheckup.ApiClients.Models.Requests.Finance.CompanyReportHelper;
using fincheckup.ApiClients.Models.Responses.Finance.CompanyReportHelper;
using fincheckup.ApiClients.Services.Base;
using Refit;

namespace fincheckup.ApiClients.Services.Finance.Reports;

/// <summary>
/// Refit client for CompanyReportHelper. Backend: FinanceCheckUp.Api — CompanyReportHelperController (veya eşdeğeri).
/// Her static metot ayrı endpoint; yanıtlar raporu yerelde DevExpress ile üretmek için gerekli veriyi taşır.
/// </summary>
[Headers("x-api-version: 1.0")]
public interface IFinanceCompanyReportHelperClient : IApiClientBase
{
    [Post("/api/finance/CompanyReportHelper/GetKontrolRaporu")]
    Task<GenericResult<CompanyReportHelperKontrolRaporuResponse>> GetKontrolRaporuAsync(
        [Body] CompanyReportHelperKontrolRaporuRequest request,
        CancellationToken cancellationToken = default);

    [Post("/api/finance/CompanyReportHelper/GetDenetimRaporu")]
    Task<GenericResult<CompanyReportHelperDenetimRaporuResponse>> GetDenetimRaporuAsync(
        [Body] CompanyReportHelperDenetimRaporuRequest request,
        CancellationToken cancellationToken = default);

    [Post("/api/finance/CompanyReportHelper/GetMizanRaporu")]
    Task<GenericResult<CompanyReportHelperMizanRaporuResponse>> GetMizanRaporuAsync(
        [Body] CompanyReportHelperMizanRaporuRequest request,
        CancellationToken cancellationToken = default);

    [Post("/api/finance/CompanyReportHelper/GetMizanRaporuMizan")]
    Task<GenericResult<CompanyReportHelperMizanRaporuMizanResponse>> GetMizanRaporuMizanAsync(
        [Body] CompanyReportHelperMizanRaporuMizanRequest request,
        CancellationToken cancellationToken = default);

    [Post("/api/finance/CompanyReportHelper/GetMizanRaporuMizanAkt")]
    Task<GenericResult<CompanyReportHelperMizanRaporuMizanAktResponse>> GetMizanRaporuMizanAktAsync(
        [Body] CompanyReportHelperMizanRaporuMizanAktRequest request,
        CancellationToken cancellationToken = default);
}
