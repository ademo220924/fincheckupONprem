using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.upchecky;
public class upcheckyOnGetSalerDateRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class upcheckyOnGetSalerDateQuery
{
    public upcheckyOnGetSalerDateRequest Request { get; set; }
}
