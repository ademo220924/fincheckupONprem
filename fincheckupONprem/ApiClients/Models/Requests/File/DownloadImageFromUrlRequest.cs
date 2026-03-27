namespace fincheckup.ApiClients.Models.Requests.File;

public class DownloadImageFromUrlRequest
{
    public string ImageUrl { get; set; }

    public class DownloadImageFromUrlQuery
    {
        public DownloadImageFromUrlRequest Request { get; set; }
    }
}
