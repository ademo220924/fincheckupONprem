using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Upload;
public class UploadGetSalerMainNoteRequest
{
    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
}

public class UploadGetSalerMainNoteQuery
{
    public UploadGetSalerMainNoteRequest Request { get; set; }
}
