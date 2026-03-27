namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Jrnl.DashBilancoJrnl
{
    public class MizanDashBilancoJrnlOnGetRequest
    {
        public int myear {  get; set; }
    }

    public class MizanDashBilancoJrnlOnGetQuery
    {
        public MizanDashBilancoJrnlOnGetRequest Request { get; set; }
    }
}
