using DevExtreme.AspNet.Data.ResponseModel;
using fincheckup.ApiClients.Models.Requests.upbalance;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.upbalance;
public class upbalanceOnGetSalerDateResponse
{
    public LoadResult Result { get; set; }
    public upbalanceRequest InitialModel { get; internal set; }
}