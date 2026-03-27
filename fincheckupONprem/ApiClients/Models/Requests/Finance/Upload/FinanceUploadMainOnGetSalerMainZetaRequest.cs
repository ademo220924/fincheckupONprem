using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Upload
{
    public class FinanceUploadMainOnGetSalerMainZetaRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public int monthid { get; set; }
    }

    public class FinanceUploadMainOnGetSalerMainZetaQuery
    {
        public FinanceUploadMainOnGetSalerMainZetaRequest Request { get; set; }
    }
}
