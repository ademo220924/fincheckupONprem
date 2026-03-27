using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.dashbilancorvnmlt;
public class dashbilancorvnmltOnGetSalerMainRequest
{
    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
    public string dt1 { get; set; }
}

public class dashbilancorvnmltOnGetSalerMainQuery
{
    public dashbilancorvnmltOnGetSalerMainRequest Request { get; set; }
}
