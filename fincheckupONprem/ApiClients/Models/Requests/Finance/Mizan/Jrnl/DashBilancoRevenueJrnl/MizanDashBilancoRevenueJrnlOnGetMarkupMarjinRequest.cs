using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Jrnl.DashBilancoRevenueJrnl
{
    public class MizanDashBilancoRevenueJrnlOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }

    public class MizanDashBilancoRevenueJrnlOnGetMarkupMarjinQuery
    {
        public MizanDashBilancoRevenueJrnlOnGetMarkupMarjinRequest Request { get; set; }
    }
}
