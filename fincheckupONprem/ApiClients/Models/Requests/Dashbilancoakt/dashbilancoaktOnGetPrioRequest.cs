using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.dashbilancoakt;
public class dashbilancoaktOnGetPrioRequest
{
    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
}

public class dashbilancoaktOnGetPrioQuery
{
    public dashbilancoaktOnGetPrioRequest Request { get; set; }
}
