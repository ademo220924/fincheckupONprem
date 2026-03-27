
namespace fincheckup.ApiClients.Models.Requests.DashBoard;
public class DashBoardOnGetGraphCompRequest
{
    public int ncompid { get; set; }
}

public class DashBoardOnGetGraphCompQuery
{
    public DashBoardOnGetGraphCompRequest Request { get; set; }
}
