using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashRasyo
{
    public class MizanDashRasyoOnGetCasinoRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanDashRasyoOnGetCasinoQuery
    {
        public MizanDashRasyoOnGetCasinoRequest Request { get; set; }
    }
}
