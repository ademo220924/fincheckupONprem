
namespace fincheckup.ApiClients.Models.Requests.Finance.DashRevenueJrnl
{
    public class FinanceDashRevenueJrnlOnGetRequest
    {
        public int myear {  get; set; }
    }

    public class FinanceDashRevenueJrnlOnGetQuery
    {
        public FinanceDashRevenueJrnlOnGetRequest Request { get; set; }
    }
}
