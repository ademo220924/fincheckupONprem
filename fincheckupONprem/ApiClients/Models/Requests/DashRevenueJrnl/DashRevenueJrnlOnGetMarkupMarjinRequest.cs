
using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashRevenueJrnl;
public class DashRevenueJrnlOnGetMarkupMarjinRequest
{
    public DataSourceLoadOptions Options { get; set; }
    public string Myear { get; set; }
    public long Compid { get; set; }
}

public class DashRevenueJrnlOnGetMarkupMarjinQuery
{
    public DashRevenueJrnlOnGetMarkupMarjinRequest Request { get; set; }
}
