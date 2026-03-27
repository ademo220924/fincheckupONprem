using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.dashbilancorvnakt;
public class dashbilancorvnaktOnGetSalerMainRequest
{
    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
    public string dt1 { get; set; }
}

public class dashbilancorvnaktOnGetSalerMainQuery
{
    public dashbilancorvnaktOnGetSalerMainRequest Request { get; set; }
}
