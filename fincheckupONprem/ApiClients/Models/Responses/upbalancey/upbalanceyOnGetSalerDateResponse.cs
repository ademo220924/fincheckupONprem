using DevExtreme.AspNet.Data.ResponseModel;
using fincheckup.ApiClients.Models.Requests.upbalancey;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.upbalancey;
public class upbalanceyOnGetSalerDateResponse
{
    public LoadResult Result { get; set; }
    public upbalanceyRequest InitialModel { get; internal set; }
}