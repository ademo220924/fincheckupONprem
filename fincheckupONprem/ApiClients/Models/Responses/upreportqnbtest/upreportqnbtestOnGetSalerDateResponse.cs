using fincheckup.ApiClients.Models.Requests.upreportqnbtest;
using Microsoft.AspNetCore.Mvc;


namespace fincheckup.ApiClients.Models.Responses.upreportqnbtest;
public class upreportqnbtestOnGetSalerDateResponse
{
    public JsonResult Result { get; set; }
    public upreportqnbtestRequest InitialModel { get; internal set; }
}