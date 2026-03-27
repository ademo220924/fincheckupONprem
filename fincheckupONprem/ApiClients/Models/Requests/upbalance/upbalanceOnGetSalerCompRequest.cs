using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.upbalance;
public class upbalanceOnGetSalerCompRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class upbalanceOnGetSalerCompQuery
{
    public upbalanceOnGetSalerCompRequest Request { get; set; }
}
