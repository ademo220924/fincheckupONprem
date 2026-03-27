using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.upcheck;
public class upcheckOnGetSalerDateRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class upcheckOnGetSalerDateQuery
{
    public upcheckOnGetSalerDateRequest Request { get; set; }
}
