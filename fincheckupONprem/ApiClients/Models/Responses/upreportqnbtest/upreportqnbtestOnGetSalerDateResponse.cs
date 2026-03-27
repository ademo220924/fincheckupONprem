using DevExtreme.AspNet.Data.ResponseModel;
using fincheckup.ApiClients.Models.Requests.upreportqnbtest;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Responses.upreportqnbtest;
public class upreportqnbtestOnGetSalerDateResponse
{
    public LoadResult Result { get; set; }
    public upreportqnbtestRequest InitialModel { get; internal set; }
}