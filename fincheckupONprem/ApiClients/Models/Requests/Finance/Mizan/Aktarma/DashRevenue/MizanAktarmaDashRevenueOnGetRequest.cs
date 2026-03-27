namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Aktarma.DashRevenue
{
    public class MizanAktarmaDashRevenueOnGetRequest
    {
        public int myear {  get; set; }
    }

    public class MizanAktarmaDashRevenueOnGetQuery
    {
        public MizanAktarmaDashRevenueOnGetRequest Request { get; set; }
    }
}
