
namespace fincheckup.ApiClients.Models.Requests.DashCrm;
public class DashCrmOnGetGraphCompRequest
{
    public int ncompid { get; set; }
}

public class DashCrmOnGetGraphCompQuery
{
    public DashCrmOnGetGraphCompRequest Request { get; set; }
}
