using DevExtreme.AspNet.Data.ResponseModel;
using fincheckup.ApiClients.Models.Requests.upaccount;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.upaccount;
public class upaccountOnGetSalerMainZetaResponse
{
    public LoadResult Result { get; set; }
    public upaccountRequest InitialModel { get; set; }
}