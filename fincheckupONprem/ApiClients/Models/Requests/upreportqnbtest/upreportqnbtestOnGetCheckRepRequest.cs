
namespace fincheckup.ApiClients.Models.Requests.upreportqnbtest;
public class upreportqnbtestOnGetCheckRepRequest
{
    public long companyID { get; set; }
    public int nyear { get; set; }
    public string nacceco { get; set; }
}

public class upreportqnbtestOnGetCheckRepQuery
{
    public upreportqnbtestOnGetCheckRepRequest Request { get; set; }
}
