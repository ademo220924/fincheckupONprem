using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Aktarma.DashBilanco
{
    public class MizanAktarmaDashBilancoOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid {  get; set; }
    }
}