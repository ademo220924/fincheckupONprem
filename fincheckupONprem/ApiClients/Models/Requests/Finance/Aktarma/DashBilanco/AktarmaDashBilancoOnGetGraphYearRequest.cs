namespace fincheckup.ApiClients.Models.Requests.Finance.Aktarma.DashBilanco;
public class AktarmaDashBilancoOnGetGraphYearRequest
{
    public int nyear { get; set; }

    public class AktarmaDashBilancoOnGetGraphYearQuery
    {
        public AktarmaDashBilancoOnGetGraphYearRequest Request { get; set; }
    }
}
