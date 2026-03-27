using DevExtreme.AspNet.Data.ResponseModel;
using fincheckup.ApiClients.Models.Requests.upcheck;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.upcheck;
public class upcheckOnGetSalerDateResponse
{
    public LoadResult Result { get; set; }
    public upcheckRequest InitialModel { get; internal set; }
}