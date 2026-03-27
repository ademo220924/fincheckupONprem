
namespace fincheckup.ApiClients.Models.Requests.upbalance;
public class upbalanceOnGetCheckRepXlsRequest
{
    public long companyID { get; set; }
    public int nyear { get; set; }
}

public class upbalanceOnGetCheckRepXlsQuery
{
    public upbalanceOnGetCheckRepXlsRequest Request { get; set; }
}
