
namespace fincheckup.ApiClients.Models.Requests.DashBilanco;
public class DashBilancoOnGetGraphYearRequest
{
    public int nyear { get; set; }
}

public class DashBilancoOnGetGraphYearQuery
{
    public DashBilancoOnGetGraphYearRequest Request { get; set; }
}
