using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.upcmconsole;
public class upcmconsoleOnGetSalerCompRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class upcmconsoleOnGetSalerCompQuery
{
    public upcmconsoleOnGetSalerCompRequest Request { get; set; }
}
