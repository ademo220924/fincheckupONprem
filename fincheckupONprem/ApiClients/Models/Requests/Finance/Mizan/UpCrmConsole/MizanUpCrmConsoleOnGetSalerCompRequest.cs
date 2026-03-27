using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpCrmConsole
{
    public class MizanUpCrmConsoleOnGetSalerCompRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanUpCrmConsoleOnGetSalerCompQuery
    {
        public MizanUpCrmConsoleOnGetSalerCompRequest Request { get; set; }
    }
}
