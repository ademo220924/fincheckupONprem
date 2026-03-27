namespace fincheckup.ApiClients.Models.Requests.Finance.Konsol.DashBilancoKon
{
    public class DashBilancoKonOnGetGraphYearRequest
    {
        public int nyear { get; set; }
    }

    public class DashBilancoKonOnGetGraphYearQuery
    {
        public DashBilancoKonOnGetGraphYearRequest Request { get; set; }
    }
}
