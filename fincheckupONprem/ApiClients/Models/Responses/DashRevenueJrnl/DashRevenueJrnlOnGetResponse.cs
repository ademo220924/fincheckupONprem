
using fincheckup.ApiClients.Models.Requests.DashRevenueJrnl;

namespace fincheckup.ApiClients.Models.Responses.DashRevenueJrnl;
public class DashRevenueJrnlOnGetResponse
{
    public string Response { get; set; }
    public DashRevenueJrnlRequest InitialModel { get; set; }
}