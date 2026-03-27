using DevExtreme.AspNet.Data.ResponseModel;
using fincheckup.ApiClients.Models.Requests.upreportmainy;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.upreportmainy;
public class upreportmainyOnGetSalerDateResponse
{
    public LoadResult Result { get; set; }
    public upreportmainyRequest InitialModel { get; set; }
}