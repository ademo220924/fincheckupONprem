using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.UpCrmConsole
{
    public class FinanceUpCrmConsoleOnGetSalerYearRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class FinanceUpCrmConsoleOnGetSalerYearQuery
    {
        public FinanceUpCrmConsoleOnGetSalerYearRequest Request { get; set; }
    }
}
