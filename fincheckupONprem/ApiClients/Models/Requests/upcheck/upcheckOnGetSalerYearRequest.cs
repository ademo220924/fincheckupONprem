using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.upcheck;
public class upcheckOnGetSalerYearRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class upcheckOnGetSalerYearQuery
{
    public upcheckOnGetSalerYearRequest Request { get; set; }
}
