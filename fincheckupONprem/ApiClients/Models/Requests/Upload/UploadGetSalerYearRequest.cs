using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Upload;
public class UploadGetSalerYearRequest
{
    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
}

public class UploadGetSalerYearQuery
{
    public UploadGetSalerYearRequest Request { get; set; }
}
