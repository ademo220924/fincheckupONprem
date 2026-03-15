using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace fincheckup.ApiClients.Models.Aggregated;

public class XMlook
{
    public int id { get; set; }
    public string ide { get; set; }
    public string idexml { get; set; }
    public List<IFormFile> file { get; set; } = [];
    public string Caption { get; set; }
}