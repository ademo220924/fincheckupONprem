namespace fincheckup.ApiClients.Models.Requests.Finance.Aktarma.dashbilancomain;
public class AktarmaDashbilancomainRequest
{
    public int Year { get; set; }

    public class AktarmaDashbilancomainQuery
    {
        public AktarmaDashbilancomainRequest Request { get; set; }
    }
}
