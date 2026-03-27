using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashBilancoMlt
{
    public class MizanDashBilancoMltOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public string myear {  get; set; }
        public long compid { get; set; }
    }

    public class MizanDashBilancoMltOnGetMarkupMarjinQuery
    {
        public MizanDashBilancoMltOnGetMarkupMarjinRequest Request { get; set; }
    }
}
