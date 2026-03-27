using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.upchecky;
public class upcheckyOnGetSalerYearRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class upcheckyOnGetSalerYearQuery
{
    public upcheckyOnGetSalerYearRequest Request { get; set; }
}
