using fincheckup.ApiClients.Models.Requests.upreportqnb;
using Microsoft.AspNetCore.Mvc;


namespace fincheckup.ApiClients.Models.Responses.upreportqnb;
public class upreportqnbOnGetSalerDateResponse
{
    public upreportqnbRequest InitialModel { get; set; }
    public JsonResult Result { get; internal set; }
}