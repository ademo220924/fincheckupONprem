using System.Collections.Generic;
using fincheckup.ApiClients.Entities;
using fincheckup.ApiClients.Models.ViewModel;
using fincheckup.ApiClients.Models.ViewModel.Reports;


namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportBalance
{
    public class MizanReportBalanceRequestInitialModel
    {
        public long UserID;
        public long CompID;
        public string header;
        public Entities.Company CCompanies;
        public ReportMizan mainreporttext;
        public HhvnUsers CurrentUser;
        public IEnumerable<Entities.Company> mreqListCompany;
        public List<ReportSet> ncheck;
        public List<DashMizanResult> ncheck1;
        public List<DashDonukView> ncheck2;
        public List<DashMizanResult> ncheck3;
        public List<DashMizanResult> ncheck4;
    }
}
