namespace fincheckup.ApiClients.Models.Requests.Finance.Konsol.DashRevenueKon
{
    public class DashRevenueKonOnGetGraphYearRequest
    {
        public int nyear {  get; set; }
    }

    public class DashRevenueKonOnGetGraphYearQuery
    {
        public DashRevenueKonOnGetGraphYearRequest Request { get; set; }
    }
}
