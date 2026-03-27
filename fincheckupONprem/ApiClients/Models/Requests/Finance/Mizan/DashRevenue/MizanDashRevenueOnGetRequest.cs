
namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashRevenue
{
    public class MizanDashRevenueOnGetRequest
    {
        public DashRevenue.MizanDashRevenueRequestInitialMopdel RequestInitialMopdel { get; set; }
    }

    public class MizanDashRevenueOnGetQuery
    {
        public MizanDashRevenueOnGetRequest Request { get; set; }
    }
}
