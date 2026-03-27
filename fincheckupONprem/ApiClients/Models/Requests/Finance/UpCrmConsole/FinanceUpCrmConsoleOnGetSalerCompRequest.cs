using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.UpCrmConsole
{
    public class FinanceUpCrmConsoleOnGetSalerCompRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class FinanceUpCrmConsoleOnGetSalerCompQuery
    {
        public FinanceUpCrmConsoleOnGetSalerCompRequest Request { get; set; }
    }
}
