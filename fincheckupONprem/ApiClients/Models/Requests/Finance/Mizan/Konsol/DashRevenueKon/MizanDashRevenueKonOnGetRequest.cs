namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Konsol.DashRevenueKon
{
    public class MizanDashRevenueKonOnGetRequest
    {
        public int myear {  get; set; }
    }

    public class MizanDashRevenueKonOnGetQuery
    {
        public MizanDashRevenueKonOnGetRequest Request { get; set; }
    }
}
