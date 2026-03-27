
namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashBilancoAkt
{
    public class MizanDashBilancoAktOnGetRequest
    {
        public int myear {  get; set; }
    }

    public class MizanDashBilancoAktOnGetQuery
    {
        public MizanDashBilancoAktOnGetRequest Request { get; set; }
    }
}
