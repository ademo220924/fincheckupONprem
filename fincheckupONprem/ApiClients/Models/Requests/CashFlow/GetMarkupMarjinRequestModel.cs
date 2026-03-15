using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.CashFlow
{
    public class GetMarkupMarjinRequestModel
    {
        public DataSourceLoadOptions DataSourceLoadOptions { get; set; }
        public string Myear { get; set; }
        public long Compid { get; set; }
    }
}
