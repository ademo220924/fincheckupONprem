using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.DashRevenueJrnl
{
    public class FinanceDashRevenueJrnlOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options {  get; set; }
        public long compid { get; set; }
    }
}
