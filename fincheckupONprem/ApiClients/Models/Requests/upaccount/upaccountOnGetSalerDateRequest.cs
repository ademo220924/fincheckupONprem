using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.upaccount;
public class upaccountOnGetSalerDateRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class upaccountOnGetSalerDateQuery
{
    public upaccountOnGetSalerDateRequest Request { get; set; }
}
