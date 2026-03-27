using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Upload;
public class UploadGetSalerMainChkRequest
{
    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
}

public class UploadGetSalerMainChkQuery
{
    public UploadGetSalerMainChkRequest Request { get; set; }
}
