using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace fincheckup.ApiClients.Models.Requests.Mizan;

public class MoodUploadMznCkeckRequest
{
    public List<IFormFile> File { get; set; }
    public long Id { get; set; }
    public long Ide { get; set; }
    public long Idexml { get; set; }
    public string Caption { get; set; }
}

public class MoodUploadMznCkeckQuery
{
    public MoodUploadMznCkeckRequest Request { get; set; }
}
