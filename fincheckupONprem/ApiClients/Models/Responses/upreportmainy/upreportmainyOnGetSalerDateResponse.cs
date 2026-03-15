using fincheckup.ApiClients.Models.Requests.upreportmainy;
using Microsoft.AspNetCore.Mvc;


namespace fincheckup.ApiClients.Models.Responses.upreportmainy;
public class upreportmainyOnGetSalerDateResponse
{
    public JsonResult Result { get; set; }
    public upreportmainyRequest InitialModel { get; set; }
}