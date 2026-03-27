using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.dashbilancomlt;
public class dashbilancomltOnGetMarkupMarjinRequest
{

    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
    public string myear { get; set; }
    public long compid { get; set; }
}

public class dashbilancomltOnGetMarkupMarjinQuery
{
    public dashbilancomltOnGetMarkupMarjinRequest Request { get; set; }
}
