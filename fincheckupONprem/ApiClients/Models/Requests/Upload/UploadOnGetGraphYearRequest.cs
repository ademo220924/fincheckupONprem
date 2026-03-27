
namespace fincheckup.ApiClients.Models.Requests.Upload;
public class UploadOnGetGraphYearRequest
{
    public int nyear { get; set; }
}

public class UploadOnGetGraphYearQuery
{
    public UploadOnGetGraphYearRequest Request { get; set; }
}
