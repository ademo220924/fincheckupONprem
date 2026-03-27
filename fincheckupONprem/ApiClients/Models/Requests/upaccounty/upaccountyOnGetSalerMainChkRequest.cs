using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.upaccounty;
public class upaccountyOnGetSalerMainChkRequest
{
    public DataSourceLoadOptions Options { get; set; }
    public int monthid { get; set; }
}

public class upaccountyOnGetSalerMainChkQuery
{
    public upaccountyOnGetSalerMainChkRequest Request { get; set; }
}
