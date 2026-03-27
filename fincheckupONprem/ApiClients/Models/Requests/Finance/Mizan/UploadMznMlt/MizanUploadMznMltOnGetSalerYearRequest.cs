using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMznMlt
{
    public class MizanUploadMznMltOnGetSalerYearRequest
    {
        public DataSourceLoadOptions options { get; set; }
    }

    public class MizanUploadMznMltOnGetSalerYearQuery
    {
        public MizanUploadMznMltOnGetSalerYearRequest Request { get; set; }
    }
}
