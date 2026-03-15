
using System.Collections.Generic;
using System.Linq;

namespace fincheckup.Models.TaxError
{
    public class TaxMain
    {
        public List<TaxErrorCheck> ttdash { get; set; }
        public List<TaxErrorcheckTest> ttdash1 { get; set; }
        public List<TaxErrorcheckDataz> ttdash3 { get; set; }
        public TaxErrorCheck ttdashChk { get; set; }
        public TaxErrorcheckTest ttdashTest { get; set; }
        public TaxErrorcheckDataz ttdashDataz { get; set; }

        public TaxMain()
        {
            ttdashChk = new TaxErrorCheck();
            ttdashTest = new TaxErrorcheckTest();
            ttdashDataz = new TaxErrorcheckDataz();
        }
        public List<TaxErrorCheck> checkedFirst(int year, long companyid)
        {

            var ttdashchk = Data.Get_AllCompany(year, companyid).Where(x => x.AccountMainID == "100").ToList();
            ttdashChk.checklist(ttdashchk);
            ttdash = ttdashChk.taxchecklist;
            return Tax100.checkFirst(ttdash);
        }


        public List<TaxErrorcheckDataz> checkedSecond(int year, long companyid)
        {

            var ttdashchk1 = TBLXMLSourceMain.Get_AllCompany(year, companyid).Where(x => x.AccountMainID == "100").ToList();
            ttdashDataz.checklist(ttdashchk1);
            ttdash3 = ttdashDataz.taxchecklist;

            var tttttt = DashGelirTablosu.Get_MAINTAXCheck(year, companyid).Where(x => x.AccountMainID == "100").ToList();
            ttdashTest.checklist(tttttt);
            ttdash1 = ttdashTest.taxchecklist;

            return Tax100.checkSecond(ttdash1.FirstOrDefault(), ttdash3);
        }
        public List<TaxErrorcheckDataz> checkedThird(int year, long companyid)
        {

            var ttdashchk1 = TBLXMLSourceMain.Get_AllCompany(year, companyid).Where(x => x.AccountMainID == "100").ToList();
            ttdashDataz.checklist(ttdashchk1);
            ttdash3 = ttdashDataz.taxchecklist;

            var tttttt = DashGelirTablosu.Get_MAINTAXCheck(year, companyid).Where(x => x.AccountMainID == "100").ToList();
            ttdashTest.checklist(tttttt);
            ttdash1 = ttdashTest.taxchecklist;

            return Tax100.checkThird(ttdash1.FirstOrDefault(), ttdash3);
        }

        public List<TaxErrorcheckDataz> checkedFour(int year, long companyid)
        {

            var ttdashchk3 = TBLXMLSourceMain.Get_AllCompanyLast(year, companyid).Where(x => x.AccountMainID == "102").ToList();
            var ttdashchk3Int = TBLXMLSourceMain.Get_AllCompanyLast(year, companyid).Where(x => (x.AccountMainID == "646" || x.AccountMainID == "656")).Select(y => y.EndDate.Month).Distinct();

            var ttdashchk1 = ttdashchk3.Where(x => (x.AccountSubDescription.ToLower().Contains("usd") || x.AccountSubDescription.ToLower().Contains("eur") || x.AccountSubDescription.ToLower().Contains("gbp") || x.AccountSubDescription.ToLower().Contains("cny"))).ToList();


            ttdashDataz.checklist(ttdashchk1);
            ttdash3 = ttdashDataz.taxchecklist;

            ttdashTest.checklistLast(ttdash3);
            ttdash1 = ttdashTest.taxchecklist;


            return Tax102.checkFrist(ttdash1, ttdash3, ttdashchk3Int);
        }

        public List<TaxErrorcheckDataz> checkedFive(int year, long companyid)
        {

            var ttdashchk3 = TBLXMLSourceMain.Get_AllCompanyLast(year, companyid).Where(x => x.AccountMainID == "397").ToList();
            var ttdashchk3Int = TBLXMLSourceMain.Get_AllCompanyLast(year, companyid).Where(x => (x.AccountMainID == "950" || x.AccountMainID == "951")).Select(y => y.EndDate.Month).Distinct();

            ttdashDataz.checklist(ttdashchk3);
            ttdash3 = ttdashDataz.taxchecklist;

            ttdashTest.checklistLast(ttdash3);
            ttdash1 = ttdashTest.taxchecklist;
            return Tax197_397.checkFrist(ttdash1, ttdash3, ttdashchk3Int);
        }

