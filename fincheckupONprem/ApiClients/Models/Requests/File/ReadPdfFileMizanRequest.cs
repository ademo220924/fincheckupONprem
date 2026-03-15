namespace fincheckup.ApiClients.Models.Requests.File;

public class ReadPdfFileMizanRequest
{
    public long compid { get; set; }
    public int nyear { get; set; }
    public byte nmonth { get; set; }
}
