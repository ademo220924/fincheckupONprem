using System.Collections.Generic;
using fincheckup.ApiClients.Entities;


namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashRasyo
{
    public class MizanDashRasyoRequestInitialModel
    {
        public long UserID { get; set; }
        public long CompID { get; set; }
        public int CompCount { get; set; }
        public int YearCount { get; set; }
        public List<DashYearlyResultMizan> RasyoAnaliz { get; set; }
        public List<DashYearlyResultMizan> OzetMali { get; set; }
        public List<DashYearlyResultMizan> LikiditeRiskTrend { get; set; }
        public HhvnUsers CurrentUser { get; set; }
        public IEnumerable<Models.DashBoard> dash { get; set; }
        public IEnumerable<DashBoardRasyo> dashrasyo { get; set; } 
        public DashYearlyResultMizan RasyoAnalizView { get; set; }
        public DashYearlyResultMizan OzetMaliView { get; set; }
        public DashYearlyResultMizan LikiditeRiskTrendView { get; set; }
        public string CompName { get; set; }

        public IEnumerable<Entities.Company> mreqListCompany { get; set; }
        public int StartQuestions { get; set; }
        public int AQuestions { get; set; }
        public int BQuestions { get; set; }
        public int CQuestions { get; set; }
    }
}
