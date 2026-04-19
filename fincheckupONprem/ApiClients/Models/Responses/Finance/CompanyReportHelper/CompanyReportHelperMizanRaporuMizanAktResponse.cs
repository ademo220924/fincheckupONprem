using fincheckup.ApiClients.Models.ViewModel.Reports;

namespace fincheckup.ApiClients.Models.Responses.Finance.CompanyReportHelper;

public class CompanyReportHelperMizanRaporuMizanAktResponse
{
    public string Header { get; set; }
    public List<ReportSet> BilancoAktarma { get; set; }
}
