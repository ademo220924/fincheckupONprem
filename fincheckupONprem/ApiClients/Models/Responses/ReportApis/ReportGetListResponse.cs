using fincheckup.ApiClients.Models.Aggregated;
using System.Collections.Generic;

namespace fincheckup.ApiClients.Models.Responses.ReportApis;

public class ReportGetListResponse
{
    public List<DataViewer> EntryData { get; set; }
}