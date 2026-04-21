using System.Collections.Generic;

namespace fincheckup.ApiClients.Models.Requests.Finance.ReportCheckZoneMain;

/// <summary>
/// getReportMizanFour ve getReportMizan ile aynı parametreler.
/// </summary>
public class ReportCheckZoneMainStandardRequest
{
    public long CompanyId { get; set; }
    public string Nacceco { get; set; }
    public long UserId { get; set; }
    public List<int> NyearChkList { get; set; }
    public string Ncccode { get; set; }
}
