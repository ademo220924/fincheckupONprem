using DevExtreme.AspNet.Data.ResponseModel;
using fincheckup.ApiClients.Models.Requests.upaccounty;

namespace fincheckup.ApiClients.Models.Responses.upaccounty;
public class upaccountyOnGetSalerMainChkResponse
{
    public LoadResult Result { get; set; }
    public upaccountyRequest InitialModel { get; internal set; }
}