using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashRasyo
{
    public class MizanDashRasyoOnGetDashRasyoRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanDashRasyoOnGetDashRasyoQuery
    {
        public MizanDashRasyoOnGetDashRasyoRequest Request { get; set; }
    }
}
