using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.upchecky;
public class upcheckyOnGetSalerCompRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class upcheckyOnGetSalerCompQuery
{
    public upcheckyOnGetSalerCompRequest Request { get; set; }
}
