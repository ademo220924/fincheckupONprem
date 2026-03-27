using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashBilancoRevenueMlt
{
    public class MizanDashBilancoRevenueMltOnGetChartRasyoRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanDashBilancoRevenueMltOnGetChartRasyoQuery
    {
        public MizanDashBilancoRevenueMltOnGetChartRasyoRequest Request { get; set; }
    }
}
