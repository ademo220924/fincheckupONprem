
namespace fincheckup.ApiClients.Models.Requests.upbalancemzn;
public class upbalancemznOnGetRequest
{
    public int nyear { get; set; } = 2021;
}

public class upbalancemznOnGetQuery
{
    public upbalancemznOnGetRequest Request { get; set; }
}
