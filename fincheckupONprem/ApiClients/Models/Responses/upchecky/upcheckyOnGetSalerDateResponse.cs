using fincheckup.ApiClients.Models.Requests.upchecky;
using Microsoft.AspNetCore.Mvc;


namespace fincheckup.ApiClients.Models.Responses.upchecky;
public class upcheckyOnGetSalerDateResponse
{
    public JsonResult Result { get; set; }
    public upcheckyRequest InitialModel { get; internal set; }
}