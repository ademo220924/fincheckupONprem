using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.dashbilancojrnl;
public class dashbilancojrnlOnGetPrioRequest
{

    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
}

public class dashbilancojrnlOnGetPrioQuery
{
    public dashbilancojrnlOnGetPrioRequest Request { get; set; }
}
