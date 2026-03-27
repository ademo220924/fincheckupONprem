
namespace fincheckup.ApiClients.Models.Requests.upaccount;
public class upaccountOnGetCheckRepPdfRequest
{
    public long companyID { get; set; }
    public int nyear { get; set; }
    public int nmonth { get; set; }
}

public class upaccountOnGetCheckRepPdfQuery
{
    public upaccountOnGetCheckRepPdfRequest Request { get; set; }
}
