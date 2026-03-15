using System.Collections.Generic;
using fincheckup.ApiClients.Entities;

namespace fincheckup.ApiClients.Models.Requests.Finance.DashLiquidity
{
    public class FinanceDashLiquidityRequestInitialModel
    {
        public IEnumerable<YearResult> myearResult;
        public long UserID;
        public long CompID;
        public string CompName;
        public int CompCount;
        public int YearCount;
        public List<DashBilancoView> nRequestListChk;
        public HhvnUsers CurrentUser;
        public IEnumerable<Entities.Company> mreqListCompany;
        public List<DashBilancoView> nRequestList;
        public List<DashWCapitalShortViewChart> nRequestListViewChart;
        public string NetIsletme { get; set; }
        public decimal NetIsletmeT { get; set; }
        public string CariOran { get; set; }
        public string NakitOran { get; set; }
    }
}
