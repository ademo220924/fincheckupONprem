using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMizan
{
    public class MizanUploadMizanOnGetSalerYearRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class MizanUploadMizanOnGetSalerYearQuery
    {
        public MizanUploadMizanOnGetSalerYearRequest Request { get; set; }
    }
}
