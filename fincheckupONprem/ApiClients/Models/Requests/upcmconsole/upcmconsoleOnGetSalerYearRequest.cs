using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.upcmconsole;
public class upcmconsoleOnGetSalerYearRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class upcmconsoleOnGetSalerYearQuery
{
    public upcmconsoleOnGetSalerYearRequest Request { get; set; }
}
