using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Upload;
public class UploadOnGetSalerMainChkRequest
{
    public DataSourceLoadOptions Options { get; set; }
    public int monthid { get; set; }
}