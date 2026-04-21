using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using fincheckup.ApiClients.Models.Aggregated;
using fincheckup.Report;
using System.Linq;
using fincheckup.ApiClients.Entities;
using fincheckup.ApiClients.Models.ViewModel;
using fincheckup.ApiClients.Models.ViewModel.Reports;

namespace fincheckup.Helper.Report
{
    public static class CompanyReportHelper
    {
        public static KontrolRaporu getKontrolRaporu(int _year, long _compID, int monthid_, List<DataViewer> ncheck)
        {
          
            ncheck = ncheck.Distinct().OrderBy(c => c.EntryNumber).ThenBy(n => n.Description).ToList();
            var report = new KontrolRaporu();

            ObjectDataSource objectDataSource = new ObjectDataSource();
            objectDataSource.Name = "DataViewer";
            objectDataSource.DataSource =  ncheck;

            objectDataSource.Fill();
            report.DataSource = objectDataSource;
            return report;
        }
        public static IcDenetimVergi getDenetimRaporu(int _year, long _compID, int monthid_, List<DataViewer> ncheck)
        {

            ncheck = ncheck.Distinct().OrderBy(c => c.EntryNumber).ThenBy(n => n.Description).ToList();
            var report = new IcDenetimVergi();

            ObjectDataSource objectDataSource = new ObjectDataSource();
            objectDataSource.Name = "DataViewer";
            objectDataSource.DataSource = ncheck; 

            objectDataSource.Fill();
            report.DataSource = objectDataSource;
            return report;
        }
    

        //objectDataSource.Fill();
        //report.DataSource = objectDataSource;
        public static BalanceReport getMizanRaporu(int _year, Company CCompanies)
        {
            string header = CCompanies.CompanyName + " " + _year.ToString() + " Yılı Kümülatif Mizan Raporu";
            List<ReportSet> ncheck = ReportSetMain.Get_ReportSetBilanco(_year, CCompanies.Id);
            List< DashMizanResult > ncheck1 = MizanResult.Get_MizanResult(_year, CCompanies.Id);
            List<DashDonukView> ncheck2= MizanResult.Get_DonuChk(_year, CCompanies.Id);
            List<DashMizanResult> ncheck3= MizanResult.Get_TicariAlıcı(_year, CCompanies.Id);
            List<DashMizanResult> ncheck4= MizanResult.Get_TicariBorclu(_year, CCompanies.Id);
            ReportMizan mainreporttext = ReportMizanCheck.GetComapanyCumulative(_year, CCompanies.Id);

            BalanceReport report = new BalanceReport();

            ObjectDataSource objectDataSource = new ObjectDataSource();
            objectDataSource.Name = "DataViewer";
            objectDataSource.DataSource = ncheck;

            ObjectDataSource objectDataSource1 = new ObjectDataSource();
            objectDataSource1.Name = "DataViewer1";
            objectDataSource1.DataSource = ncheck1;


            ObjectDataSource objectDataSource3 = new ObjectDataSource();
            objectDataSource3.Name = "DataViewer3";
            objectDataSource3.DataSource = ncheck2;


            ObjectDataSource objectDataSource4 = new ObjectDataSource();
            objectDataSource4.Name = "DataViewer4";
            objectDataSource4.DataSource = ncheck3;



            ObjectDataSource objectDataSource5 = new ObjectDataSource();
            objectDataSource5.Name = "DataViewer5";
            objectDataSource5.DataSource = ncheck4;

            //objectDataSource.Fill();
            DetailReportBand detailReport1 = report.Bands["DetailReport"] as DetailReportBand;
            DetailReportBand detailReport2 = report.Bands["DetailReport1"] as DetailReportBand;
            DetailReportBand detailReport3 = report.Bands["DetailReport2"] as DetailReportBand;
            DetailReportBand detailReport4 = report.Bands["DetailReport3"] as DetailReportBand;
            DetailReportBand detailReport5 = report.Bands["DetailReport4"] as DetailReportBand;

            report.FindControl("xrLabel1", true).Text = mainreporttext.TotalAssets.ToString("N0");
            report.FindControl("xrLabel1l", true).Text = mainreporttext.TotalLiability.ToString("N0");
            report.FindControl("xrLabel1e", true).Text = mainreporttext.TotalEquity.ToString("N0");
            report.FindControl("xrLabel1p", true).Text = mainreporttext.ProfitOrLoss.ToString("N0");
            report.xrLabel21rpt.Text = header;

            if (mainreporttext.TrialBalance == 0)
            {
                report.FindControl("xrShape2", true).Visible = false;
            }
            else
            {
                report.FindControl("xrShape1", true).Visible = false;
            }
            report.xrResultbalance.Text = mainreporttext.TrialBalance.ToString();
            //report.DataSource = objectDataSource;
            detailReport1.DataSource = objectDataSource;
            detailReport2.DataSource = objectDataSource1;
            detailReport3.DataSource = objectDataSource3;
            detailReport4.DataSource = objectDataSource4;
            detailReport5.DataSource = objectDataSource5;
            return report;
        }

