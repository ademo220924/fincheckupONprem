using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Upload
{
    public class FinanceUploadMainOnGetSalerDateRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class FinanceUploadMainOnGetSalerDateQuery
    {
        public FinanceUploadMainOnGetSalerDateRequest Request { get; set; }
    }
}
