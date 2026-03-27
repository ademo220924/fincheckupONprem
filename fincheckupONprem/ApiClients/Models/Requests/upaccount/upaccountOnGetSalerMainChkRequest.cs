using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.upaccount;
public class upaccountOnGetSalerMainChkRequest
{
    public DataSourceLoadOptions Options { get; set; }
    public int monthid { get; set; }
}