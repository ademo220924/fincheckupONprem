using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Upload;
public class UploadGetGraphYearRequest
{
    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
}

public class UploadGetGraphYearQuery
{
    public UploadGetGraphYearRequest Request { get; set; }
}
