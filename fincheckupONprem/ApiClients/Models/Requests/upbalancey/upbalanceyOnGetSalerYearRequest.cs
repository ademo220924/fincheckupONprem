using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.upbalancey;
public class upbalanceyOnGetSalerYearRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class upbalanceyOnGetSalerYearQuery
{
    public upbalanceyOnGetSalerYearRequest Request { get; set; }
}
