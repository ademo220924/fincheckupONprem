
namespace fincheckup.ApiClients.Models.Requests.upcheck;
public class upcheckOnGetCheckRepXlsRequest
{
    public long companyID { get; set; }
    public int nyear { get; set; }
    public int nmonth { get; set; }
}

public class upcheckOnGetCheckRepXlsQuery
{
    public upcheckOnGetCheckRepXlsRequest Request { get; set; }
}
