namespace fincheckup.ApiClients.Models.Requests.Finance.ComReport;

/// <summary>
/// Getreport(int nyear, Company comp) — şirket kimliği ve rapor yılı.
/// </summary>
public class ComReportGetreportRequest
{
    public int Year { get; set; }
    public long CompanyId { get; set; }
    public string CompanyName { get; set; }
    public string NaceCode { get; set; }
}
