using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.dashbilancomlt;
public class dashbilancomltOnGetPrioRequest
{

    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
}

public class dashbilancomltOnGetPrioQuery
{
    public dashbilancomltOnGetPrioRequest Request { get; set; }
}
