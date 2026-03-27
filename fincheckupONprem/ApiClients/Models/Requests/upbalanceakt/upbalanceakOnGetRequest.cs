
namespace fincheckup.ApiClients.Models.Requests.upbalanceakt;
public class upbalanceaktOnGetRequest
{
    public int nyear { get; set; } = 2021;
}

public class upbalanceaktOnGetQuery
{
    public upbalanceaktOnGetRequest Request { get; set; }
}
