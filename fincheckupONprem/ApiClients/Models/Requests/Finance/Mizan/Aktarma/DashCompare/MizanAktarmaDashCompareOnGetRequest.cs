namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Aktarma.DashCompare
{
    public class MizanAktarmaDashCompareOnGetRequest
    {
        public int nmonth {  get; set; }
        public int nyear { get; set; }
    }

    public class MizanAktarmaDashCompareOnGetQuery
    {
        public MizanAktarmaDashCompareOnGetRequest Request { get; set; }
    }
}
