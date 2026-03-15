using System;
using System.Collections.Generic;
using System.Linq;

namespace fincheckup.Models.ViewM
{
    public class YearlyUploadResult
    {
        public int MainYear { get; set; }
        public int MainMonth { get; set; }
        public long CsvID { get; set; }
        public int ErrorCount { get; set; }
        public string DocumentMonth { get; set; }
        public string DocumentMonthTr { get; set; }
        public string TxResult { get; set; }
        public string XmlDocName { get; set; }
    }
    public class DebitCreditResult
    {
        public string MVal { get; set; }
        public string MText { get; set; }

        public static IEnumerable<DebitCreditResult> getValue()
        {
            List<DebitCreditResult> nresult = new List<DebitCreditResult>();


            DebitCreditResult nval = new DebitCreditResult();
            nval.MVal = "D";
            nval.MText = "Debit";
            nresult.Add(nval);
            nval = new DebitCreditResult();
            nval.MVal = "C";
            nval.MText = "Credit";
            nresult.Add(nval);
            return nresult;
        }
    }

    public class SourceResult
    {
        public int MYear { get; set; }
        public string MText { get; set; }
        public static IEnumerable<SourceResult> getValue()
        {
            List<SourceResult> nresult = new List<SourceResult>();


            SourceResult nval = new SourceResult();
            nval.MYear = 0;
            nval.MText = "Bilgisayarımdan";
            nresult.Add(nval);

            nval = new SourceResult();
            nval.MYear = 1;
            nval.MText = "Qnb E-Finans";
            nresult.Add(nval);
            nval = new SourceResult();
            nval.MYear = 2;
            nval.MText = "Qnb Finansbank";
            nresult.Add(nval);

            nval = new SourceResult();
            nval.MYear = 3;
            nval.MText = "Uyumsoft";
            nresult.Add(nval);
            return nresult.OrderBy(x => x.MYear);
        }
        public static IEnumerable<SourceResult> getValueNom()
        {
            List<SourceResult> nresult = new List<SourceResult>();


            SourceResult nval = new SourceResult();
            nval.MYear = 0;
            nval.MText = "Bilgisayarımdan";
            nresult.Add(nval);

            return nresult.OrderBy(x => x.MYear);
        }
    }
    public class YearResult
    {
        public int MYear { get; set; }
        public string MText { get; set; }

        public static IEnumerable<YearResult> getValue()
        {
            List<YearResult> nresult = new List<YearResult>();
            int fyear = DateTime.Now.AddYears(-5).Year;
            int lyear = DateTime.Now.Year;
            for (int i = fyear; i <= lyear; i++)
            {
                YearResult nval = new YearResult();
                nval.MYear = i;
                nval.MText = i.ToString();
                nresult.Add(nval);
            }
            return nresult.OrderBy(x => x.MYear);
        }
        public static IEnumerable<YearResult> getValuemonth()
        {
            List<YearResult> nresult = new List<YearResult>();

            for (int i = 1; i <= 12; i++)
            {
                YearResult nval = new YearResult();
                nval.MYear = i;
                nval.MText = i.ToString();
                nresult.Add(nval);
            }
            return nresult.OrderBy(x => x.MYear);
        }
    }
}
