namespace fincheckup.ApiClients.Models.Requests.Finance.Aktarma.DashBilanco;
public class AktarmaDashBilancoOnGetRequest
{
    public int Year { get; set; }

    public class AktarmaDashBilancoOnGetQuery
    {
        public AktarmaDashBilancoOnGetRequest Request { get; set; }
    }
}
