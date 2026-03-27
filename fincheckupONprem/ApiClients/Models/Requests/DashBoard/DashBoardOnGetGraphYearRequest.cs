
namespace fincheckup.ApiClients.Models.Requests.DashBoard;
public class DashBoardOnGetGraphYearRequest
{
    public int nyear { get; set; }
}

public class DashBoardOnGetGraphYearQuery
{
    public DashBoardOnGetGraphYearRequest Request { get; set; }
}
