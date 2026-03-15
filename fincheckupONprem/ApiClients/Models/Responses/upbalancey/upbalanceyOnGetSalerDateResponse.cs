using fincheckup.ApiClients.Models.Requests.upbalancey;
using Microsoft.AspNetCore.Mvc;


namespace fincheckup.ApiClients.Models.Responses.upbalancey;
public class upbalanceyOnGetSalerDateResponse
{
    public JsonResult Result { get; set; }
    public upbalanceyRequest InitialModel { get; internal set; }
}