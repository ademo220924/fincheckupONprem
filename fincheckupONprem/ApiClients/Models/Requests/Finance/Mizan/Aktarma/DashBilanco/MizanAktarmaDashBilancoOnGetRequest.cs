namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Aktarma.DashBilanco
{
    public class MizanAktarmaDashBilancoOnGetRequest
    {
        public int myear { get; set; }
    }

    public class MizanAktarmaDashBilancoOnGetQuery
    {
        public MizanAktarmaDashBilancoOnGetRequest Request { get; set; }
    }
}
