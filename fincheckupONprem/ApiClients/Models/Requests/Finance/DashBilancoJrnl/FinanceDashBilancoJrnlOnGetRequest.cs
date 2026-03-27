
namespace fincheckup.ApiClients.Models.Requests.Finance.DashBilancoJrnl
{
    public class FinanceDashBilancoJrnlOnGetRequest
    {
        public int myear {  get; set; }
    }

    public class FinanceDashBilancoJrnlOnGetQuery
    {
        public FinanceDashBilancoJrnlOnGetRequest Request { get; set; }
    }
}
