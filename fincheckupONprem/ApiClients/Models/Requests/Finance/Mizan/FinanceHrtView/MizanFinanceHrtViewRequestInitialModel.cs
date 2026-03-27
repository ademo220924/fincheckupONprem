using System.Collections.Generic;
using fincheckup.ApiClients.Entities;
using fincheckup.ApiClients.Models.ViewModel;

namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.FinanceHrtView
{
    public class MizanFinanceHrtViewRequestInitialModel
    {
        public IEnumerable<YearResult> myearResult { get; set; }
        public long UserID { get; set; }
        public long CompID { get; set; }
        public int CompCount { get; set; }
        public int YearCount { get; set; }
        public string CompName { get; set; }
        public HhvnUsers CurrentUser { get; set; }
        public YearlyErrorResultView mrequestEntryView { get; set; }
        public IEnumerable<Entities.Company> mreqListCompany { get; set; }
        public IEnumerable<YearlyReportDash> dashEbitMarjin { get; set; }
        public IEnumerable<YearlyReportDash> dashGrossProfit { get; set; }
        public IEnumerable<YearlyReportDash> dashFinancialDebit { get; set; }
        public IEnumerable<YearlyReportDash> dashFinancialDebitMulti { get; set; }
        public IEnumerable<YearlyReportDash> ResultWorkingCapital { get; set; }
        public IEnumerable<DashBilancoViewMarj> dashFinancialOzkaynakAktif { get; set; }
        public IEnumerable<YearlyReportDash> dashFinancialCariOran { get; set; }
        public IEnumerable<YearlyReportDash> dashRevenue { get; set; }
        public IEnumerable<YearlyReportDash> dashDonemselKarzarar { get; set; }
        public IEnumerable<DashYearlyResultMain> dashWorkingCapital { get; set; }
        public IEnumerable<YearlyReportDashGraphic> dDashFrossViewMarjBrut { get; set; }
        public IEnumerable<ReportMainItem> dDashReportMain { get; set; }
        public IEnumerable<BWarn> mreqList { get; set; }
        public DashRep NetEbitMarjin { get; set; }
        public List<DashDepth> NetDashDepth { get; set; }
        public DashRep NetGrossProfit { get; set; }
        public DashRep NetFinancialDebit { get; set; }
        public DashRep NetRevenue { get; set; }
        public DashRep NetDonemselKarzarar { get; set; }
        public DashRep NetWorkingCapital { get; set; }
        public DashRep NetGrossProfitGraphic { get; set; }
        public string RetValGross { get; set; }
        public string RetValScore { get; set; }
        //  public ReportDashViewMarkupMarjin dashMarkupMarjin;
        public DashBilancoViewMarj dDashBilancoViewMarjBrut { get; set; }
        public DashBilancoViewMarj dDashBilancoViewMarjNet { get; set; }
    }
}
