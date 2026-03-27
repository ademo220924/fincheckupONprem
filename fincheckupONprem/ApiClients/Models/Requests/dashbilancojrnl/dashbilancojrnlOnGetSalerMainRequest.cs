using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.dashbilancojrnl;
public class dashbilancojrnlOnGetSalerMainRequest
{
    public DataSourceLoadOptions Options { get; set; }
    public string dt1 { get; set; }
}

public class dashbilancojrnlOnGetSalerMainQuery
{
    public dashbilancojrnlOnGetSalerMainRequest Request { get; set; }
}
