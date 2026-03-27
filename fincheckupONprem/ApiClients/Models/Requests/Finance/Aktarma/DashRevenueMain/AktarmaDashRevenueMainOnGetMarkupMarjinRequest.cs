using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Aktarma.DashRevenueMain;

public class AktarmaDashRevenueMainOnGetMarkupMarjinRequest
{
    public DataSourceLoadOptions options { get; set; }
    public long compid { get; set; }
}

public class AktarmaDashRevenueMainOnGetMarkupMarjinQuery
{
    public AktarmaDashRevenueMainOnGetMarkupMarjinRequest Request { get; set; }
}
