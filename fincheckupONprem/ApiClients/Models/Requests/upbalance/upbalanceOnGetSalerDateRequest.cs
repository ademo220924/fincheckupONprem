using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.upbalance;
public class upbalanceOnGetSalerDateRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class upbalanceOnGetSalerDateQuery
{
    public upbalanceOnGetSalerDateRequest Request { get; set; }
}
