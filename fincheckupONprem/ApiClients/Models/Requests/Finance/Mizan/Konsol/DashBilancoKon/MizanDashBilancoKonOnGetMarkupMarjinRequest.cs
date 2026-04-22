using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Konsol.DashBilancoKon
{
    public class MizanDashBilancoKonOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options {  get; set; }
        public int myear { get; set; }
        public long compid { get; set; }
    }

    public class MizanDashBilancoKonOnGetMarkupMarjinQuery
    {
        public MizanDashBilancoKonOnGetMarkupMarjinRequest Request { get; set; }
    }
}
