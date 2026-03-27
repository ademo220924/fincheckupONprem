namespace fincheckup.ApiClients.Models.Requests.Mizan;

public class MoodUploadMznRequest
{
    public object File { get; set; }
    public long Id { get; set; }
    public long Ide { get; set; }
    public long Idexml { get; set; }
    public string Caption { get; set; }
}

public class MoodUploadMznQuery
{
    public MoodUploadMznRequest Request { get; set; }
}
