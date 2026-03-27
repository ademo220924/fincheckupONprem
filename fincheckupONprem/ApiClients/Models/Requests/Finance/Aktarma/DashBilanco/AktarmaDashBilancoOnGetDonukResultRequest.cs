using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Aktarma.DashBilanco;
public class AktarmaDashBilancoOnGetDonukResultRequest
{
    public DataSourceLoadOptions options { get; set; }
    public long compid { get; set; }
    public int nyear { get; set; }
}

public class AktarmaDashBilancoOnGetDonukResultQuery
{
    public AktarmaDashBilancoOnGetDonukResultRequest Request { get; set; }
}
