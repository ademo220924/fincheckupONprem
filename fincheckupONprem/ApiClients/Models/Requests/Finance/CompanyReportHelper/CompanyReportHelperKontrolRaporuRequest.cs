using fincheckup.ApiClients.Models.Aggregated;

namespace fincheckup.ApiClients.Models.Requests.Finance.CompanyReportHelper;

public class CompanyReportHelperKontrolRaporuRequest
{
    public int Year { get; set; }
    public long CompanyId { get; set; }
    public int MonthId { get; set; }
    public List<DataViewer> Ncheck { get; set; }
}
