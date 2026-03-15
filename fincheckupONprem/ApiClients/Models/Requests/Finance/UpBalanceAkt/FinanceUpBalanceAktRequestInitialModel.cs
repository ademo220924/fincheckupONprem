using System.Collections.Generic;
using fincheckup.ApiClients.Entities;
using fincheckup.ApiClients.Models.ViewModel.Reports;

namespace fincheckup.ApiClients.Models.Requests.Finance.UpBalanceAkt
{
    public class FinanceUpBalanceAktRequestInitialModel
    {
        public int UserID;
        public long CompID;
        public string header;
        public Entities.Company CCompanies;
        public HhvnUsers CurrentUser;
        public IEnumerable<Entities.Company> mreqListCompany;
        public List<ReportSet> ncheck;
    }
}
