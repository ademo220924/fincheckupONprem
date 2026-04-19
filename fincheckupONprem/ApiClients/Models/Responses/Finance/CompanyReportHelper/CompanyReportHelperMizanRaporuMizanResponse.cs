using fincheckup.ApiClients.Models.ViewModel;
using fincheckup.ApiClients.Models.ViewModel.Reports;

namespace fincheckup.ApiClients.Models.Responses.Finance.CompanyReportHelper;

public class CompanyReportHelperMizanRaporuMizanResponse
{
    public string Header { get; set; }
    public ReportMizan MainReportText { get; set; }
    public List<ReportSet> Bilanco { get; set; }
    public List<DashMizanResult> MizanResult { get; set; }
    public List<DashDonukView> DonukChk { get; set; }
    public List<DashMizanResult> TicariAlici { get; set; }
    public List<DashMizanResult> TicariBorclu { get; set; }
}
