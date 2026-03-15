using fincheckup.Models.NKolay.MizanView;
using System;
using System.Collections.Generic;
using System.Linq;

namespace fincheckup.Models.NKolay.ViewM
{
    public class ReportSet
    {
        public int TypeID { get; set; }
        public string AccountMainID { get; set; }
        public string AccountMainDescription { get; set; }
        public string AccountSubDescription { get; set; }
        public string AccountMainEng { get; set; }
        public long Amount { get; set; }
        public long BorcBakiye { get; set; }
        public long AlacakBakiye { get; set; }
        public long AmountMzn { get; set; }
        public long MainAmountTotal { get; set; }
        public long MainAmountTotalMzn { get; set; }
        public string DebitCreditCode { get; set; }
        public long AmountBakiye { get; set; }
        public long AmountBakiyeMzn { get; set; }
        public long Debit { get; set; }
        public int Year { get; set; }
        public long Credit { get; set; }
        public int SubTypeID { get; set; }
        public int MainTypeID { get; set; }
        public bool IsErrored { get; set; }
        public bool IsBeyan { get; set; }
        public int MainMonth { get; set; }
    }


    public class ReportSetMainAktarma : BaseModel
    {


        public static string Set_ReportStartAktarma(int _year, long _compID, List<int> typelist)
        {

            if (typelist.Contains(1))
            {
                Set_ReportSet1(_year, _compID);
            }

            if (typelist.Contains(2))
            {
                Set_ReportSet2(_year, _compID);
            }

            if (typelist.Contains(3))
            {
                Set_ReportSet3(_year, _compID);
            }

            if (typelist.Contains(4))
            {
                Set_ReportSet4(_year, _compID);
            }

            if (typelist.Contains(41))
            {
                Set_ReportSet41(_year, _compID);
            }

            if (typelist.Contains(5))
            {
                Set_ReportSet5(_year, _compID);
            }


            if (typelist.Contains(7))
            {
                Set_ReportSet7(_year, _compID);
            }

            if (typelist.Contains(8))
            {
                Set_ReportSet8(_year, _compID);
            }

            if (typelist.Contains(9))
            {
                Set_ReportSet9(_year, _compID);
            }

            if (typelist.Contains(91))
            {
                Set_ReportSet91(_year, _compID);
            }

            if (typelist.Contains(93))
            {
                Set_ReportSet93(_year, _compID);
            }

            if (typelist.Contains(51))
            {
                Set_ReportSet001(_year, _compID);
            }

            if (typelist.Contains(141))
            {
                Set_ReportSet141(_year, _compID);
            }
            return "ok";
        }


