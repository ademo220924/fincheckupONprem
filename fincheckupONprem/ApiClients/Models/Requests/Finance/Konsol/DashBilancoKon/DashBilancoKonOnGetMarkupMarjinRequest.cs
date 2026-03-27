using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Konsol.DashBilancoKon
{
    public class DashBilancoKonOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class DashBilancoKonOnGetMarkupMarjinQuery
    {
        public DashBilancoKonOnGetMarkupMarjinRequest Request { get; set; }
    }
}
