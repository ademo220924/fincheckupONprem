using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Daily;

public class DailyPrioritytRequest
{
    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
}

public class DailyPrioritytQuery
{
    public DailyPrioritytRequest Request { get; set; }
}
