using System.Collections.Generic;
using fincheckup.ApiClients.Entities;
using fincheckup.ApiClients.Models.ViewModel.Reports;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalanceAkt
{
    public class MizanUpBalanceAktRequestInitialModel
    {
        public long UserID { get; set; }
        public long CompID { get; set; }
        public string header { get; set; }
        public Entities.Company CCompanies { get; set; }
        public HhvnUsers CurrentUser { get; set; }
        public IEnumerable<Entities.Company> mreqListCompany { get; set; }
        public List<ReportSet> ncheck { get; set; }
    }
}
