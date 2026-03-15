using fincheckup.ApiClients.Models.Requests.upaccounty;
using Microsoft.AspNetCore.Mvc;


namespace fincheckup.ApiClients.Models.Responses.upaccounty;
public class upaccountyOnGetSalerMainChkResponse
{
    public JsonResult Result { get; set; }
    public upaccountyRequest InitialModel { get; internal set; }
}