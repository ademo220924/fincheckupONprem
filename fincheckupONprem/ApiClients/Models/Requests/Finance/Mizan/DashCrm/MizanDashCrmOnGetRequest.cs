
namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashCrm
{
    public class MizanDashCrmOnGetRequest
    {
        public MizanDashCrmRequestInitialModel RequestInitialModel { get; set; }
    }

    public class MizanDashCrmOnGetQuery
    {
        public MizanDashCrmOnGetRequest Request { get; set; }
    }
}
