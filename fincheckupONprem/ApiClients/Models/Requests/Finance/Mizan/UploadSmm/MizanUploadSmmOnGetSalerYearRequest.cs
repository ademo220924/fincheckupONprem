using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadSmm
{
    public class MizanUploadSmmOnGetSalerYearRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }

    public class MizanUploadSmmOnGetSalerYearQuery
    {
        public MizanUploadSmmOnGetSalerYearRequest Request { get; set; }
    }
}
