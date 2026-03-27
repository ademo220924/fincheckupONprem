using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Upload
{
    public class FinanceUploadMainOnGetSalerCompRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class FinanceUploadMainOnGetSalerCompQuery
    {
        public FinanceUploadMainOnGetSalerCompRequest Request { get; set; }
    }
}
