using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.upbalancey;
public class upbalanceyOnGetSalerDateRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class upbalanceyOnGetSalerDateQuery
{
    public upbalanceyOnGetSalerDateRequest Request { get; set; }
}
