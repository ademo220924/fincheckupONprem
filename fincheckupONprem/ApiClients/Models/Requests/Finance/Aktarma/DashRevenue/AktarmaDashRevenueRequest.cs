
namespace fincheckup.ApiClients.Models.Requests.Finance.Aktarma.DashRevenue;
public class AktarmaDashRevenueRequest
{
    public int Year { get; set; }
}

public class AktarmaDashRevenueQuery
{
    public AktarmaDashRevenueRequest Request { get; set; }
}
