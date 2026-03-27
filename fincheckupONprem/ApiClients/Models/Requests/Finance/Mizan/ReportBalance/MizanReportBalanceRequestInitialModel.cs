using System.Collections.Generic;
using fincheckup.ApiClients.Entities;
using fincheckup.ApiClients.Models.ViewModel;
using fincheckup.ApiClients.Models.ViewModel.Reports;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportBalance
{
    public class MizanReportBalanceRequestInitialModel
    {
        public long UserID { get; set; }
        public long CompID { get; set; }
        public string header { get; set; }
        public Entities.Company CCompanies { get; set; }
        public ReportMizan mainreporttext { get; set; }
        public HhvnUsers CurrentUser { get; set; }
        public IEnumerable<Entities.Company> mreqListCompany { get; set; }
        public List<ReportSet> ncheck { get; set; }
        public List<DashMizanResult> ncheck1 { get; set; }
        public List<DashDonukView> ncheck2 { get; set; }
        public List<DashMizanResult> ncheck3 { get; set; }
        public List<DashMizanResult> ncheck4 { get; set; }
    }
}
