using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashBilanco;
public class DashBilancoOnGetSalerMainRequest
{
    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
}

public class DashBilancoOnGetSalerMainQuery
{
    public DashBilancoOnGetSalerMainRequest Request { get; set; }
}
