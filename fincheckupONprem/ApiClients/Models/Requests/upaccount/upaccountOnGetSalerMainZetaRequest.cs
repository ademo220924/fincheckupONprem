using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.upaccount;
public class upaccountOnGetSalerMainZetaRequest
{
    public DataSourceLoadOptions Options { get; set; }
    public int monthid { get; set; }
}

public class upaccountOnGetSalerMainZetaQuery
{
    public upaccountOnGetSalerMainZetaRequest Request { get; set; }
}
