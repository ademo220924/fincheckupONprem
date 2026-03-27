using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.upbalancey;
public class upbalanceyOnGetSalerCompRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class upbalanceyOnGetSalerCompQuery
{
    public upbalanceyOnGetSalerCompRequest Request { get; set; }
}
