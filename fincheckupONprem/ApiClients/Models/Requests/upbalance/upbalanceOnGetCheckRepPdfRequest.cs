
namespace fincheckup.ApiClients.Models.Requests.upbalance;
public class upbalanceOnGetCheckRepPdfRequest
{
    public long companyID { get; set; }
    public int nyear { get; set; }
}

public class upbalanceOnGetCheckRepPdfQuery
{
    public upbalanceOnGetCheckRepPdfRequest Request { get; set; }
}
