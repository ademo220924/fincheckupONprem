using System.Collections.Generic;
using fincheckup.ApiClients.Models.ViewModel;

namespace fincheckup.ApiClients.Models.Responses.FileOperation;
public class ReadPdfFileMizanQueryResponse
{
    public List<ReadPdfMizan> ReadPdfMizans { get; set; }
}