using DevExtreme.AspNet.Mvc;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.Menu.CompanyKonsolList;

public class MizanCompanyKonsolListOnGetKonListRequest
{
    public DataSourceLoadOptions options {  get; set; }
    public long ide {  get; set; }
}

public class MizanCompanyKonsolListOnGetKonListQuery
{
    public MizanCompanyKonsolListOnGetKonListRequest Request { get; set; }
}
