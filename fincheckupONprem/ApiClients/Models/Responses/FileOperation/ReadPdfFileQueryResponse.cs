using System.Collections.Generic;
using fincheckup.ApiClients.Models.ViewModel;

namespace fincheckup.ApiClients.Models.Responses.FileOperation;
public class ReadPdfFileQueryResponse
{
    public List<ReadPdfPg> ReadPdfPgs { get; set; }
}