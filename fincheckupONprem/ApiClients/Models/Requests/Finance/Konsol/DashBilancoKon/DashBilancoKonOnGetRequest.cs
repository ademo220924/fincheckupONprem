namespace fincheckup.ApiClients.Models.Requests.Finance.Konsol.DashBilancoKon
{
    public class DashBilancoKonOnGetRequest
    {
        public int myear { get; set; }
    }

    public class DashBilancoKonOnGetQuery
    {
        public DashBilancoKonOnGetRequest Request { get; set; }
    }
}
