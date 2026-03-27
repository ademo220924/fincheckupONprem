using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.upcmconsole;
public class upcmconsoleOnGetSalerDateRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class upcmconsoleOnGetSalerDateQuery
{
    public upcmconsoleOnGetSalerDateRequest Request { get; set; }
}
