using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.upbalance;
public class upbalanceOnGetSalerYearRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class upbalanceOnGetSalerYearQuery
{
    public upbalanceOnGetSalerYearRequest Request { get; set; }
}
