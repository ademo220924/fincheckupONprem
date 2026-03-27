using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.upaccounty;
public class upaccountyOnGetSalerCompRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class upaccountyOnGetSalerCompQuery
{
    public upaccountyOnGetSalerCompRequest Request { get; set; }
}
