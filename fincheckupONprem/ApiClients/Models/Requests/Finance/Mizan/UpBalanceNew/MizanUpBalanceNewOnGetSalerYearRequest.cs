using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalanceNew
{
    public class MizanUpBalanceNewOnGetSalerYearRequest
    {
        public DataSourceLoadOptions options {  get; set; }
    }
    
    public class MizanUpBalanceNewOnGetSalerYearQuery
    {
        public MizanUpBalanceNewOnGetSalerYearRequest Request {  get; set; }
    }
}
