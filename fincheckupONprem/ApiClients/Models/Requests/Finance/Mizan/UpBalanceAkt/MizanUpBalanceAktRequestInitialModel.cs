using System.Collections.Generic;
using fincheckup.ApiClients.Entities;
using fincheckup.ApiClients.Models.ViewModel.Reports;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.UpBalanceAkt
{
    public class MizanUpBalanceAktRequestInitialModel
    {
        public long UserID;
        public long CompID;
        public string header;
        public Entities.Company CCompanies;
        public HhvnUsers CurrentUser;
        public IEnumerable<Entities.Company> mreqListCompany;
        public List<ReportSet> ncheck;
    }
}
