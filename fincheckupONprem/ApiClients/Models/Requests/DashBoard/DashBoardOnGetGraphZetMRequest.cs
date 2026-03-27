
namespace fincheckup.ApiClients.Models.Requests.DashBoard;
public class DashBoardOnGetGraphZetMRequest
{
    public int myear { get; set; }
    public long compid { get; set; }
}

public class DashBoardOnGetGraphZetMQuery
{
    public DashBoardOnGetGraphZetMRequest Request { get; set; }
}
