
namespace fincheckup.ApiClients.Models.Requests.DashRevenue;
public class DashRevenueOnGetGraphYearRequest
{
    public int nyear { get; set; }
}

public class DashRevenueOnGetGraphYearQuery
{
    public DashRevenueOnGetGraphYearRequest Request { get; set; }
}
