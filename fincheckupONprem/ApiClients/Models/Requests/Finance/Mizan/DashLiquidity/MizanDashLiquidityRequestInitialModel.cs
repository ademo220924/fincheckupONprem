using System.Collections.Generic;
using fincheckup.ApiClients.Entities;


namespace fincheckup.ApiClients.Models.Requests.Finance.Mizan.DashLiquidity
{
    public class MizanDashLiquidityRequestInitialModel
    {
        public long UserID;
        public long CompID;
        public int CompCount;
        public int YearCount;
        public List<DashBilancoViewMizan> nRequestListChk;
        public List<DashYearlyResultMizan> nRequestChart;
        public string CompName;
        public HhvnUsers CurrentUser;
        public IEnumerable<Entities.Company> mreqListCompany;
        public List<DashBilancoViewMizan> nRequestList;
        public string NetIsletme { get; set; }
        public decimal NetIsletmeT { get; set; }
        public string CariOran { get; set; }
        public string NakitOran { get; set; }
    }
}
