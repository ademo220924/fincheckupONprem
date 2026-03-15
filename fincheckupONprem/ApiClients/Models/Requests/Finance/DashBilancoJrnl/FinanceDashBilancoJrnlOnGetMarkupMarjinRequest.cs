using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.DashBilancoJrnl
{
    public class FinanceDashBilancoJrnlOnGetMarkupMarjinRequest
    {
        public DataSourceLoadOptions options { get; set; }
        public long compid { get; set; }
    }
}
