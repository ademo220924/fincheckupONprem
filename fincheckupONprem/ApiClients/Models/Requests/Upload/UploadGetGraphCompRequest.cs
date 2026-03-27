using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Upload;
public class UploadGetGraphCompRequest
{
    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
}

public class UploadGetGraphCompQuery
{
    public UploadGetGraphCompRequest Request { get; set; }
}
