using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMzan
{
    public class MizanUploadMzanOnGetSalerYearRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanUploadMzanOnGetSalerYearQuery
    {
        public MizanUploadMzanOnGetSalerYearRequest Request { get; set; }
    }
}