        public static int Set_ReportSetfirst(int _year, long _compID)
        {
            try
            { return StaticQuery<int>("EXEC SPAKT_PROCT000First @companyID, @nyear", new { nyear = _year, companyID = _compID }).FirstOrDefault(); }
            catch (Exception ex)
            {
                var chk = ex;
                throw;
            }
        }
        public static int Set_ReportSet001(int _year, long _compID)
        {
            try
            { return StaticQuery<int>("EXEC SPAKT_PROCT001 @companyID, @nyear", new { nyear = _year, companyID = _compID }).FirstOrDefault(); }
            catch (Exception ex)
            {
                var chk = ex;
                throw;
            }
        }
        public static int Set_ReportSet141(int _year, long _compID)
        {
            try
            { return StaticQuery<int>("EXEC [SPAKT_PROCT51] @companyID, @nyear", new { nyear = _year, companyID = _compID }).FirstOrDefault(); }
            catch (Exception ex)
            {
                var chk = ex;
                throw;
            }
        }
        public static int Set_ReportSet1(int _year, long _compID)
        {
            try
            { return StaticQuery<int>("EXEC SPAKT_PROCT1 @companyID, @nyear", new { nyear = _year, companyID = _compID }).FirstOrDefault(); }
            catch (Exception ex)
            {
                var chk = ex;
                throw;
            }
        }
        public static int Set_ReportSet2(int _year, long _compID)
        {
            try
            { return StaticQuery<int>("EXEC SPAKT_PROCT2 @companyID, @nyear", new { nyear = _year, companyID = _compID }).FirstOrDefault(); }
            catch (Exception ex)
            {
                var chk = ex;
                throw;
            }
        }
        public static int Set_ReportSet3(int _year, long _compID)
        {
            try
            { return StaticQuery<int>("EXEC SPAKT_PROCT3 @companyID, @nyear", new { nyear = _year, companyID = _compID }).FirstOrDefault(); }
            catch (Exception ex)
            {
                var chk = ex;
                throw;
            }
        }
        public static int Set_ReportSet4(int _year, long _compID)
        {
            try
            { return StaticQuery<int>("EXEC SPAKT_PROCT4 @companyID, @nyear", new { nyear = _year, companyID = _compID }).FirstOrDefault(); }
            catch (Exception ex)
            {
                var chk = ex;
                throw;
            }
        }
        public static int Set_ReportSet41(int _year, long _compID)
        {
            try
            { return StaticQuery<int>("EXEC SPAKT_PROCT41 @companyID, @nyear", new { nyear = _year, companyID = _compID }).FirstOrDefault(); }
            catch (Exception ex)
            {
                var chk = ex;
                throw;
            }
        }
        public static int Set_ReportSet5(int _year, long _compID)
        {
            try
            { return StaticQuery<int>("EXEC SPAKT_PROCT5 @companyID, @nyear", new { nyear = _year, companyID = _compID }).FirstOrDefault(); }
            catch (Exception ex)
            {
                var chk = ex;
                throw;
            }
        }
        public static int Set_ReportSet7(int _year, long _compID)
        {
            try
            { return StaticQuery<int>("EXEC SPAKT_PROCT7 @companyID, @nyear", new { nyear = _year, companyID = _compID }).FirstOrDefault(); }
            catch (Exception ex)
            {
                var chk = ex;
                throw;
            }
        }
        public static int Set_ReportSet8(int _year, long _compID)
        {
            try
            { return StaticQuery<int>("EXEC SPAKT_PROCT8 @companyID, @nyear", new { nyear = _year, companyID = _compID }).FirstOrDefault(); }
            catch (Exception ex)
            {
                var chk = ex;
                throw;
            }
        }
        public static int Set_ReportSet9(int _year, long _compID)
        {
            try
            { return StaticQuery<int>("EXEC SPAKT_PROCT9 @companyID, @nyear", new { nyear = _year, companyID = _compID }).FirstOrDefault(); }
            catch (Exception ex)
            {
                var chk = ex;
                throw;
            }
        }
        public static int Set_ReportSet91(int _year, long _compID)
        {
            try
            { return StaticQuery<int>("EXEC SPAKT_PROCT91 @companyID, @nyear", new { nyear = _year, companyID = _compID }).FirstOrDefault(); }
            catch (Exception ex)
            {
                var chk = ex;
                throw;
            }
        }
        public static int Set_ReportSet93(int _year, long _compID)
        {
            try
            { return StaticQuery<int>("EXEC SPAKT_PROCT93 @companyID, @nyear", new { nyear = _year, companyID = _compID }).FirstOrDefault(); }
            catch (Exception ex)
            {
                var chk = ex;
                throw;
            }
        }
    }
    public class ReportSetMain : BaseModel
    {

