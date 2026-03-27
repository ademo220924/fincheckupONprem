using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.DashBilanco;
public class DashBilancoOnGetChartRasyoRequest
{
    public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
    public DashBilancoRequest InitialModel { get; set; }
}

public class DashBilancoOnGetChartRasyoQuery
{
    public DashBilancoOnGetChartRasyoRequest Request { get; set; }
}