        public static BalanceReport getMizanRaporuMizan(int _year, Company CCompanies)
        {
            string header = CCompanies.CompanyName + " " + _year.ToString() + " Yılı Kümülatif Mizan Raporu";


     

            List<ReportSet> ncheck = ReportSetMain.Get_ReportSetBilanco(_year, CCompanies.Id);
            List<DashMizanResult> ncheck1 = MizanResult.Get_MizanResult(_year, CCompanies.Id);
            List<DashDonukView> ncheck2 = MizanResult.Get_DonuChk(_year, CCompanies.Id);
            List<DashMizanResult> ncheck3 = MizanResult.Get_TicariAlıcıMizan(_year, CCompanies.Id);
            List<DashMizanResult> ncheck4 = MizanResult.Get_TicariBorcluMizan(_year, CCompanies.Id);
            ReportMizan mainreporttext = ReportMizanCheck.GetComapanyCumulativeMizan(_year, CCompanies.Id);

            BalanceReport report = new BalanceReport();

            ObjectDataSource objectDataSource = new ObjectDataSource();
            objectDataSource.Name = "DataViewer";
            objectDataSource.DataSource = ncheck;

            ObjectDataSource objectDataSource1 = new ObjectDataSource();
            objectDataSource1.Name = "DataViewer1";
            objectDataSource1.DataSource = ncheck1;


            ObjectDataSource objectDataSource3 = new ObjectDataSource();
            objectDataSource3.Name = "DataViewer3";
            objectDataSource3.DataSource = ncheck2;


            ObjectDataSource objectDataSource4 = new ObjectDataSource();
            objectDataSource4.Name = "DataViewer4";
            objectDataSource4.DataSource = ncheck3;



            ObjectDataSource objectDataSource5 = new ObjectDataSource();
            objectDataSource5.Name = "DataViewer5";
            objectDataSource5.DataSource = ncheck4;

            //objectDataSource.Fill();
            DetailReportBand detailReport1 = report.Bands["DetailReport"] as DetailReportBand;
            DetailReportBand detailReport2 = report.Bands["DetailReport1"] as DetailReportBand;
            DetailReportBand detailReport3 = report.Bands["DetailReport2"] as DetailReportBand;
            DetailReportBand detailReport4 = report.Bands["DetailReport3"] as DetailReportBand;
            DetailReportBand detailReport5 = report.Bands["DetailReport4"] as DetailReportBand;

            report.FindControl("xrLabel1", true).Text = mainreporttext.TotalAssets.ToString("N0");
            report.FindControl("xrLabel1l", true).Text = mainreporttext.TotalLiability.ToString("N0");
            report.FindControl("xrLabel1e", true).Text = mainreporttext.TotalEquity.ToString("N0");
            report.FindControl("xrLabel1p", true).Text = mainreporttext.ProfitOrLoss.ToString("N0");
            report.xrLabel21rpt.Text = header;

            if (mainreporttext.TrialBalance == 0)
            {
                report.FindControl("xrShape2", true).Visible = false;
            }
            else
            {
                report.FindControl("xrShape1", true).Visible = false;
            }
            report.xrResultbalance.Text = mainreporttext.TrialBalance.ToString();
            //report.DataSource = objectDataSource;
            detailReport1.DataSource = objectDataSource;
            detailReport2.DataSource = objectDataSource1;
            detailReport3.DataSource = objectDataSource3;
            detailReport4.DataSource = objectDataSource4;
            detailReport5.DataSource = objectDataSource5;
            return report;
        }

        public static BalanceReportAktarma getMizanRaporuMizanAkt(int _year, Company CCompanies)
        {
            string header = CCompanies.CompanyName + " " + _year.ToString() + " Yılı Aktarma Karşılaştırmalı Mizan Raporu";

 


            List<ReportSet> ncheck = ReportSetMain.Get_ReportSetBilancoAkt(_year, CCompanies.Id);
             

            BalanceReportAktarma report = new BalanceReportAktarma();

            ObjectDataSource objectDataSource = new ObjectDataSource();
            objectDataSource.Name = "DataViewer";
            objectDataSource.DataSource =  ncheck;



            objectDataSource.Fill();
            DetailReportBand detailReport1 = report.Bands["DetailReport"] as DetailReportBand;

            report.xrLabelheader.Text =  header;

            //if (Model.mainreporttext.TrialBalance == 0)
            //{
            //    report.FindControl("xrShape2", true).Visible = false;
            //}
            //else
            //{
            //    report.FindControl("xrShape1", true).Visible = false;
            //}

            detailReport1.DataSource = objectDataSource;
            // report.DataSource = objectDataSource;
            report.PrintingSystem.Document.Name = "Balance_raporlar";
            return report;
        }
    }
}
