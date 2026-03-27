using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashBilancoMlt
{
    public class MizanDashBilancoMltOnGetChartRasyoRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanDashBilancoMltOnGetChartRasyoQuery
    {
        public MizanDashBilancoMltOnGetChartRasyoRequest Request { get; set; }
    }
}
