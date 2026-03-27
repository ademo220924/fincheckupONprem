using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Upload;
public class UploadOnGetSalerCompRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class UploadOnGetSalerCompQuery
{
    public UploadOnGetSalerCompRequest Request { get; set; }
}
