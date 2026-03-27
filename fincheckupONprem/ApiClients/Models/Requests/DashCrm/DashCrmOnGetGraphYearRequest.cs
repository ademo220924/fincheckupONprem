
namespace fincheckup.ApiClients.Models.Requests.DashCrm;
public class DashCrmOnGetGraphYearRequest
{
    public int nyear { get; set; }
}

public class DashCrmOnGetGraphYearQuery
{
    public DashCrmOnGetGraphYearRequest Request { get; set; }
}
