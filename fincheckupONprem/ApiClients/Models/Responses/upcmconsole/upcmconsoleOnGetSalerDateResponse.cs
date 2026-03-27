using DevExtreme.AspNet.Data.ResponseModel;
using fincheckup.ApiClients.Models.Requests.upcmconsole;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.upcmconsole;
public class upcmconsoleOnGetSalerDateResponse
{
    public LoadResult Result { get; set; }
    public upcmconsoleRequest InitialModel { get; internal set; }
}