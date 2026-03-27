
namespace fincheckup.ApiClients.Models.Requests.Upload;
public class UploadOnGetGraphCompRequest
{
    public int ncompid { get; set; }
}

public class UploadOnGetGraphCompQuery
{
    public UploadOnGetGraphCompRequest Request { get; set; }
}
