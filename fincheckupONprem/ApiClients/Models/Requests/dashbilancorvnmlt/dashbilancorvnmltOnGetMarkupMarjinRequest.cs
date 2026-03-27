using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.dashbilancorvnmlt;
public class dashbilancorvnmltOnGetMarkupMarjinRequest
{
    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
    public string myear { get; set; }
    public long compid { get; set; }
}

public class dashbilancorvnmltOnGetMarkupMarjinQuery
{
    public dashbilancorvnmltOnGetMarkupMarjinRequest Request { get; set; }
}
