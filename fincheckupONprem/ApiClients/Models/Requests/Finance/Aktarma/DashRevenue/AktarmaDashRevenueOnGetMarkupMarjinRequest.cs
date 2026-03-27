using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Aktarma.DashRevenue;
public class AktarmaDashRevenueOnGetMarkupMarjinRequest
{
    public DataSourceLoadOptions options { get; set; }
    public long compid { get; set; }
}

public class AktarmaDashRevenueOnGetMarkupMarjinQuery
{
    public AktarmaDashRevenueOnGetMarkupMarjinRequest Request { get; set; }
}
