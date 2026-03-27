using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Upload;
public class UploadGetSalerDateRequest
{
    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
}

public class UploadGetSalerDateQuery
{
    public UploadGetSalerDateRequest Request { get; set; }
}
