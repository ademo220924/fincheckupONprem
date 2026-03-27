using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.upaccounty;
public class upaccountyOnGetSalerMainZetaRequest
{
    public DataSourceLoadOptions Options { get; set; }
    public int monthid { get; set; }
}

public class upaccountyOnGetSalerMainZetaQuery
{
    public upaccountyOnGetSalerMainZetaRequest Request { get; set; }
}
