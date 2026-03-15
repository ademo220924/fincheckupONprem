using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UploadMain
{
    public class MizanUploadMainOnGetSalerMainChkRequest
    {
        public DataSourceLoadOptions options {  get; set; }
        public int monthid { get; set; }
    }
}
