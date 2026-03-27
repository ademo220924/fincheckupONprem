using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashBoard;
public class DashBoardOnGetPrioRequest
{
    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
}

public class DashBoardOnGetPrioQuery
{
    public DashBoardOnGetPrioRequest Request { get; set; }
}
