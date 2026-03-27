using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Upload;
public class UploadOnGetSalerDateRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class UploadOnGetSalerDateQuery
{
    public UploadOnGetSalerDateRequest Request { get; set; }
}
