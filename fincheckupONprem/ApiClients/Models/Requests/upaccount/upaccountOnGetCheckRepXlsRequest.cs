
namespace fincheckup.ApiClients.Models.Requests.upaccount;
public class upaccountOnGetCheckRepXlsRequest
{
    public long companyID { get; set; }
    public int nyear { get; set; }
    public int nmonth { get; set; }
}

public class upaccountOnGetCheckRepXlsQuery
{
    public upaccountOnGetCheckRepXlsRequest Request { get; set; }
}
