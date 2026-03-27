
namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashBilanco
{
    public class MizanDashBilancoOnGetRequest
    {
        public MizanDashBilancoRequestInitialModel RequestInitialModel { get; set; }
    }

    public class MizanDashBilancoOnGetQuery
    {
        public MizanDashBilancoOnGetRequest Request { get; set; }
    }
}
