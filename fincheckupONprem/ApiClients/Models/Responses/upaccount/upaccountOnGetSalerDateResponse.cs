using fincheckup.ApiClients.Models.Requests.upaccount;
using Microsoft.AspNetCore.Mvc;


namespace fincheckup.ApiClients.Models.Responses.upaccount;
public class upaccountOnGetSalerDateResponse
{
    public JsonResult Result { get; set; }
    public upaccountRequest InitialModel { get; set; }
}