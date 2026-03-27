using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMain
{
    public class MizanUploadMainOnGetSalerYearRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanUploadMainOnGetSalerYearQuery
    {
        public MizanUploadMainOnGetSalerYearRequest Request { get; set; }
    }
}
