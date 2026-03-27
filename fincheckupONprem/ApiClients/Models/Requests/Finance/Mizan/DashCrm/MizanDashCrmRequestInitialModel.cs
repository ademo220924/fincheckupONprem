using System.Collections.Generic;
using fincheckup.ApiClients.Entities;


namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashCrm
{
    public class MizanDashCrmRequestInitialModel
    {
        public IEnumerable<YearResult> myearResult { get; set; }
        public long UserID { get; set; }
        public long CompID { get; set; }
        public int CompCount { get; set; }
        public int YearCount { get; set; }
        public string CompName { get; set; }
        public List<DashYearlyResultCRMMain> RasyoAnalizCRM { get; set; }
        public List<DashYearlyResult> OzetMali { get; set; }
        public List<DashYearlyResult> LikiditeRiskTrend { get; set; }
        public HhvnUsers CurrentUser { get; set; }
        public IEnumerable<Models.DashBoard> dash { get; set; }
        public IEnumerable<DashBoardRasyo> dashrasyo { get; set; }
        public DashYearlyResultChart RasyoAnalizView { get; set; }
        public DashYearlyResultChartCRM RasyoAnalizViewCrm { get; set; }
        public DashYearlyResultChart OzetMaliView { get; set; }
        public DashYearlyResultChart LikiditeRiskTrendView { get; set; }

        public IEnumerable<Entities.Company> mreqListCompany { get; set; }
        public int StartQuestions { get; set; }
        public int AQuestions { get; set; }
        public int BQuestions { get; set; }
        public int CQuestions { get; set; }
    }
}