        public List<TaxErrorcheckDataz> checkedSix(int year, long companyid)
        {

            var ttdashchk3 = TBLXMLSourceMain.Get_AllCompanyLast(year, companyid).Where(x => (x.AccountMainID == "180" || x.AccountMainID == "280")).ToList();





            ttdashDataz.checklist(ttdashchk3);
            ttdash3 = ttdashDataz.taxchecklist;

            ttdashTest.checklistLast(ttdash3);
            ttdash1 = ttdashTest.taxchecklist;


            return Tax180_280.checkFrist(ttdash1, ttdash3);
        }

        public List<TaxErrorcheckDataz> checkedSeven(int year, long companyid)
        {

            var ttdashchk3 = TBLXMLSourceMain.Get_AllCompanyLast(year, companyid).Where(x => (x.AccountMainID == "257")).ToList();





            ttdashDataz.checklist(ttdashchk3);
            ttdash3 = ttdashDataz.taxchecklist;

            ttdashTest.checklistLast(ttdash3);
            ttdash1 = ttdashTest.taxchecklist;


            return Tax255_257.checkFrist(ttdash1, ttdash3);
        }

        public List<TaxErrorcheckDataz> checkedEight(int year, long companyid)
        {

            var ttdashchk3 = TBLXMLSourceMain.Get_AllCompanyLast(year, companyid).Where(x => (x.AccountMainID == "257")).ToList();





            ttdashDataz.checklist(ttdashchk3);
            ttdash3 = ttdashDataz.taxchecklist;

            ttdashTest.checklistLast(ttdash3);
            ttdash1 = ttdashTest.taxchecklist;


            return Tax601.checkFrist(ttdash1.FirstOrDefault(), ttdash3);
        }

        public List<TaxErrorcheckDataz> checkedNine(int year, long companyid)
        {

            var ttdashchk3 = TBLXMLSourceMain.Get_AllCompanyLast(year, companyid).Where(x => (x.AccountMainID == "300" && x.EndDate.Month == 12)).ToList();





            ttdashDataz.checklist(ttdashchk3);
            ttdash3 = ttdashDataz.taxchecklist;

            ttdashTest.checklistLast(ttdash3);
            ttdash1 = ttdashTest.taxchecklist;


            return Tax300.checkFrist(ttdash1.FirstOrDefault(), ttdash3);
        }
        public List<TaxErrorcheckDataz> checkedTen(int year, long companyid)
        {

            var ttdashchk3 = TBLXMLSourceMain.Get_AllCompanyLast(year, companyid).Where(x => (x.AccountMainID == "500")).ToList();





            ttdashDataz.checklist(ttdashchk3);
            ttdash3 = ttdashDataz.taxchecklist;

            ttdashTest.checklistLast(ttdash3);
            ttdash1 = ttdashTest.taxchecklist;


            return Tax500.checkFrist(ttdash1, ttdash3);
        }
        public List<TaxErrorcheckDataz> checkedEleven(int year, long companyid)
        {

            var ttdashchk3 = TBLXMLSourceMain.Get_AllCompanyLast(year, companyid).Where(x => (x.AccountMainID == "500")).ToList();





            ttdashDataz.checklist(ttdashchk3);
            ttdash3 = ttdashDataz.taxchecklist;

            ttdashTest.checklistLast(ttdash3);
            ttdash1 = ttdashTest.taxchecklist;


            return Tax602.checkFrist(ttdash1.FirstOrDefault(), ttdash3);
        }

        public List<TaxErrorcheckDataz> checkedTwelve(int year, long companyid)
        {

            var ttdashchk3 = TBLXMLSourceMain.Get_AllCompanyLast(year, companyid).Where(x => (x.AccountMainID == "254")).ToList();





            ttdashDataz.checklist(ttdashchk3);
            ttdash3 = ttdashDataz.taxchecklist;

            ttdashTest.checklistLast(ttdash3);
            ttdash1 = ttdashTest.taxchecklist;


            return Tax254.checkFrist(ttdash1.FirstOrDefault(), ttdash3);
        }

        public List<TaxErrorcheckDataz> checkedThirteen(int year, long companyid)
        {

            var ttdashchk3 = TBLXMLSourceMain.Get_AllCompanyLast(year, companyid).Where(x => (x.AccountMainID == "195")).ToList();





            ttdashDataz.checklist(ttdashchk3);
            ttdash3 = ttdashDataz.taxchecklist;

            ttdashTest.checklistLast(ttdash3);
            ttdash1 = ttdashTest.taxchecklist;


            return Tax254.checkFrist(ttdash1.FirstOrDefault(), ttdash3);
        }
    }
}
