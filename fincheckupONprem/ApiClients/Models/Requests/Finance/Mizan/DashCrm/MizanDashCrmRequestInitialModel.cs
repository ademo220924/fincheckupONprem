using System.Collections.Generic;
using fincheckup.ApiClients.Entities;


namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashCrm
{
    public class MizanDashCrmRequestInitialModel
    {
        public IEnumerable<YearResult> myearResult;
        public long UserID;
        public long CompID;
        public int CompCount;
        public int YearCount;
        public string CompName;
        public List<DashYearlyResultCRMMain> RasyoAnalizCRM;
        public List<DashYearlyResult> OzetMali;
        public List<DashYearlyResult> LikiditeRiskTrend;
        public HhvnUsers CurrentUser;
        public IEnumerable<Models.DashBoard> dash;
        public IEnumerable<DashBoardRasyo> dashrasyo;
        public DashYearlyResultChart RasyoAnalizView;
        public DashYearlyResultChartCRM RasyoAnalizViewCrm;
        public DashYearlyResultChart OzetMaliView;
        public DashYearlyResultChart LikiditeRiskTrendView;

        public IEnumerable<Entities.Company> mreqListCompany;
        public int StartQuestions { get; set; }
        public int AQuestions { get; set; }
        public int BQuestions { get; set; }
        public int CQuestions { get; set; }
    }
}
