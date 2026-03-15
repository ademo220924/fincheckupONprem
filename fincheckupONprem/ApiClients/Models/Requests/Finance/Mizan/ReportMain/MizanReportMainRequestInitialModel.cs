using System.Collections.Generic;
using fincheckup.ApiClients.Entities;
using fincheckup.ApiClients.Models.ViewModel;


namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.ReportMain
{
    public class MizanReportMainRequestInitialModel
    {
        public long UserID;
        public long CompID;
        public int CompCount;
        public int YearCount;
        public HhvnUsers CurrentUser;
        public YearlyErrorResultView mrequestEntryView;
        public IEnumerable<Entities.Company> mreqListCompany;
        public IEnumerable<YearlyReportDashMizan> dashEbitMarjin;
        public string CompName;
        public IEnumerable<YearlyReportDashMizan> dashGrossProfit;
        public IEnumerable<YearlyReportDashMizan> dashRevenue;
        public IEnumerable<YearlyReportDashMizan> dashDonemselKarzarar;
        public IEnumerable<YearlyReportDashMizan> dashWorkingCapital;
        public IEnumerable<YearlyReportDashMizanGrap> dDashFrossViewMarjBrut;
        public string dashEbitMarjinastr;
        public string dashGrossProfitstr;
        public string dashRevenuestr;
        public string dashDonemselKarzararstr;
        public string dashWorkingCapitalstr;
        public string dDashFrossViewMarjBrutstr;

        //  public ReportDashViewMarkupMarjin dashMarkupMarjin;
    }
}
