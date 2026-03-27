namespace fincheckup.ApiClients.Models.Requests.DashCrmDetail
{
    public class DashCrmDetailOnGetGraphCompRequest
    {
        public int ncompid { get; set; }
    }

    public class DashCrmDetailOnGetGraphCompQuery
    {
        public DashCrmDetailOnGetGraphCompRequest Request { get; set; }
    }
}
