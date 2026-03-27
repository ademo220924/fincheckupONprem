
namespace fincheckup.ApiClients.Models.Requests.upcheck;
public class upcheckOnGetCheckRepPdfRequest
{
    public long companyID { get; set; }
    public int nyear { get; set; }
    public int nmonth { get; set; }
}

public class upcheckOnGetCheckRepPdfQuery
{
    public upcheckOnGetCheckRepPdfRequest Request { get; set; }
}
