using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.dashbilancojrnl;
public class dashbilancojrnlOnGetMarkupMarjinRequest
{
    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
    public long compid { get; set; }
}

public class dashbilancojrnlOnGetMarkupMarjinQuery
{
    public dashbilancojrnlOnGetMarkupMarjinRequest Request { get; set; }
}
