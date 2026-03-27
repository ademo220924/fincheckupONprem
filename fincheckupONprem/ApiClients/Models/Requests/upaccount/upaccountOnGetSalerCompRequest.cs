using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.upaccount;
public class upaccountOnGetSalerCompRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class upaccountOnGetSalerCompQuery
{
    public upaccountOnGetSalerCompRequest Request { get; set; }
}
