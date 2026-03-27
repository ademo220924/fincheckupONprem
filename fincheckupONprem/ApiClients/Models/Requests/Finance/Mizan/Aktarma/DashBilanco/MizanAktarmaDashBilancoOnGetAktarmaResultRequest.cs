using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Aktarma.DashBilanco
{
    public class MizanAktarmaDashBilancoOnGetAktarmaResultRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class MizanAktarmaDashBilancoOnGetAktarmaResultQuery
    {
        public MizanAktarmaDashBilancoOnGetAktarmaResultRequest Request { get; set; }
    }
}