        public static int Set_ReportSetMain(int _year, long _compID)
        {
            try
            {
                return StaticQuery<int>("EXEC SPO_REPOR00GENERALTOTAL @companyID, @nyear,1", new { nyear = _year, companyID = _compID }).FirstOrDefault();
            }
            catch (Exception ex)
            {
                var chk = ex;
                throw;
            }

            //SPO_COMPANYMIZANERR  SPO_DONUKCHK
        }
        public static int Set_ReportSetMulti(int _year, long _compID)
        {

            StaticQuery<int>("EXEC [dbo].[SP_TBLXMLSourceRepV3] @companyID, @nyear", new { nyear = _year, companyID = _compID }).FirstOrDefault();
            StaticQuery<int>("EXEC [dbo].[SPO_COMPANYMIZANERR] @companyID, @nyear", new { nyear = _year, companyID = _compID }).FirstOrDefault();
            return StaticQuery<int>("EXEC [dbo].[SPO_DONUKCHK] @companyID, @nyear,3", new { nyear = _year, companyID = _compID }).FirstOrDefault();
            //SPO_COMPANYMIZANERR  SPO_DONUKCHK  SPO_COMPANYMIZANERRMZN
        }
        public static List<ReportSet> Get_ReportSetFiba(long _compID)
        {
            string sql = @"EXEC [dbo].[SP_A_MIZANHEADERChk] @comp";

            return StaticQuery<ReportSet>(sql, new { comp = _compID }).ToList();
        }
        public static int Set_ReportSet(int _year, long _compID)
        {

            StaticQuery<int>("EXEC [dbo].[SP_TBLXMLSourceRep] @companyID, @nyear", new { nyear = _year, companyID = _compID }).FirstOrDefault();
            StaticQuery<int>("EXEC [dbo].[SPO_COMPANYMIZANERR] @companyID, @nyear", new { nyear = _year, companyID = _compID }).FirstOrDefault();

            return StaticQuery<int>("EXEC [dbo].[SPO_DONUKCHK] @companyID, @nyear,1", new { nyear = _year, companyID = _compID }).FirstOrDefault();
            //SPO_COMPANYMIZANERR  SPO_DONUKCHK  SPO_COMPANYMIZANERRMZN
        }
        public static int Set_ReportSetKon(int _year, long _compID)
        {


            return StaticQuery<int>("EXEC [dbo].[SPAKT_KONSOL_ALL] @companyID, @nyear", new { nyear = _year, companyID = _compID }).FirstOrDefault();
            //SPO_COMPANYMIZANERR  SPO_DONUKCHK  SPO_COMPANYMIZANERRMZN
        }
        public static int Set_ReportSetKonM(int _year, long _compID)
        {


            return StaticQuery<int>("EXEC [dbo].[SPAKT_KONSOL_ALLM] @companyID, @nyear", new { nyear = _year, companyID = _compID }).FirstOrDefault();
            //SPO_COMPANYMIZANERR  SPO_DONUKCHK  SPO_COMPANYMIZANERRMZN
        }
        public static List<YearlyErrorResult> Get_StatbyCompany(long _compID)
        {
            return StaticQuery<YearlyErrorResult>("EXEC SPOT_MIZANREPORTCOUNT @companyID", new { companyID = _compID }).ToList();
        }
        public static List<YearlyErrorResult> Get_StatbyCompanyConsole(long _compID)
        {
            return StaticQuery<YearlyErrorResult>("EXEC SPOT_MAINKONSOLCOUNT @companyID", new { companyID = _compID }).ToList();
        }
        public static List<YearlyErrorResult> Get_StatbyCompanyConsoleM(long _compID)
        {
            return StaticQuery<YearlyErrorResult>("EXEC SPOT_MAINKONSOLCOUNTM @companyID", new { companyID = _compID }).ToList();
        }
        public static List<YearlyErrorResult> Get_StatbyCompanyAktarmaMizan(long _compID)
        {
            return StaticQuery<YearlyErrorResult>("EXEC  SPOT_MAINREPORTCOUNTAKTRMMIZAN @companyID", new { companyID = _compID }).ToList();
        }
        public static List<YearlyErrorResult> Get_StatbyCompanyAktarma(long _compID)
        {
            return StaticQuery<YearlyErrorResult>("EXEC  SPOT_MAINREPORTCOUNTAKTRM @companyID", new { companyID = _compID }).ToList();
        }
        public static List<DashAktarma> Get_CompanyAktarmaResult(int _year, long _compID)
        {
            return StaticQuery<DashAktarma>("Select * from [SPO_TBMLAKTARMA] where CompanyID=@companyID and [YEAR]=@nyear", new { nyear = _year, companyID = _compID }).ToList();
        }
        public static List<YearlyErrorResult> StartCompanyAktarma(int _year, long _compID)
        {
            return StaticQuery<YearlyErrorResult>("EXEC  SPAKT_PROCALL @companyID, @nyear,1", new { nyear = _year, companyID = _compID }).ToList();
        }
        public static List<YearlyErrorResult> StartCompanyAktarmaMizan(int _year, long _compID)
        {
            return StaticQuery<YearlyErrorResult>("EXEC  SPAKT_PROCALL @companyID, @nyear,3", new { nyear = _year, companyID = _compID }).ToList();
        }
        public static List<YearlyErrorResult> Get_StatbyCompanyAktarmaMZN(long _compID)
        {
            return StaticQuery<YearlyErrorResult>("EXEC  SPOT_MIZANREPORTCOUNTAKTRMExcel @companyID", new { companyID = _compID }).ToList();
        }
        public static List<YearlyErrorResult> Get_StatbyCompanyExcel(long _compID)
        {
            return StaticQuery<YearlyErrorResult>("EXEC SPOT_MIZANREPORTCOUNTExcel @companyID", new { companyID = _compID }).ToList();
        }
        public static List<YearlyErrorResult> Get_StatbyCompanyMain(long _compID)
        {
            return StaticQuery<YearlyErrorResult>("EXEC SPOT_MAINREPORTCOUNT @companyID", new { companyID = _compID }).ToList();
        }

