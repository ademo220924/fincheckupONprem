using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashBoard;
public class DashBoardOnGetSheduleRequest
{
    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
    public int myear { get; set; }
}