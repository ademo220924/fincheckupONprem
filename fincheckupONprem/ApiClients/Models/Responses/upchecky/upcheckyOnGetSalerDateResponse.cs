using DevExtreme.AspNet.Data.ResponseModel;
using fincheckup.ApiClients.Models.Requests.upchecky;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.upchecky;
public class upcheckyOnGetSalerDateResponse
{
    public LoadResult Result { get; set; }
    public upcheckyRequest InitialModel { get; internal set; }
}