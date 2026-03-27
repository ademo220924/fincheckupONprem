using System.Collections.Generic;
using fincheckup.ApiClients.Entities;
using fincheckup.ApiClients.Models.ViewModel;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportMain
{
    public class MizanReportMainRequestInitialModel
    {
        public long UserID { get; set; }
        public long CompID { get; set; }
        public int CompCount { get; set; }
        public int YearCount { get; set; }
        public HhvnUsers CurrentUser { get; set; }
        public YearlyErrorResultView mrequestEntryView { get; set; }
        public IEnumerable<Entities.Company> mreqListCompany { get; set; }
        public IEnumerable<YearlyReportDashMizan> dashEbitMarjin { get; set; }
        public string CompName { get; set; }
        public IEnumerable<YearlyReportDashMizan> dashGrossProfit { get; set; }
        public IEnumerable<YearlyReportDashMizan> dashRevenue { get; set; }
        public IEnumerable<YearlyReportDashMizan> dashDonemselKarzarar { get; set; }
        public IEnumerable<YearlyReportDashMizan> dashWorkingCapital { get; set; }
        public IEnumerable<YearlyReportDashMizanGrap> dDashFrossViewMarjBrut { get; set; }
        public string dashEbitMarjinastr { get; set; }
        public string dashGrossProfitstr { get; set; }
        public string dashRevenuestr { get; set; }
        public string dashDonemselKarzararstr { get; set; }
        public string dashWorkingCapitalstr { get; set; }
        public string dDashFrossViewMarjBrutstr { get; set; }

        //  public ReportDashViewMarkupMarjin dashMarkupMarjin { get; set; }
    }
}
