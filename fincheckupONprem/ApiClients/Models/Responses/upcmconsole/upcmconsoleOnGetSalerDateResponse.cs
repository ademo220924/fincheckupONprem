using fincheckup.ApiClients.Models.Requests.upcmconsole;
using Microsoft.AspNetCore.Mvc;


namespace fincheckup.ApiClients.Models.Responses.upcmconsole;
public class upcmconsoleOnGetSalerDateResponse
{
    public JsonResult Result { get; set; }
    public upcmconsoleRequest InitialModel { get; internal set; }
}