        public static List<YearlyErrorResult> Get_StatbyCompanyMainQNB(long _compID)
        {
            return StaticQuery<YearlyErrorResult>("EXEC SPOT_MAINREPORTCOUNTQnb @companyID", new { companyID = _compID }).ToList();
        }

        public static List<ReportSet> Get_ReportSetBilanco(int _year, long _compID)
        {
            string sql = @"SELECT  
       [TypeID]
      ,[AccountMainID]
      ,[AccountMainDescription]
      ,[AccountMainEng]
      ,Cast([Amount] as bigint) as  Amount
      ,[DebitCreditCode] 
	  ,Cast([AmountBakiye] as bigint)  'AmountBakiye'
      ,CASE when [DebitCreditCode]='D'  and AccountMainID<>'692' THEN Cast([AmountBakiye] as bigint)
            when [DebitCreditCode]='C'  and Cast([AmountBakiye] as bigint)>0 THEN Cast([AmountBakiye] as bigint)ELSE 0 END as  BorcBakiye 
	  ,CASE when [DebitCreditCode]='C'  and AccountMainID<>'692'  and Cast([AmountBakiye] as bigint)<0  THEN Cast([AmountBakiye] as bigint) 
            when [DebitCreditCode]='D'  and AccountMainID ='692' THEN Cast([Credit] as bigint) 
            when [DebitCreditCode]='D'  and Cast([AmountBakiye] as bigint)=0 THEN 0 ELSE 0 END as  AlacakBakiye 
      ,[SubTypeID]
      ,[MainTypeID] 
      ,[IsErrored]
      ,Cast([MainAmountTotal] as bigint) as  MainAmountTotal,Cast([Debit] as bigint) as Debit ,Cast([Credit] as bigint) as Credit
  FROM [dbo].[TBLXMLSourceOne] where CompanyID=@companyID and  [Year]=@nyear and AccountMainID<800  order by AccountMainID";

            return StaticQuery<ReportSet>(sql, new { nyear = _year, companyID = _compID }).ToList();
        }
        public static List<ReportSet> Get_ReportSetBilancoMzn(int _year, long _compID)
        {
            string sql = @"EXEC [SPP_SMMMZN] @companyID,@nyear";

            return StaticQuery<ReportSet>(sql, new { nyear = _year, companyID = _compID }).ToList();
        }
        public static List<ReportSet> Get_ReportSetBilancoAkt(int _year, long _compID)
        {
            string sql = @"EXEC [SPP_SMMMZNAKT] @companyID,@nyear";

            return StaticQuery<ReportSet>(sql, new { nyear = _year, companyID = _compID }).ToList();
        }

        public static List<ReportSet> Get_ReportSetBilancoAktJRNL(int _year, long _compID)
        {
            string sql = @"EXEC [SPP_SMMMZNAKTJRNL] @companyID,@nyear";

            return StaticQuery<ReportSet>(sql, new { nyear = _year, companyID = _compID }).ToList();
        }
    }
}
