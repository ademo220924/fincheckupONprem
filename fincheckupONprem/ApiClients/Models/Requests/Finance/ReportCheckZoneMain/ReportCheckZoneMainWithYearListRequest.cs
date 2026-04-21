using System.Collections.Generic;

namespace fincheckup.ApiClients.Models.Requests.Finance.ReportCheckZoneMain;

/// <summary>
/// getReport ve getReportFour ile aynı parametreler (ek: nyearList).
/// </summary>
public class ReportCheckZoneMainWithYearListRequest
{
    public long CompanyId { get; set; }
    public List<int> NyearList { get; set; }
    public string Nacceco { get; set; }
    public long UserId { get; set; }
    public List<int> NyearChkList { get; set; }
    public string Ncccode { get; set; }
}
