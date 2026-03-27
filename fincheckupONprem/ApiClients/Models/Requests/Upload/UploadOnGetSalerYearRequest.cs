using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Upload;
public class UploadOnGetSalerYearRequest
{
    public DataSourceLoadOptions Options { get; set; }
}

public class UploadOnGetSalerYearQuery
{
    public UploadOnGetSalerYearRequest Request { get; set; }
}
