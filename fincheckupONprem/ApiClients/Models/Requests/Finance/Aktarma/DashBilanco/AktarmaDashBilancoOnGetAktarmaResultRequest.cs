using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Aktarma.DashBilanco;
public class AktarmaDashBilancoOnGetAktarmaResultRequest
{
    public int nyear { get; set; }
    public long compid { get; set; }
    public DataSourceLoadOptions options { get; set; }

}
