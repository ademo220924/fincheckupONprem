using DevExtreme.AspNet.Data.ResponseModel;
using fincheckup.ApiClients.Models.Requests.upaccounty;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.upaccounty;
public class upaccountyOnGetSalerDateResponse
{
    public LoadResult Result { get; set; }
    public upaccountyRequest InitialModel { get; set; }
}