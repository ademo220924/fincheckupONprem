using System.Collections.Generic;

namespace fincheckup.ApiClients.Models.Requests.Finance.ReportCheckZoneold;

/// <summary>
/// getReportMizanII, getReportMizanIII, getReportMizanIV, getReportMII, getReportMIII, getReportMIV ile aynı parametreler.
/// </summary>
public class ReportCheckZoneoldStandardRequest
{
    public long CompanyId { get; set; }
    public string Nacceco { get; set; }
    public long UserId { get; set; }
    public List<int> NyearChkList { get; set; }
    public string Ncccode { get; set; }
}
