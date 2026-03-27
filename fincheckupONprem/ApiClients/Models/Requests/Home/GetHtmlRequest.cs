namespace fincheckup.ApiClients.Models.Requests.Home
{
    public class GetHtmlRequest
    {
        public int PageIndex { get; set; }
    }

    public class GetHtmlQuery
    {
        public GetHtmlRequest Request { get; set; }
    }
}
