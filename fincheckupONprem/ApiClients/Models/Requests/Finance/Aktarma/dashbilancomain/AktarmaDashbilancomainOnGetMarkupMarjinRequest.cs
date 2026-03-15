using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Aktarma.dashbilancomain;
public class AktarmaDashbilancomainOnGetMarkupMarjinRequest
{
    public long compid { get; set; }
    public DataSourceLoadOptions options { get; set; }
}