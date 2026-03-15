using fincheckup.ApiClients.Models.Requests.upcheck;
using Microsoft.AspNetCore.Mvc;


namespace fincheckup.ApiClients.Models.Responses.upcheck;
public class upcheckOnGetSalerDateResponse
{
    public JsonResult Result { get; set; }
    public upcheckRequest InitialModel { get; internal set; }
}