using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashBoard;
public class DashBoardOnGetGraphZetRequest
{
    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
    public int myear { get; set; }
    public long compid { get; set; }
}

public class DashBoardOnGetGraphZetQuery
{
    public DashBoardOnGetGraphZetRequest Request { get; set; }
}
