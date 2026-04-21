using System.Drawing;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using fincheckup.ApiClients.Models.Responses.Finance.ReportZone;
using fincheckup.Report;

namespace fincheckup.Helper.Report
{
    public static class ReportCheckZoneold
    {
        public static ReportFinancialdynamicb getReportMizanII(FinancialReportZonePayloadResponse response)
        {
            
            ReportFinancialdynamicb report = new ReportFinancialdynamicb();
            try
            { 
                ObjectDataSource objectDataSource = new ObjectDataSource();
                objectDataSource.Name = "DataViewer";
                objectDataSource.DataSource = response.Ncheck;

                objectDataSource.Fill();

                ObjectDataSource objectDataSourceA = new ObjectDataSource();
                objectDataSourceA.Name = "DataViewerA";
                objectDataSourceA.DataSource = response.NcheckA;

                objectDataSourceA.Fill();

                ObjectDataSource objectDataSourceB = new ObjectDataSource();
                objectDataSourceB.Name = "DataViewerB";
                objectDataSourceB.DataSource = response.Ncheck1;

                objectDataSourceB.Fill();

                ObjectDataSource objectDataSourceC = new ObjectDataSource();
                objectDataSourceC.Name = "DataViewerC";
                objectDataSourceC.DataSource = response.Ncheck1a;

                objectDataSourceC.Fill();


                ObjectDataSource objectDataSourceD = new ObjectDataSource();
                objectDataSourceD.Name = "DataViewerD";
                objectDataSourceD.DataSource = response.NcheckD;

                objectDataSourceD.Fill();

                ObjectDataSource objectDataSourceE = new ObjectDataSource();
                objectDataSourceE.Name = "DataViewerE";
                objectDataSourceE.DataSource = response.NcheckE;

                objectDataSourceE.Fill();

                ObjectDataSource objectDataSourceF = new ObjectDataSource();
                objectDataSourceF.Name = "DataViewerF";
                objectDataSourceF.DataSource = response.NcheckF;

                objectDataSourceF.Fill();



                ObjectDataSource objectDataSourceG = new ObjectDataSource();
                objectDataSourceG.Name = "DataViewerG";
                objectDataSourceG.DataSource = response.NcheckG;
                objectDataSourceG.Fill();

                ObjectDataSource objectDataSourceT = new ObjectDataSource();
                objectDataSourceT.Name = "DataViewerT";
                objectDataSourceT.DataSource = response.NcheckLast;
                objectDataSourceT.Fill();

                DetailReportBand detailReport = report.Bands["DetailReport"] as DetailReportBand;



                DetailReportBand detailReport1 = report.Bands["DetailReport1"] as DetailReportBand;
                DetailReportBand detailReport2 = report.Bands["DetailReport2"] as DetailReportBand;
                DetailReportBand detailReport3 = report.Bands["DetailReport4"] as DetailReportBand;


                DetailReportBand detailReport11 = report.Bands["DetailReport11"] as DetailReportBand;
                DetailReportBand detailReport12 = report.Bands["DetailReport12"] as DetailReportBand;
                DetailReportBand detailReport13 = report.Bands["DetailReport13"] as DetailReportBand;
                DetailReportBand detailReport14 = report.Bands["DetailReport14"] as DetailReportBand;
                DetailReportBand detailReport15 = report.Bands["DetailReport15"] as DetailReportBand;
 
                report.xrCrossTab1.DataSource = objectDataSource;
                report.xrCrossTab2.DataSource = objectDataSourceA;
                report.xrCrossTab3.DataSource = objectDataSourceB;
                report.xrCrossTab4.DataSource = objectDataSourceC;
                report.xrCrossTab5.DataSource = objectDataSourceD;
                report.xrCrossTab6.DataSource = objectDataSourceE;
                report.xrCrossTab7.DataSource = objectDataSourceF;
                report.xrCrossTab8.DataSource = objectDataSourceG;
                report.xrCrossTab9.DataSource = objectDataSourceT;
 

                var chart = (XRChart)report.FindControl("xrChart1", false);
                chart.Series.Clear();
                chart.DataSource = response.NcheckChart;//Method from documentation you reffered
                chart.SeriesTemplate.SeriesDataMember = "GroupName";
                chart.SeriesTemplate.Label.TextPattern = "{V:n0}";
                chart.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var chart1 = (XRChart)report.FindControl("xrChart2", false);
                chart1.Series.Clear();
                chart1.DataSource = response.NcheckChartB;//Method from documentation you reffered
                chart1.SeriesTemplate.SeriesDataMember = "GroupName";
                chart1.SeriesTemplate.Label.TextPattern = "{V:n0}";
                chart1.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart1.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart3 = (XRChart)report.FindControl("xrChart3", false);
                chart3.Series.Clear();
                chart3.DataSource = response.NcheckChart1;//Method from documentation you reffered
                chart3.SeriesTemplate.SeriesDataMember = "GroupName";
                chart3.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart3.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart3.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart4 = (XRChart)report.FindControl("xrChart4", false);
                chart4.Series.Clear();
                chart4.DataSource = response.NcheckChart2;//Method from documentation you reffered
                chart4.SeriesTemplate.SeriesDataMember = "GroupName";
                chart4.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart4.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart4.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var chart5 = (XRChart)report.FindControl("xrChart5", false);
                chart5.Series.Clear();
                chart5.DataSource = response.NcheckChart3;//Method from documentation you reffered
                chart5.SeriesTemplate.SeriesDataMember = "GroupName";
                chart5.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart5.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart5.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart6 = (XRChart)report.FindControl("xrChart6", false);
                chart6.Series.Clear();
                chart6.DataSource = response.NcheckChart4;//Method from documentation you reffered
                chart6.SeriesTemplate.SeriesDataMember = "GroupName";
                chart6.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart6.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart6.SeriesTemplate.ValueDataMembers.AddRange("Value");

                report.xrLabel31.Text = response.Header;
                report.xrLabel29.Text = response.Nccode;
                var chart7 = (XRChart)report.FindControl("xrChart7", false);
                chart7.Series.Clear();
                chart7.DataSource = response.NcheckChart5;//Method from documentation you reffered
                chart7.SeriesTemplate.SeriesDataMember = "GroupName";
                chart7.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart7.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart7.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var chart8 = (XRChart)report.FindControl("xrChart8", false);
                chart8.Series.Clear();
                chart8.DataSource = response.NcheckChart6;//Method from documentation you reffered
                chart8.SeriesTemplate.SeriesDataMember = "GroupName";
                chart8.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart8.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart8.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart9 = (XRChart)report.FindControl("xrChart9", false);
                chart9.Series.Clear();
                chart9.DataSource = response.NcheckChart7;//Method from documentation you reffered
                chart9.SeriesTemplate.SeriesDataMember = "GroupName";
                chart9.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart9.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart9.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart10 = (XRChart)report.FindControl("xrChart10", false);
                chart10.Series.Clear();
                chart10.DataSource = response.NcheckChart8;//Method from documentation you reffered
                chart10.SeriesTemplate.SeriesDataMember = "GroupName";
                chart10.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart10.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart10.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart11 = (XRChart)report.FindControl("xrChart11", false);
                chart11.Series.Clear();
                chart11.DataSource = response.NcheckChart9;//Method from documentation you reffered
                chart11.SeriesTemplate.SeriesDataMember = "GroupName";
                chart11.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart11.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart11.SeriesTemplate.ValueDataMembers.AddRange("Value");



                var chart12 = (XRChart)report.FindControl("xrChart12", false);
                chart12.Series.Clear();
                chart12.DataSource = response.NcheckChart10;//Method from documentation you reffered
                chart12.SeriesTemplate.SeriesDataMember = "GroupName";
                chart12.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart12.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart12.SeriesTemplate.ValueDataMembers.AddRange("Value");



                var chart13 = (XRChart)report.FindControl("xrChart13", false);
                chart13.Series.Clear();
                chart13.DataSource = response.NcheckChart11;//Method from documentation you reffered
                chart13.SeriesTemplate.SeriesDataMember = "GroupName";
                chart13.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart13.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart13.SeriesTemplate.ValueDataMembers.AddRange("Value");

                //Color.FromArgb(182,33,45) red
                //Color.FromArgb(23, 127, 117) greeen
                var chart14 = (XRChart)report.FindControl("xrChart14", false);
                chart14.Series.Clear();
                chart14.DataSource = response.NcheckChart12;//Method from documentation you reffered
                chart14.SeriesTemplate.SeriesDataMember = "GroupName";
                chart14.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart14.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart14.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var xrlbl1 = (XRLabel)report.FindControl("xrLblOzkaynak", false);
                xrlbl1.Text = response.NcheckKapak.nitemOzkaynakAktif.TumYil.ToString("N2");

                var xrlbl2 = (XRLabel)report.FindControl("xrlblCarioran", false);
                xrlbl2.Text = response.NcheckKapak.nitemCariOran.TumYil.ToString("N2");


                var xrlbl3 = (XRLabel)report.FindControl("xrlblROA", false);
                xrlbl3.Text = (response.NcheckKapak.nitemROAAktifKarlilik.TumYil * 100).ToString("N2") + "%";



                var xrlbl5 = (XRLabel)report.FindControl("xrlblAltmanZ", false);
                xrlbl5.Text = response.NcheckKapak.nitemAltmanz.TumYil.ToString("N2");


                var xrlbl6 = (XRLabel)report.FindControl("xrlblNetIsletmeSerm", false);
                xrlbl6.Text = response.NcheckKapak.nitemNetIsletmeSermaye.TumYil.ToString("N0");


                var xrlbl7 = (XRLabel)report.FindControl("xrlblFaizVeVergi", false);
                xrlbl7.Text = response.NcheckKapak.nitemFaizVergiOncesiKarZarar.TumYil.ToString("N2");



                var xrlbl8 = (XRLabel)report.FindControl("xrCaritablo", false);
                xrlbl8.Text = response.NcheckKapak.nitemCariOran.TumYil.ToString("N2");


                var xrlbl9 = (XRLabel)report.FindControl("xrLikiditetablo", false);
                xrlbl9.Text = response.NcheckKapak.nitemLikitideOran.TumYil.ToString("N2");

                var xrlbl10 = (XRLabel)report.FindControl("xrNakittablo", false);
                xrlbl10.Text = response.NcheckKapak.nitemNakitOran.TumYil.ToString("N2");



                var xrlbl14 = (XRLabel)report.FindControl("xrtoplamborcsermtablo", false);
                xrlbl14.Text = response.NcheckKapak.nitemBorcOzsermaye.TumYil.ToString("N2");

                var xrlbl15 = (XRLabel)report.FindControl("xrtoplambankaborcdevirtablo", false);
                xrlbl15.Text = response.NcheckKapak.nitemTpolamBankaBorc.TumYil.ToString("N2");

                var xrlbl16 = (XRLabel)report.FindControl("xrOzaynakaktifktablo", false);
                xrlbl16.Text = response.NcheckKapak.nitemOzkaynakAktif.TumYil.ToString("N2");

                var gauget = (XRGauge)report.FindControl("xrGauge1", false);
                gauget.TargetValue = response.NcheckKapak.nitemAltmanz.TumYil;

                var rShape1 = (XRShape)report.FindControl("xrShape1", false);
                rShape1.BackColor = Color.FromArgb(response.ShapeArgb1 ?? 0);

                var rShape2 = (XRShape)report.FindControl("xrShape2", false);
                rShape2.BackColor = Color.FromArgb(response.ShapeArgb2 ?? 0);

                var rShape3 = (XRShape)report.FindControl("xrShape3", false);
                rShape3.BackColor = Color.FromArgb(response.ShapeArgb3 ?? 0);


                var rShape7 = (XRShape)report.FindControl("xrShape7", false);
                rShape7.BackColor = Color.FromArgb(response.ShapeArgb7 ?? 0);

                var rShape8 = (XRShape)report.FindControl("xrShape8", false);
                rShape8.BackColor = Color.FromArgb(response.ShapeArgb8 ?? 0);

                var rShape9 = (XRShape)report.FindControl("xrShape9", false);
                rShape9.BackColor = Color.FromArgb(response.ShapeArgb9 ?? 0);
                report.PrintingSystem.Document.Name = "Balance_raporlar"; 
            }
            catch (Exception ex)
            {
                var tt = ex;
                response.Isfailed = true;

            }
            return report;

        }

        public static ReportFinancialdynamic getReportMizanIII(FinancialReportZonePayloadResponse response)
        {
            ReportFinancialdynamic report = new ReportFinancialdynamic();
            try
            {


                ObjectDataSource objectDataSource = new ObjectDataSource();
                objectDataSource.Name = "DataViewer";
                objectDataSource.DataSource = response.Ncheck;

                objectDataSource.Fill();

                ObjectDataSource objectDataSourceA = new ObjectDataSource();
                objectDataSourceA.Name = "DataViewerA";
                objectDataSourceA.DataSource = response.NcheckA;

                objectDataSourceA.Fill();

                ObjectDataSource objectDataSourceB = new ObjectDataSource();
                objectDataSourceB.Name = "DataViewerB";
                objectDataSourceB.DataSource = response.Ncheck1;

                objectDataSourceB.Fill();

                ObjectDataSource objectDataSourceC = new ObjectDataSource();
                objectDataSourceC.Name = "DataViewerC";
                objectDataSourceC.DataSource = response.Ncheck1a;

                objectDataSourceC.Fill();


                ObjectDataSource objectDataSourceD = new ObjectDataSource();
                objectDataSourceD.Name = "DataViewerD";
                objectDataSourceD.DataSource = response.NcheckD;

                objectDataSourceD.Fill();

                ObjectDataSource objectDataSourceE = new ObjectDataSource();
                objectDataSourceE.Name = "DataViewerE";
                objectDataSourceE.DataSource = response.NcheckE;

                objectDataSourceE.Fill();

                ObjectDataSource objectDataSourceF = new ObjectDataSource();
                objectDataSourceF.Name = "DataViewerF";
                objectDataSourceF.DataSource = response.NcheckF;

                objectDataSourceF.Fill();



                ObjectDataSource objectDataSourceG = new ObjectDataSource();
                objectDataSourceG.Name = "DataViewerG";
                objectDataSourceG.DataSource = response.NcheckG;
                objectDataSourceG.Fill();

                ObjectDataSource objectDataSourceT = new ObjectDataSource();
                objectDataSourceT.Name = "DataViewerT";
                objectDataSourceT.DataSource = response.NcheckLast;
                objectDataSourceT.Fill();

                DetailReportBand detailReport = report.Bands["DetailReport"] as DetailReportBand;



                DetailReportBand detailReport1 = report.Bands["DetailReport1"] as DetailReportBand;
                DetailReportBand detailReport2 = report.Bands["DetailReport2"] as DetailReportBand;
                DetailReportBand detailReport3 = report.Bands["DetailReport4"] as DetailReportBand;


                DetailReportBand detailReport11 = report.Bands["DetailReport11"] as DetailReportBand;
                DetailReportBand detailReport12 = report.Bands["DetailReport12"] as DetailReportBand;
                DetailReportBand detailReport13 = report.Bands["DetailReport13"] as DetailReportBand;
                DetailReportBand detailReport14 = report.Bands["DetailReport14"] as DetailReportBand;
                DetailReportBand detailReport15 = report.Bands["DetailReport15"] as DetailReportBand;
                //report.AddToDetailBand("DetailReport");
                //report.AddToDetailBand("DetailReport1");
                //report.AddToDetailBand("DetailReport2");
                //report.AddToDetailBand("DetailReport4");
                //report.AddToDetailBand("DetailReport11");
                //report.AddToDetailBand("DetailReport12");
                //report.AddToDetailBand("DetailReport13");
                //report.AddToDetailBand("DetailReport14");
                //report.AddToDetailBand("DetailReport15");
                report.xrCrossTab1.DataSource = objectDataSource;
                report.xrCrossTab2.DataSource = objectDataSourceA;
                report.xrCrossTab3.DataSource = objectDataSourceB;
                report.xrCrossTab4.DataSource = objectDataSourceC;
                report.xrCrossTab5.DataSource = objectDataSourceD;
                report.xrCrossTab6.DataSource = objectDataSourceE;
                report.xrCrossTab7.DataSource = objectDataSourceF;
                report.xrCrossTab8.DataSource = objectDataSourceG;
                report.xrCrossTab9.DataSource = objectDataSourceT;
                //  detailReport.DataSource = objectDataSource;
                //detailReport1.DataSource = objectDataSourceA;
                //detailReport2.DataSource = objectDataSourceB;
                //detailReport3.DataSource = objectDataSourceC;

                //detailReport11.DataSource = objectDataSourceD;
                //detailReport12.DataSource = objectDataSourceE;
                //detailReport13.DataSource = objectDataSourceF;
                //detailReport14.DataSource = objectDataSourceG;
                //detailReport15.DataSource = objectDataSourceT;

                var chart = (XRChart)report.FindControl("xrChart1", false);
                chart.Series.Clear();
                chart.DataSource = response.NcheckChart;//Method from documentation you reffered
                chart.SeriesTemplate.SeriesDataMember = "GroupName";
                chart.SeriesTemplate.Label.TextPattern = "{V:n0}";
                chart.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var chart1 = (XRChart)report.FindControl("xrChart2", false);
                chart1.Series.Clear();
                chart1.DataSource = response.NcheckChartB;//Method from documentation you reffered
                chart1.SeriesTemplate.SeriesDataMember = "GroupName";
                chart1.SeriesTemplate.Label.TextPattern = "{V:n0}";
                chart1.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart1.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart3 = (XRChart)report.FindControl("xrChart3", false);
                chart3.Series.Clear();
                chart3.DataSource = response.NcheckChart1;//Method from documentation you reffered
                chart3.SeriesTemplate.SeriesDataMember = "GroupName";
                chart3.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart3.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart3.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart4 = (XRChart)report.FindControl("xrChart4", false);
                chart4.Series.Clear();
                chart4.DataSource = response.NcheckChart2;//Method from documentation you reffered
                chart4.SeriesTemplate.SeriesDataMember = "GroupName";
                chart4.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart4.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart4.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var chart5 = (XRChart)report.FindControl("xrChart5", false);
                chart5.Series.Clear();
                chart5.DataSource = response.NcheckChart3;//Method from documentation you reffered
                chart5.SeriesTemplate.SeriesDataMember = "GroupName";
                chart5.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart5.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart5.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart6 = (XRChart)report.FindControl("xrChart6", false);
                chart6.Series.Clear();
                chart6.DataSource = response.NcheckChart4;//Method from documentation you reffered
                chart6.SeriesTemplate.SeriesDataMember = "GroupName";
                chart6.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart6.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart6.SeriesTemplate.ValueDataMembers.AddRange("Value");

                report.xrLabel31.Text = response.Header;
                report.xrLabel29.Text = response.Nccode;
                var chart7 = (XRChart)report.FindControl("xrChart7", false);
                chart7.Series.Clear();
                chart7.DataSource = response.NcheckChart5;//Method from documentation you reffered
                chart7.SeriesTemplate.SeriesDataMember = "GroupName";
                chart7.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart7.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart7.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var chart8 = (XRChart)report.FindControl("xrChart8", false);
                chart8.Series.Clear();
                chart8.DataSource = response.NcheckChart6;//Method from documentation you reffered
                chart8.SeriesTemplate.SeriesDataMember = "GroupName";
                chart8.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart8.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart8.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart9 = (XRChart)report.FindControl("xrChart9", false);
                chart9.Series.Clear();
                chart9.DataSource = response.NcheckChart7;//Method from documentation you reffered
                chart9.SeriesTemplate.SeriesDataMember = "GroupName";
                chart9.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart9.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart9.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart10 = (XRChart)report.FindControl("xrChart10", false);
                chart10.Series.Clear();
                chart10.DataSource = response.NcheckChart8;//Method from documentation you reffered
                chart10.SeriesTemplate.SeriesDataMember = "GroupName";
                chart10.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart10.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart10.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart11 = (XRChart)report.FindControl("xrChart11", false);
                chart11.Series.Clear();
                chart11.DataSource = response.NcheckChart9;//Method from documentation you reffered
                chart11.SeriesTemplate.SeriesDataMember = "GroupName";
                chart11.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart11.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart11.SeriesTemplate.ValueDataMembers.AddRange("Value");



                var chart12 = (XRChart)report.FindControl("xrChart12", false);
                chart12.Series.Clear();
                chart12.DataSource = response.NcheckChart10;//Method from documentation you reffered
                chart12.SeriesTemplate.SeriesDataMember = "GroupName";
                chart12.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart12.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart12.SeriesTemplate.ValueDataMembers.AddRange("Value");



                var chart13 = (XRChart)report.FindControl("xrChart13", false);
                chart13.Series.Clear();
                chart13.DataSource = response.NcheckChart11;//Method from documentation you reffered
                chart13.SeriesTemplate.SeriesDataMember = "GroupName";
                chart13.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart13.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart13.SeriesTemplate.ValueDataMembers.AddRange("Value");

                //Color.FromArgb(182,33,45) red
                //Color.FromArgb(23, 127, 117) greeen
                var chart14 = (XRChart)report.FindControl("xrChart14", false);
                chart14.Series.Clear();
                chart14.DataSource = response.NcheckChart12;//Method from documentation you reffered
                chart14.SeriesTemplate.SeriesDataMember = "GroupName";
                chart14.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart14.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart14.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var xrlbl1 = (XRLabel)report.FindControl("xrLblOzkaynak", false);
                xrlbl1.Text = response.NcheckKapak.nitemOzkaynakAktif.TumYil.ToString("N2");

                var xrlbl2 = (XRLabel)report.FindControl("xrlblCarioran", false);
                xrlbl2.Text = response.NcheckKapak.nitemCariOran.TumYil.ToString("N2");


                var xrlbl3 = (XRLabel)report.FindControl("xrlblROA", false);
                xrlbl3.Text = (response.NcheckKapak.nitemROAAktifKarlilik.TumYil * 100).ToString("N2") + "%";



                var xrlbl5 = (XRLabel)report.FindControl("xrlblAltmanZ", false);
                xrlbl5.Text = response.NcheckKapak.nitemAltmanz.TumYil.ToString("N2");


                var xrlbl6 = (XRLabel)report.FindControl("xrlblNetIsletmeSerm", false);
                xrlbl6.Text = response.NcheckKapak.nitemNetIsletmeSermaye.TumYil.ToString("N0");


                var xrlbl7 = (XRLabel)report.FindControl("xrlblFaizVeVergi", false);
                xrlbl7.Text = response.NcheckKapak.nitemFaizVergiOncesiKarZarar.TumYil.ToString("N2");



                var xrlbl8 = (XRLabel)report.FindControl("xrCaritablo", false);
                xrlbl8.Text = response.NcheckKapak.nitemCariOran.TumYil.ToString("N2");


                var xrlbl9 = (XRLabel)report.FindControl("xrLikiditetablo", false);
                xrlbl9.Text = response.NcheckKapak.nitemLikitideOran.TumYil.ToString("N2");

                var xrlbl10 = (XRLabel)report.FindControl("xrNakittablo", false);
                xrlbl10.Text = response.NcheckKapak.nitemNakitOran.TumYil.ToString("N2");



                var xrlbl14 = (XRLabel)report.FindControl("xrtoplamborcsermtablo", false);
                xrlbl14.Text = response.NcheckKapak.nitemBorcOzsermaye.TumYil.ToString("N2");

                var xrlbl15 = (XRLabel)report.FindControl("xrtoplambankaborcdevirtablo", false);
                xrlbl15.Text = response.NcheckKapak.nitemTpolamBankaBorc.TumYil.ToString("N2");

                var xrlbl16 = (XRLabel)report.FindControl("xrOzaynakaktifktablo", false);
                xrlbl16.Text = response.NcheckKapak.nitemOzkaynakAktif.TumYil.ToString("N2");

                var gauget = (XRGauge)report.FindControl("xrGauge1", false);
                gauget.TargetValue = response.NcheckKapak.nitemAltmanz.TumYil;

                var rShape1 = (XRShape)report.FindControl("xrShape1", false);
                rShape1.BackColor = Color.FromArgb(response.ShapeArgb1 ?? 0);

                var rShape2 = (XRShape)report.FindControl("xrShape2", false);
                rShape2.BackColor = Color.FromArgb(response.ShapeArgb2 ?? 0);

                var rShape3 = (XRShape)report.FindControl("xrShape3", false);
                rShape3.BackColor = Color.FromArgb(response.ShapeArgb3 ?? 0);



                var rShape7 = (XRShape)report.FindControl("xrShape7", false);
                rShape7.BackColor = Color.FromArgb(response.ShapeArgb7 ?? 0);

                var rShape8 = (XRShape)report.FindControl("xrShape8", false);
                rShape8.BackColor = Color.FromArgb(response.ShapeArgb8 ?? 0);

                var rShape9 = (XRShape)report.FindControl("xrShape9", false);
                rShape9.BackColor = Color.FromArgb(response.ShapeArgb9 ?? 0);
                report.PrintingSystem.Document.Name = "Balance_raporlar"; 
            }
            catch (Exception ex)
            {
                var tt = ex;
                response.Isfailed = true;

            }
            return report;

        }
        public static ReportFinancialdynamicd getReportMizanIV(FinancialReportZonePayloadResponse response)
        {
            
            ReportFinancialdynamicd report = new ReportFinancialdynamicd();
            try
            {
 
                ObjectDataSource objectDataSource = new ObjectDataSource();
                objectDataSource.Name = "DataViewer";
                objectDataSource.DataSource = response.Ncheck;

                objectDataSource.Fill();

                ObjectDataSource objectDataSourceA = new ObjectDataSource();
                objectDataSourceA.Name = "DataViewerA";
                objectDataSourceA.DataSource = response.NcheckA;

                objectDataSourceA.Fill();

                ObjectDataSource objectDataSourceB = new ObjectDataSource();
                objectDataSourceB.Name = "DataViewerB";
                objectDataSourceB.DataSource = response.Ncheck1;

                objectDataSourceB.Fill();

                ObjectDataSource objectDataSourceC = new ObjectDataSource();
                objectDataSourceC.Name = "DataViewerC";
                objectDataSourceC.DataSource = response.Ncheck1a;

                objectDataSourceC.Fill();


                ObjectDataSource objectDataSourceD = new ObjectDataSource();
                objectDataSourceD.Name = "DataViewerD";
                objectDataSourceD.DataSource = response.NcheckD;

                objectDataSourceD.Fill();

                ObjectDataSource objectDataSourceE = new ObjectDataSource();
                objectDataSourceE.Name = "DataViewerE";
                objectDataSourceE.DataSource = response.NcheckE;

                objectDataSourceE.Fill();

                ObjectDataSource objectDataSourceF = new ObjectDataSource();
                objectDataSourceF.Name = "DataViewerF";
                objectDataSourceF.DataSource = response.NcheckF;

                objectDataSourceF.Fill();



                ObjectDataSource objectDataSourceG = new ObjectDataSource();
                objectDataSourceG.Name = "DataViewerG";
                objectDataSourceG.DataSource = response.NcheckG;
                objectDataSourceG.Fill();

                ObjectDataSource objectDataSourceT = new ObjectDataSource();
                objectDataSourceT.Name = "DataViewerT";
                objectDataSourceT.DataSource = response.NcheckLast;
                objectDataSourceT.Fill();

                DetailReportBand detailReport = report.Bands["DetailReport"] as DetailReportBand;



                DetailReportBand detailReport1 = report.Bands["DetailReport1"] as DetailReportBand;
                DetailReportBand detailReport2 = report.Bands["DetailReport2"] as DetailReportBand;
                DetailReportBand detailReport3 = report.Bands["DetailReport4"] as DetailReportBand;


                DetailReportBand detailReport11 = report.Bands["DetailReport11"] as DetailReportBand;
                DetailReportBand detailReport12 = report.Bands["DetailReport12"] as DetailReportBand;
                DetailReportBand detailReport13 = report.Bands["DetailReport13"] as DetailReportBand;
                DetailReportBand detailReport14 = report.Bands["DetailReport14"] as DetailReportBand;
                DetailReportBand detailReport15 = report.Bands["DetailReport15"] as DetailReportBand;
                //report.AddToDetailBand("DetailReport");
                //report.AddToDetailBand("DetailReport1");
                //report.AddToDetailBand("DetailReport2");
                //report.AddToDetailBand("DetailReport4");
                //report.AddToDetailBand("DetailReport11");
                //report.AddToDetailBand("DetailReport12");
                //report.AddToDetailBand("DetailReport13");
                //report.AddToDetailBand("DetailReport14");
                //report.AddToDetailBand("DetailReport15");
                report.xrCrossTab1.DataSource = objectDataSource;
                report.xrCrossTab2.DataSource = objectDataSourceA;
                report.xrCrossTab3.DataSource = objectDataSourceB;
                report.xrCrossTab4.DataSource = objectDataSourceC;
                report.xrCrossTab5.DataSource = objectDataSourceD;
                report.xrCrossTab6.DataSource = objectDataSourceE;
                report.xrCrossTab7.DataSource = objectDataSourceF;
                report.xrCrossTab8.DataSource = objectDataSourceG;
                report.xrCrossTab9.DataSource = objectDataSourceT;
                //  detailReport.DataSource = objectDataSource;
                //detailReport1.DataSource = objectDataSourceA;
                //detailReport2.DataSource = objectDataSourceB;
                //detailReport3.DataSource = objectDataSourceC;

                //detailReport11.DataSource = objectDataSourceD;
                //detailReport12.DataSource = objectDataSourceE;
                //detailReport13.DataSource = objectDataSourceF;
                //detailReport14.DataSource = objectDataSourceG;
                //detailReport15.DataSource = objectDataSourceT;

                var chart = (XRChart)report.FindControl("xrChart1", false);
                chart.Series.Clear();
                chart.DataSource = response.NcheckChart;//Method from documentation you reffered
                chart.SeriesTemplate.SeriesDataMember = "GroupName";
                chart.SeriesTemplate.Label.TextPattern = "{V:n0}";
                chart.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var chart1 = (XRChart)report.FindControl("xrChart2", false);
                chart1.Series.Clear();
                chart1.DataSource = response.NcheckChartB;//Method from documentation you reffered
                chart1.SeriesTemplate.SeriesDataMember = "GroupName";
                chart1.SeriesTemplate.Label.TextPattern = "{V:n0}";
                chart1.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart1.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart3 = (XRChart)report.FindControl("xrChart3", false);
                chart3.Series.Clear();
                chart3.DataSource = response.NcheckChart1;//Method from documentation you reffered
                chart3.SeriesTemplate.SeriesDataMember = "GroupName";
                chart3.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart3.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart3.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart4 = (XRChart)report.FindControl("xrChart4", false);
                chart4.Series.Clear();
                chart4.DataSource = response.NcheckChart2;//Method from documentation you reffered
                chart4.SeriesTemplate.SeriesDataMember = "GroupName";
                chart4.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart4.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart4.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var chart5 = (XRChart)report.FindControl("xrChart5", false);
                chart5.Series.Clear();
                chart5.DataSource = response.NcheckChart3;//Method from documentation you reffered
                chart5.SeriesTemplate.SeriesDataMember = "GroupName";
                chart5.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart5.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart5.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart6 = (XRChart)report.FindControl("xrChart6", false);
                chart6.Series.Clear();
                chart6.DataSource = response.NcheckChart4;//Method from documentation you reffered
                chart6.SeriesTemplate.SeriesDataMember = "GroupName";
                chart6.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart6.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart6.SeriesTemplate.ValueDataMembers.AddRange("Value");

                report.xrLabel31.Text = response.Header;
                report.xrLabel29.Text = response.Nccode;
                var chart7 = (XRChart)report.FindControl("xrChart7", false);
                chart7.Series.Clear();
                chart7.DataSource = response.NcheckChart5;//Method from documentation you reffered
                chart7.SeriesTemplate.SeriesDataMember = "GroupName";
                chart7.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart7.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart7.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var chart8 = (XRChart)report.FindControl("xrChart8", false);
                chart8.Series.Clear();
                chart8.DataSource = response.NcheckChart6;//Method from documentation you reffered
                chart8.SeriesTemplate.SeriesDataMember = "GroupName";
                chart8.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart8.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart8.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart9 = (XRChart)report.FindControl("xrChart9", false);
                chart9.Series.Clear();
                chart9.DataSource = response.NcheckChart7;//Method from documentation you reffered
                chart9.SeriesTemplate.SeriesDataMember = "GroupName";
                chart9.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart9.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart9.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart10 = (XRChart)report.FindControl("xrChart10", false);
                chart10.Series.Clear();
                chart10.DataSource = response.NcheckChart8;//Method from documentation you reffered
                chart10.SeriesTemplate.SeriesDataMember = "GroupName";
                chart10.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart10.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart10.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart11 = (XRChart)report.FindControl("xrChart11", false);
                chart11.Series.Clear();
                chart11.DataSource = response.NcheckChart9;//Method from documentation you reffered
                chart11.SeriesTemplate.SeriesDataMember = "GroupName";
                chart11.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart11.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart11.SeriesTemplate.ValueDataMembers.AddRange("Value");



                var chart12 = (XRChart)report.FindControl("xrChart12", false);
                chart12.Series.Clear();
                chart12.DataSource = response.NcheckChart10;//Method from documentation you reffered
                chart12.SeriesTemplate.SeriesDataMember = "GroupName";
                chart12.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart12.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart12.SeriesTemplate.ValueDataMembers.AddRange("Value");



                var chart13 = (XRChart)report.FindControl("xrChart13", false);
                chart13.Series.Clear();
                chart13.DataSource = response.NcheckChart11;//Method from documentation you reffered
                chart13.SeriesTemplate.SeriesDataMember = "GroupName";
                chart13.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart13.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart13.SeriesTemplate.ValueDataMembers.AddRange("Value");

                //Color.FromArgb(182,33,45) red
                //Color.FromArgb(23, 127, 117) greeen
                var chart14 = (XRChart)report.FindControl("xrChart14", false);
                chart14.Series.Clear();
                chart14.DataSource = response.NcheckChart12;//Method from documentation you reffered
                chart14.SeriesTemplate.SeriesDataMember = "GroupName";
                chart14.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart14.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart14.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var xrlbl1 = (XRLabel)report.FindControl("xrLblOzkaynak", false);
                xrlbl1.Text = response.NcheckKapak.nitemOzkaynakAktif.TumYil.ToString("N2");

                var xrlbl2 = (XRLabel)report.FindControl("xrlblCarioran", false);
                xrlbl2.Text = response.NcheckKapak.nitemCariOran.TumYil.ToString("N2");


                var xrlbl3 = (XRLabel)report.FindControl("xrlblROA", false);
                xrlbl3.Text = (response.NcheckKapak.nitemROAAktifKarlilik.TumYil * 100).ToString("N2") + "%";



                var xrlbl5 = (XRLabel)report.FindControl("xrlblAltmanZ", false);
                xrlbl5.Text = response.NcheckKapak.nitemAltmanz.TumYil.ToString("N2");


                var xrlbl6 = (XRLabel)report.FindControl("xrlblNetIsletmeSerm", false);
                xrlbl6.Text = response.NcheckKapak.nitemNetIsletmeSermaye.TumYil.ToString("N0");


                var xrlbl7 = (XRLabel)report.FindControl("xrlblFaizVeVergi", false);
                xrlbl7.Text = response.NcheckKapak.nitemFaizVergiOncesiKarZarar.TumYil.ToString("N2");



                var xrlbl8 = (XRLabel)report.FindControl("xrCaritablo", false);
                xrlbl8.Text = response.NcheckKapak.nitemCariOran.TumYil.ToString("N2");


                var xrlbl9 = (XRLabel)report.FindControl("xrLikiditetablo", false);
                xrlbl9.Text = response.NcheckKapak.nitemLikitideOran.TumYil.ToString("N2");

                var xrlbl10 = (XRLabel)report.FindControl("xrNakittablo", false);
                xrlbl10.Text = response.NcheckKapak.nitemNakitOran.TumYil.ToString("N2");



                var xrlbl14 = (XRLabel)report.FindControl("xrtoplamborcsermtablo", false);
                xrlbl14.Text = response.NcheckKapak.nitemBorcOzsermaye.TumYil.ToString("N2");

                var xrlbl15 = (XRLabel)report.FindControl("xrtoplambankaborcdevirtablo", false);
                xrlbl15.Text = response.NcheckKapak.nitemTpolamBankaBorc.TumYil.ToString("N2");

                var xrlbl16 = (XRLabel)report.FindControl("xrOzaynakaktifktablo", false);
                xrlbl16.Text = response.NcheckKapak.nitemOzkaynakAktif.TumYil.ToString("N2");

                var gauget = (XRGauge)report.FindControl("xrGauge1", false);
                gauget.TargetValue = response.NcheckKapak.nitemAltmanz.TumYil;

                var rShape1 = (XRShape)report.FindControl("xrShape1", false);
                rShape1.BackColor = Color.FromArgb(response.ShapeArgb1 ?? 0);

                var rShape2 = (XRShape)report.FindControl("xrShape2", false);
                rShape2.BackColor = Color.FromArgb(response.ShapeArgb2 ?? 0);

                var rShape3 = (XRShape)report.FindControl("xrShape3", false);
                rShape3.BackColor = Color.FromArgb(response.ShapeArgb3 ?? 0);



                var rShape7 = (XRShape)report.FindControl("xrShape7", false);
                rShape7.BackColor = Color.FromArgb(response.ShapeArgb7 ?? 0);

                var rShape8 = (XRShape)report.FindControl("xrShape8", false);
                rShape8.BackColor = Color.FromArgb(response.ShapeArgb8 ?? 0);

                var rShape9 = (XRShape)report.FindControl("xrShape9", false);
                rShape9.BackColor = Color.FromArgb(response.ShapeArgb9 ?? 0);
                report.PrintingSystem.Document.Name = "Balance_raporlar"; 
            }
            catch (Exception ex)
            {
                var tt = ex;
                response.Isfailed = true;

            }
            return report;

        }

        public static ReportFinancialdynamicb getReportMII(FinancialReportZonePayloadResponse response)
        {
            ReportFinancialdynamicb report = new ReportFinancialdynamicb();
            try
            {
                ObjectDataSource objectDataSource = new ObjectDataSource();
                objectDataSource.Name = "DataViewer";
                objectDataSource.DataSource = response.Ncheck;

                objectDataSource.Fill();

                ObjectDataSource objectDataSourceA = new ObjectDataSource();
                objectDataSourceA.Name = "DataViewerA";
                objectDataSourceA.DataSource = response.NcheckA;

                objectDataSourceA.Fill();

                ObjectDataSource objectDataSourceB = new ObjectDataSource();
                objectDataSourceB.Name = "DataViewerB";
                objectDataSourceB.DataSource = response.Ncheck1;

                objectDataSourceB.Fill();

                ObjectDataSource objectDataSourceC = new ObjectDataSource();
                objectDataSourceC.Name = "DataViewerC";
                objectDataSourceC.DataSource = response.Ncheck1a;

                objectDataSourceC.Fill();


                ObjectDataSource objectDataSourceD = new ObjectDataSource();
                objectDataSourceD.Name = "DataViewerD";
                objectDataSourceD.DataSource = response.NcheckD;

                objectDataSourceD.Fill();

                ObjectDataSource objectDataSourceE = new ObjectDataSource();
                objectDataSourceE.Name = "DataViewerE";
                objectDataSourceE.DataSource = response.NcheckE;

                objectDataSourceE.Fill();

                ObjectDataSource objectDataSourceF = new ObjectDataSource();
                objectDataSourceF.Name = "DataViewerF";
                objectDataSourceF.DataSource = response.NcheckF;

                objectDataSourceF.Fill();



                ObjectDataSource objectDataSourceG = new ObjectDataSource();
                objectDataSourceG.Name = "DataViewerG";
                objectDataSourceG.DataSource = response.NcheckG;
                objectDataSourceG.Fill();

                ObjectDataSource objectDataSourceT = new ObjectDataSource();
                objectDataSourceT.Name = "DataViewerT";
                objectDataSourceT.DataSource = response.NcheckLast;
                objectDataSourceT.Fill();

                DetailReportBand detailReport = report.Bands["DetailReport"] as DetailReportBand;



                DetailReportBand detailReport1 = report.Bands["DetailReport1"] as DetailReportBand;
                DetailReportBand detailReport2 = report.Bands["DetailReport2"] as DetailReportBand;
                DetailReportBand detailReport3 = report.Bands["DetailReport4"] as DetailReportBand;


                DetailReportBand detailReport11 = report.Bands["DetailReport11"] as DetailReportBand;
                DetailReportBand detailReport12 = report.Bands["DetailReport12"] as DetailReportBand;
                DetailReportBand detailReport13 = report.Bands["DetailReport13"] as DetailReportBand;
                DetailReportBand detailReport14 = report.Bands["DetailReport14"] as DetailReportBand;
                DetailReportBand detailReport15 = report.Bands["DetailReport15"] as DetailReportBand;

                report.xrCrossTab1.DataSource = objectDataSource;
                report.xrCrossTab2.DataSource = objectDataSourceA;
                report.xrCrossTab3.DataSource = objectDataSourceB;
                report.xrCrossTab4.DataSource = objectDataSourceC;
                report.xrCrossTab5.DataSource = objectDataSourceD;
                report.xrCrossTab6.DataSource = objectDataSourceE;
                report.xrCrossTab7.DataSource = objectDataSourceF;
                report.xrCrossTab8.DataSource = objectDataSourceG;
                report.xrCrossTab9.DataSource = objectDataSourceT;


                var chart = (XRChart)report.FindControl("xrChart1", false);
                chart.Series.Clear();
                chart.DataSource = response.NcheckChart;//Method from documentation you reffered
                chart.SeriesTemplate.SeriesDataMember = "GroupName";
                chart.SeriesTemplate.Label.TextPattern = "{V:n0}";
                chart.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var chart1 = (XRChart)report.FindControl("xrChart2", false);
                chart1.Series.Clear();
                chart1.DataSource = response.NcheckChartB;//Method from documentation you reffered
                chart1.SeriesTemplate.SeriesDataMember = "GroupName";
                chart1.SeriesTemplate.Label.TextPattern = "{V:n0}";
                chart1.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart1.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart3 = (XRChart)report.FindControl("xrChart3", false);
                chart3.Series.Clear();
                chart3.DataSource = response.NcheckChart1;//Method from documentation you reffered
                chart3.SeriesTemplate.SeriesDataMember = "GroupName";
                chart3.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart3.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart3.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart4 = (XRChart)report.FindControl("xrChart4", false);
                chart4.Series.Clear();
                chart4.DataSource = response.NcheckChart2;//Method from documentation you reffered
                chart4.SeriesTemplate.SeriesDataMember = "GroupName";
                chart4.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart4.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart4.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var chart5 = (XRChart)report.FindControl("xrChart5", false);
                chart5.Series.Clear();
                chart5.DataSource = response.NcheckChart3;//Method from documentation you reffered
                chart5.SeriesTemplate.SeriesDataMember = "GroupName";
                chart5.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart5.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart5.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart6 = (XRChart)report.FindControl("xrChart6", false);
                chart6.Series.Clear();
                chart6.DataSource = response.NcheckChart4;//Method from documentation you reffered
                chart6.SeriesTemplate.SeriesDataMember = "GroupName";
                chart6.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart6.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart6.SeriesTemplate.ValueDataMembers.AddRange("Value");

                report.xrLabel31.Text = response.Header;
                report.xrLabel29.Text = response.Nccode;
                var chart7 = (XRChart)report.FindControl("xrChart7", false);
                chart7.Series.Clear();
                chart7.DataSource = response.NcheckChart5;//Method from documentation you reffered
                chart7.SeriesTemplate.SeriesDataMember = "GroupName";
                chart7.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart7.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart7.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var chart8 = (XRChart)report.FindControl("xrChart8", false);
                chart8.Series.Clear();
                chart8.DataSource = response.NcheckChart6;//Method from documentation you reffered
                chart8.SeriesTemplate.SeriesDataMember = "GroupName";
                chart8.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart8.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart8.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart9 = (XRChart)report.FindControl("xrChart9", false);
                chart9.Series.Clear();
                chart9.DataSource = response.NcheckChart7;//Method from documentation you reffered
                chart9.SeriesTemplate.SeriesDataMember = "GroupName";
                chart9.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart9.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart9.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart10 = (XRChart)report.FindControl("xrChart10", false);
                chart10.Series.Clear();
                chart10.DataSource = response.NcheckChart8;//Method from documentation you reffered
                chart10.SeriesTemplate.SeriesDataMember = "GroupName";
                chart10.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart10.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart10.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart11 = (XRChart)report.FindControl("xrChart11", false);
                chart11.Series.Clear();
                chart11.DataSource = response.NcheckChart9;//Method from documentation you reffered
                chart11.SeriesTemplate.SeriesDataMember = "GroupName";
                chart11.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart11.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart11.SeriesTemplate.ValueDataMembers.AddRange("Value");



                var chart12 = (XRChart)report.FindControl("xrChart12", false);
                chart12.Series.Clear();
                chart12.DataSource = response.NcheckChart10;//Method from documentation you reffered
                chart12.SeriesTemplate.SeriesDataMember = "GroupName";
                chart12.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart12.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart12.SeriesTemplate.ValueDataMembers.AddRange("Value");



                var chart13 = (XRChart)report.FindControl("xrChart13", false);
                chart13.Series.Clear();
                chart13.DataSource = response.NcheckChart11;//Method from documentation you reffered
                chart13.SeriesTemplate.SeriesDataMember = "GroupName";
                chart13.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart13.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart13.SeriesTemplate.ValueDataMembers.AddRange("Value");

                //Color.FromArgb(182,33,45) red
                //Color.FromArgb(23, 127, 117) greeen
                var chart14 = (XRChart)report.FindControl("xrChart14", false);
                chart14.Series.Clear();
                chart14.DataSource = response.NcheckChart12;//Method from documentation you reffered
                chart14.SeriesTemplate.SeriesDataMember = "GroupName";
                chart14.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart14.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart14.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var xrlbl1 = (XRLabel)report.FindControl("xrLblOzkaynak", false);
                xrlbl1.Text = response.NcheckKapak.nitemOzkaynakAktif.TumYil.ToString("N2");

                var xrlbl2 = (XRLabel)report.FindControl("xrlblCarioran", false);
                xrlbl2.Text = response.NcheckKapak.nitemCariOran.TumYil.ToString("N2");


                var xrlbl3 = (XRLabel)report.FindControl("xrlblROA", false);
                xrlbl3.Text = (response.NcheckKapak.nitemROAAktifKarlilik.TumYil * 100).ToString("N2") + "%";



                var xrlbl5 = (XRLabel)report.FindControl("xrlblAltmanZ", false);
                xrlbl5.Text = response.NcheckKapak.nitemAltmanz.TumYil.ToString("N2");


                var xrlbl6 = (XRLabel)report.FindControl("xrlblNetIsletmeSerm", false);
                xrlbl6.Text = response.NcheckKapak.nitemNetIsletmeSermaye.TumYil.ToString("N0");


                var xrlbl7 = (XRLabel)report.FindControl("xrlblFaizVeVergi", false);
                xrlbl7.Text = response.NcheckKapak.nitemFaizVergiOncesiKarZarar.TumYil.ToString("N2");



                var xrlbl8 = (XRLabel)report.FindControl("xrCaritablo", false);
                xrlbl8.Text = response.NcheckKapak.nitemCariOran.TumYil.ToString("N2");


                var xrlbl9 = (XRLabel)report.FindControl("xrLikiditetablo", false);
                xrlbl9.Text = response.NcheckKapak.nitemLikitideOran.TumYil.ToString("N2");

                var xrlbl10 = (XRLabel)report.FindControl("xrNakittablo", false);
                xrlbl10.Text = response.NcheckKapak.nitemNakitOran.TumYil.ToString("N2");



                var xrlbl14 = (XRLabel)report.FindControl("xrtoplamborcsermtablo", false);
                xrlbl14.Text = response.NcheckKapak.nitemBorcOzsermaye.TumYil.ToString("N2");

                var xrlbl15 = (XRLabel)report.FindControl("xrtoplambankaborcdevirtablo", false);
                xrlbl15.Text = response.NcheckKapak.nitemTpolamBankaBorc.TumYil.ToString("N2");

                var xrlbl16 = (XRLabel)report.FindControl("xrOzaynakaktifktablo", false);
                xrlbl16.Text = response.NcheckKapak.nitemOzkaynakAktif.TumYil.ToString("N2");

                var gauget = (XRGauge)report.FindControl("xrGauge1", false);
                gauget.TargetValue = response.NcheckKapak.nitemAltmanz.TumYil;

                var rShape1 = (XRShape)report.FindControl("xrShape1", false);
                rShape1.BackColor = Color.FromArgb(response.ShapeArgb1 ?? 0);

                var rShape2 = (XRShape)report.FindControl("xrShape2", false);
                rShape2.BackColor = Color.FromArgb(response.ShapeArgb2 ?? 0);

                var rShape3 = (XRShape)report.FindControl("xrShape3", false);
                rShape3.BackColor = Color.FromArgb(response.ShapeArgb3 ?? 0);


                var rShape7 = (XRShape)report.FindControl("xrShape7", false);
                rShape7.BackColor = Color.FromArgb(response.ShapeArgb7 ?? 0);

                var rShape8 = (XRShape)report.FindControl("xrShape8", false);
                rShape8.BackColor = Color.FromArgb(response.ShapeArgb8 ?? 0);

                var rShape9 = (XRShape)report.FindControl("xrShape9", false);
                rShape9.BackColor = Color.FromArgb(response.ShapeArgb9 ?? 0);
                report.PrintingSystem.Document.Name = "Balance_raporlar";
            }
            catch (Exception ex)
            {
                var tt = ex;
                response.Isfailed = true;

            }
            return report;

        }

        public static ReportFinancialdynamic getReportMIII(FinancialReportZonePayloadResponse response)
        { 
            ReportFinancialdynamic report = new ReportFinancialdynamic();
            try
            {
                ObjectDataSource objectDataSource = new ObjectDataSource();
                objectDataSource.Name = "DataViewer";
                objectDataSource.DataSource = response.Ncheck;

                objectDataSource.Fill();

                ObjectDataSource objectDataSourceA = new ObjectDataSource();
                objectDataSourceA.Name = "DataViewerA";
                objectDataSourceA.DataSource = response.NcheckA;

                objectDataSourceA.Fill();

                ObjectDataSource objectDataSourceB = new ObjectDataSource();
                objectDataSourceB.Name = "DataViewerB";
                objectDataSourceB.DataSource = response.Ncheck1;

                objectDataSourceB.Fill();

                ObjectDataSource objectDataSourceC = new ObjectDataSource();
                objectDataSourceC.Name = "DataViewerC";
                objectDataSourceC.DataSource = response.Ncheck1a;

                objectDataSourceC.Fill();


                ObjectDataSource objectDataSourceD = new ObjectDataSource();
                objectDataSourceD.Name = "DataViewerD";
                objectDataSourceD.DataSource = response.NcheckD;

                objectDataSourceD.Fill();

                ObjectDataSource objectDataSourceE = new ObjectDataSource();
                objectDataSourceE.Name = "DataViewerE";
                objectDataSourceE.DataSource = response.NcheckE;

                objectDataSourceE.Fill();

                ObjectDataSource objectDataSourceF = new ObjectDataSource();
                objectDataSourceF.Name = "DataViewerF";
                objectDataSourceF.DataSource = response.NcheckF;

                objectDataSourceF.Fill();



                ObjectDataSource objectDataSourceG = new ObjectDataSource();
                objectDataSourceG.Name = "DataViewerG";
                objectDataSourceG.DataSource = response.NcheckG;
                objectDataSourceG.Fill();

                ObjectDataSource objectDataSourceT = new ObjectDataSource();
                objectDataSourceT.Name = "DataViewerT";
                objectDataSourceT.DataSource = response.NcheckLast;
                objectDataSourceT.Fill();

                DetailReportBand detailReport = report.Bands["DetailReport"] as DetailReportBand;



                DetailReportBand detailReport1 = report.Bands["DetailReport1"] as DetailReportBand;
                DetailReportBand detailReport2 = report.Bands["DetailReport2"] as DetailReportBand;
                DetailReportBand detailReport3 = report.Bands["DetailReport4"] as DetailReportBand;


                DetailReportBand detailReport11 = report.Bands["DetailReport11"] as DetailReportBand;
                DetailReportBand detailReport12 = report.Bands["DetailReport12"] as DetailReportBand;
                DetailReportBand detailReport13 = report.Bands["DetailReport13"] as DetailReportBand;
                DetailReportBand detailReport14 = report.Bands["DetailReport14"] as DetailReportBand;
                DetailReportBand detailReport15 = report.Bands["DetailReport15"] as DetailReportBand;
                //report.AddToDetailBand("DetailReport");
                //report.AddToDetailBand("DetailReport1");
                //report.AddToDetailBand("DetailReport2");
                //report.AddToDetailBand("DetailReport4");
                //report.AddToDetailBand("DetailReport11");
                //report.AddToDetailBand("DetailReport12");
                //report.AddToDetailBand("DetailReport13");
                //report.AddToDetailBand("DetailReport14");
                //report.AddToDetailBand("DetailReport15");
                report.xrCrossTab1.DataSource = objectDataSource;
                report.xrCrossTab2.DataSource = objectDataSourceA;
                report.xrCrossTab3.DataSource = objectDataSourceB;
                report.xrCrossTab4.DataSource = objectDataSourceC;
                report.xrCrossTab5.DataSource = objectDataSourceD;
                report.xrCrossTab6.DataSource = objectDataSourceE;
                report.xrCrossTab7.DataSource = objectDataSourceF;
                report.xrCrossTab8.DataSource = objectDataSourceG;
                report.xrCrossTab9.DataSource = objectDataSourceT;
                //  detailReport.DataSource = objectDataSource;
                //detailReport1.DataSource = objectDataSourceA;
                //detailReport2.DataSource = objectDataSourceB;
                //detailReport3.DataSource = objectDataSourceC;

                //detailReport11.DataSource = objectDataSourceD;
                //detailReport12.DataSource = objectDataSourceE;
                //detailReport13.DataSource = objectDataSourceF;
                //detailReport14.DataSource = objectDataSourceG;
                //detailReport15.DataSource = objectDataSourceT;

                var chart = (XRChart)report.FindControl("xrChart1", false);
                chart.Series.Clear();
                chart.DataSource = response.NcheckChart;//Method from documentation you reffered
                chart.SeriesTemplate.SeriesDataMember = "GroupName";
                chart.SeriesTemplate.Label.TextPattern = "{V:n0}";
                chart.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var chart1 = (XRChart)report.FindControl("xrChart2", false);
                chart1.Series.Clear();
                chart1.DataSource = response.NcheckChartB;//Method from documentation you reffered
                chart1.SeriesTemplate.SeriesDataMember = "GroupName";
                chart1.SeriesTemplate.Label.TextPattern = "{V:n0}";
                chart1.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart1.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart3 = (XRChart)report.FindControl("xrChart3", false);
                chart3.Series.Clear();
                chart3.DataSource = response.NcheckChart1;//Method from documentation you reffered
                chart3.SeriesTemplate.SeriesDataMember = "GroupName";
                chart3.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart3.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart3.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart4 = (XRChart)report.FindControl("xrChart4", false);
                chart4.Series.Clear();
                chart4.DataSource = response.NcheckChart2;//Method from documentation you reffered
                chart4.SeriesTemplate.SeriesDataMember = "GroupName";
                chart4.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart4.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart4.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var chart5 = (XRChart)report.FindControl("xrChart5", false);
                chart5.Series.Clear();
                chart5.DataSource = response.NcheckChart3;//Method from documentation you reffered
                chart5.SeriesTemplate.SeriesDataMember = "GroupName";
                chart5.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart5.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart5.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart6 = (XRChart)report.FindControl("xrChart6", false);
                chart6.Series.Clear();
                chart6.DataSource = response.NcheckChart4;//Method from documentation you reffered
                chart6.SeriesTemplate.SeriesDataMember = "GroupName";
                chart6.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart6.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart6.SeriesTemplate.ValueDataMembers.AddRange("Value");

                report.xrLabel31.Text = response.Header;
                report.xrLabel29.Text = response.Nccode;
                var chart7 = (XRChart)report.FindControl("xrChart7", false);
                chart7.Series.Clear();
                chart7.DataSource = response.NcheckChart5;//Method from documentation you reffered
                chart7.SeriesTemplate.SeriesDataMember = "GroupName";
                chart7.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart7.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart7.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var chart8 = (XRChart)report.FindControl("xrChart8", false);
                chart8.Series.Clear();
                chart8.DataSource = response.NcheckChart6;//Method from documentation you reffered
                chart8.SeriesTemplate.SeriesDataMember = "GroupName";
                chart8.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart8.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart8.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart9 = (XRChart)report.FindControl("xrChart9", false);
                chart9.Series.Clear();
                chart9.DataSource = response.NcheckChart7;//Method from documentation you reffered
                chart9.SeriesTemplate.SeriesDataMember = "GroupName";
                chart9.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart9.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart9.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart10 = (XRChart)report.FindControl("xrChart10", false);
                chart10.Series.Clear();
                chart10.DataSource = response.NcheckChart8;//Method from documentation you reffered
                chart10.SeriesTemplate.SeriesDataMember = "GroupName";
                chart10.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart10.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart10.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart11 = (XRChart)report.FindControl("xrChart11", false);
                chart11.Series.Clear();
                chart11.DataSource = response.NcheckChart9;//Method from documentation you reffered
                chart11.SeriesTemplate.SeriesDataMember = "GroupName";
                chart11.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart11.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart11.SeriesTemplate.ValueDataMembers.AddRange("Value");



                var chart12 = (XRChart)report.FindControl("xrChart12", false);
                chart12.Series.Clear();
                chart12.DataSource = response.NcheckChart10;//Method from documentation you reffered
                chart12.SeriesTemplate.SeriesDataMember = "GroupName";
                chart12.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart12.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart12.SeriesTemplate.ValueDataMembers.AddRange("Value");



                var chart13 = (XRChart)report.FindControl("xrChart13", false);
                chart13.Series.Clear();
                chart13.DataSource = response.NcheckChart11;//Method from documentation you reffered
                chart13.SeriesTemplate.SeriesDataMember = "GroupName";
                chart13.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart13.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart13.SeriesTemplate.ValueDataMembers.AddRange("Value");

                //Color.FromArgb(182,33,45) red
                //Color.FromArgb(23, 127, 117) greeen
                var chart14 = (XRChart)report.FindControl("xrChart14", false);
                chart14.Series.Clear();
                chart14.DataSource = response.NcheckChart12;//Method from documentation you reffered
                chart14.SeriesTemplate.SeriesDataMember = "GroupName";
                chart14.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart14.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart14.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var xrlbl1 = (XRLabel)report.FindControl("xrLblOzkaynak", false);
                xrlbl1.Text = response.NcheckKapak.nitemOzkaynakAktif.TumYil.ToString("N2");

                var xrlbl2 = (XRLabel)report.FindControl("xrlblCarioran", false);
                xrlbl2.Text = response.NcheckKapak.nitemCariOran.TumYil.ToString("N2");


                var xrlbl3 = (XRLabel)report.FindControl("xrlblROA", false);
                xrlbl3.Text = (response.NcheckKapak.nitemROAAktifKarlilik.TumYil * 100).ToString("N2") + "%";



                var xrlbl5 = (XRLabel)report.FindControl("xrlblAltmanZ", false);
                xrlbl5.Text = response.NcheckKapak.nitemAltmanz.TumYil.ToString("N2");


                var xrlbl6 = (XRLabel)report.FindControl("xrlblNetIsletmeSerm", false);
                xrlbl6.Text = response.NcheckKapak.nitemNetIsletmeSermaye.TumYil.ToString("N0");


                var xrlbl7 = (XRLabel)report.FindControl("xrlblFaizVeVergi", false);
                xrlbl7.Text = response.NcheckKapak.nitemFaizVergiOncesiKarZarar.TumYil.ToString("N2");



                var xrlbl8 = (XRLabel)report.FindControl("xrCaritablo", false);
                xrlbl8.Text = response.NcheckKapak.nitemCariOran.TumYil.ToString("N2");


                var xrlbl9 = (XRLabel)report.FindControl("xrLikiditetablo", false);
                xrlbl9.Text = response.NcheckKapak.nitemLikitideOran.TumYil.ToString("N2");

                var xrlbl10 = (XRLabel)report.FindControl("xrNakittablo", false);
                xrlbl10.Text = response.NcheckKapak.nitemNakitOran.TumYil.ToString("N2");



                var xrlbl14 = (XRLabel)report.FindControl("xrtoplamborcsermtablo", false);
                xrlbl14.Text = response.NcheckKapak.nitemBorcOzsermaye.TumYil.ToString("N2");

                var xrlbl15 = (XRLabel)report.FindControl("xrtoplambankaborcdevirtablo", false);
                xrlbl15.Text = response.NcheckKapak.nitemTpolamBankaBorc.TumYil.ToString("N2");

                var xrlbl16 = (XRLabel)report.FindControl("xrOzaynakaktifktablo", false);
                xrlbl16.Text = response.NcheckKapak.nitemOzkaynakAktif.TumYil.ToString("N2");

                var gauget = (XRGauge)report.FindControl("xrGauge1", false);
                gauget.TargetValue = response.NcheckKapak.nitemAltmanz.TumYil;

                var rShape1 = (XRShape)report.FindControl("xrShape1", false);
                rShape1.BackColor = Color.FromArgb(response.ShapeArgb1 ?? 0);

                var rShape2 = (XRShape)report.FindControl("xrShape2", false);
                rShape2.BackColor = Color.FromArgb(response.ShapeArgb2 ?? 0);

                var rShape3 = (XRShape)report.FindControl("xrShape3", false);
                rShape3.BackColor = Color.FromArgb(response.ShapeArgb3 ?? 0);



                var rShape7 = (XRShape)report.FindControl("xrShape7", false);
                rShape7.BackColor = Color.FromArgb(response.ShapeArgb7 ?? 0);

                var rShape8 = (XRShape)report.FindControl("xrShape8", false);
                rShape8.BackColor = Color.FromArgb(response.ShapeArgb8 ?? 0);

                var rShape9 = (XRShape)report.FindControl("xrShape9", false);
                rShape9.BackColor = Color.FromArgb(response.ShapeArgb9 ?? 0);
                report.PrintingSystem.Document.Name = "Balance_raporlar";
            }
            catch (Exception ex)
            {
                var tt = ex;
                response.Isfailed = true;

            }
            return report;

        }
        public static ReportFinancialdynamicd getReportMIV(FinancialReportZonePayloadResponse response)
        { 
            ReportFinancialdynamicd report = new ReportFinancialdynamicd();
            try
            {
 
                ObjectDataSource objectDataSource = new ObjectDataSource();
                objectDataSource.Name = "DataViewer";
                objectDataSource.DataSource = response.Ncheck;

                objectDataSource.Fill();

                ObjectDataSource objectDataSourceA = new ObjectDataSource();
                objectDataSourceA.Name = "DataViewerA";
                objectDataSourceA.DataSource = response.NcheckA;

                objectDataSourceA.Fill();

                ObjectDataSource objectDataSourceB = new ObjectDataSource();
                objectDataSourceB.Name = "DataViewerB";
                objectDataSourceB.DataSource = response.Ncheck1;

                objectDataSourceB.Fill();

                ObjectDataSource objectDataSourceC = new ObjectDataSource();
                objectDataSourceC.Name = "DataViewerC";
                objectDataSourceC.DataSource = response.Ncheck1a;

                objectDataSourceC.Fill();


                ObjectDataSource objectDataSourceD = new ObjectDataSource();
                objectDataSourceD.Name = "DataViewerD";
                objectDataSourceD.DataSource = response.NcheckD;

                objectDataSourceD.Fill();

                ObjectDataSource objectDataSourceE = new ObjectDataSource();
                objectDataSourceE.Name = "DataViewerE";
                objectDataSourceE.DataSource = response.NcheckE;

                objectDataSourceE.Fill();

                ObjectDataSource objectDataSourceF = new ObjectDataSource();
                objectDataSourceF.Name = "DataViewerF";
                objectDataSourceF.DataSource = response.NcheckF;

                objectDataSourceF.Fill();



                ObjectDataSource objectDataSourceG = new ObjectDataSource();
                objectDataSourceG.Name = "DataViewerG";
                objectDataSourceG.DataSource = response.NcheckG;
                objectDataSourceG.Fill();

                ObjectDataSource objectDataSourceT = new ObjectDataSource();
                objectDataSourceT.Name = "DataViewerT";
                objectDataSourceT.DataSource = response.NcheckLast;
                objectDataSourceT.Fill();

                DetailReportBand detailReport = report.Bands["DetailReport"] as DetailReportBand;



                DetailReportBand detailReport1 = report.Bands["DetailReport1"] as DetailReportBand;
                DetailReportBand detailReport2 = report.Bands["DetailReport2"] as DetailReportBand;
                DetailReportBand detailReport3 = report.Bands["DetailReport4"] as DetailReportBand;


                DetailReportBand detailReport11 = report.Bands["DetailReport11"] as DetailReportBand;
                DetailReportBand detailReport12 = report.Bands["DetailReport12"] as DetailReportBand;
                DetailReportBand detailReport13 = report.Bands["DetailReport13"] as DetailReportBand;
                DetailReportBand detailReport14 = report.Bands["DetailReport14"] as DetailReportBand;
                DetailReportBand detailReport15 = report.Bands["DetailReport15"] as DetailReportBand;
                //report.AddToDetailBand("DetailReport");
                //report.AddToDetailBand("DetailReport1");
                //report.AddToDetailBand("DetailReport2");
                //report.AddToDetailBand("DetailReport4");
                //report.AddToDetailBand("DetailReport11");
                //report.AddToDetailBand("DetailReport12");
                //report.AddToDetailBand("DetailReport13");
                //report.AddToDetailBand("DetailReport14");
                //report.AddToDetailBand("DetailReport15");
                report.xrCrossTab1.DataSource = objectDataSource;
                report.xrCrossTab2.DataSource = objectDataSourceA;
                report.xrCrossTab3.DataSource = objectDataSourceB;
                report.xrCrossTab4.DataSource = objectDataSourceC;
                report.xrCrossTab5.DataSource = objectDataSourceD;
                report.xrCrossTab6.DataSource = objectDataSourceE;
                report.xrCrossTab7.DataSource = objectDataSourceF;
                report.xrCrossTab8.DataSource = objectDataSourceG;
                report.xrCrossTab9.DataSource = objectDataSourceT;
                //  detailReport.DataSource = objectDataSource;
                //detailReport1.DataSource = objectDataSourceA;
                //detailReport2.DataSource = objectDataSourceB;
                //detailReport3.DataSource = objectDataSourceC;

                //detailReport11.DataSource = objectDataSourceD;
                //detailReport12.DataSource = objectDataSourceE;
                //detailReport13.DataSource = objectDataSourceF;
                //detailReport14.DataSource = objectDataSourceG;
                //detailReport15.DataSource = objectDataSourceT;

                var chart = (XRChart)report.FindControl("xrChart1", false);
                chart.Series.Clear();
                chart.DataSource = response.NcheckChart;//Method from documentation you reffered
                chart.SeriesTemplate.SeriesDataMember = "GroupName";
                chart.SeriesTemplate.Label.TextPattern = "{V:n0}";
                chart.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var chart1 = (XRChart)report.FindControl("xrChart2", false);
                chart1.Series.Clear();
                chart1.DataSource = response.NcheckChartB;//Method from documentation you reffered
                chart1.SeriesTemplate.SeriesDataMember = "GroupName";
                chart1.SeriesTemplate.Label.TextPattern = "{V:n0}";
                chart1.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart1.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart3 = (XRChart)report.FindControl("xrChart3", false);
                chart3.Series.Clear();
                chart3.DataSource = response.NcheckChart1;//Method from documentation you reffered
                chart3.SeriesTemplate.SeriesDataMember = "GroupName";
                chart3.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart3.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart3.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart4 = (XRChart)report.FindControl("xrChart4", false);
                chart4.Series.Clear();
                chart4.DataSource = response.NcheckChart2;//Method from documentation you reffered
                chart4.SeriesTemplate.SeriesDataMember = "GroupName";
                chart4.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart4.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart4.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var chart5 = (XRChart)report.FindControl("xrChart5", false);
                chart5.Series.Clear();
                chart5.DataSource = response.NcheckChart3;//Method from documentation you reffered
                chart5.SeriesTemplate.SeriesDataMember = "GroupName";
                chart5.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart5.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart5.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart6 = (XRChart)report.FindControl("xrChart6", false);
                chart6.Series.Clear();
                chart6.DataSource = response.NcheckChart4;//Method from documentation you reffered
                chart6.SeriesTemplate.SeriesDataMember = "GroupName";
                chart6.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart6.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart6.SeriesTemplate.ValueDataMembers.AddRange("Value");

                report.xrLabel31.Text = response.Header;
                report.xrLabel29.Text = response.Nccode;
                var chart7 = (XRChart)report.FindControl("xrChart7", false);
                chart7.Series.Clear();
                chart7.DataSource = response.NcheckChart5;//Method from documentation you reffered
                chart7.SeriesTemplate.SeriesDataMember = "GroupName";
                chart7.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart7.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart7.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var chart8 = (XRChart)report.FindControl("xrChart8", false);
                chart8.Series.Clear();
                chart8.DataSource = response.NcheckChart6;//Method from documentation you reffered
                chart8.SeriesTemplate.SeriesDataMember = "GroupName";
                chart8.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart8.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart8.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart9 = (XRChart)report.FindControl("xrChart9", false);
                chart9.Series.Clear();
                chart9.DataSource = response.NcheckChart7;//Method from documentation you reffered
                chart9.SeriesTemplate.SeriesDataMember = "GroupName";
                chart9.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart9.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart9.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart10 = (XRChart)report.FindControl("xrChart10", false);
                chart10.Series.Clear();
                chart10.DataSource = response.NcheckChart8;//Method from documentation you reffered
                chart10.SeriesTemplate.SeriesDataMember = "GroupName";
                chart10.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart10.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart10.SeriesTemplate.ValueDataMembers.AddRange("Value");


                var chart11 = (XRChart)report.FindControl("xrChart11", false);
                chart11.Series.Clear();
                chart11.DataSource = response.NcheckChart9;//Method from documentation you reffered
                chart11.SeriesTemplate.SeriesDataMember = "GroupName";
                chart11.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart11.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart11.SeriesTemplate.ValueDataMembers.AddRange("Value");



                var chart12 = (XRChart)report.FindControl("xrChart12", false);
                chart12.Series.Clear();
                chart12.DataSource = response.NcheckChart10;//Method from documentation you reffered
                chart12.SeriesTemplate.SeriesDataMember = "GroupName";
                chart12.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart12.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart12.SeriesTemplate.ValueDataMembers.AddRange("Value");



                var chart13 = (XRChart)report.FindControl("xrChart13", false);
                chart13.Series.Clear();
                chart13.DataSource = response.NcheckChart11;//Method from documentation you reffered
                chart13.SeriesTemplate.SeriesDataMember = "GroupName";
                chart13.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart13.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart13.SeriesTemplate.ValueDataMembers.AddRange("Value");

                //Color.FromArgb(182,33,45) red
                //Color.FromArgb(23, 127, 117) greeen
                var chart14 = (XRChart)report.FindControl("xrChart14", false);
                chart14.Series.Clear();
                chart14.DataSource = response.NcheckChart12;//Method from documentation you reffered
                chart14.SeriesTemplate.SeriesDataMember = "GroupName";
                chart14.SeriesTemplate.ArgumentDataMember = "GroupText";
                chart14.SeriesTemplate.Label.TextPattern = "{V:n2}";
                chart14.SeriesTemplate.ValueDataMembers.AddRange("Value");

                var xrlbl1 = (XRLabel)report.FindControl("xrLblOzkaynak", false);
                xrlbl1.Text = response.NcheckKapak.nitemOzkaynakAktif.TumYil.ToString("N2");

                var xrlbl2 = (XRLabel)report.FindControl("xrlblCarioran", false);
                xrlbl2.Text = response.NcheckKapak.nitemCariOran.TumYil.ToString("N2");


                var xrlbl3 = (XRLabel)report.FindControl("xrlblROA", false);
                xrlbl3.Text = (response.NcheckKapak.nitemROAAktifKarlilik.TumYil * 100).ToString("N2") + "%";



                var xrlbl5 = (XRLabel)report.FindControl("xrlblAltmanZ", false);
                xrlbl5.Text = response.NcheckKapak.nitemAltmanz.TumYil.ToString("N2");


                var xrlbl6 = (XRLabel)report.FindControl("xrlblNetIsletmeSerm", false);
                xrlbl6.Text = response.NcheckKapak.nitemNetIsletmeSermaye.TumYil.ToString("N0");


                var xrlbl7 = (XRLabel)report.FindControl("xrlblFaizVeVergi", false);
                xrlbl7.Text = response.NcheckKapak.nitemFaizVergiOncesiKarZarar.TumYil.ToString("N2");



                var xrlbl8 = (XRLabel)report.FindControl("xrCaritablo", false);
                xrlbl8.Text = response.NcheckKapak.nitemCariOran.TumYil.ToString("N2");


                var xrlbl9 = (XRLabel)report.FindControl("xrLikiditetablo", false);
                xrlbl9.Text = response.NcheckKapak.nitemLikitideOran.TumYil.ToString("N2");

                var xrlbl10 = (XRLabel)report.FindControl("xrNakittablo", false);
                xrlbl10.Text = response.NcheckKapak.nitemNakitOran.TumYil.ToString("N2");



                var xrlbl14 = (XRLabel)report.FindControl("xrtoplamborcsermtablo", false);
                xrlbl14.Text = response.NcheckKapak.nitemBorcOzsermaye.TumYil.ToString("N2");

                var xrlbl15 = (XRLabel)report.FindControl("xrtoplambankaborcdevirtablo", false);
                xrlbl15.Text = response.NcheckKapak.nitemTpolamBankaBorc.TumYil.ToString("N2");

                var xrlbl16 = (XRLabel)report.FindControl("xrOzaynakaktifktablo", false);
                xrlbl16.Text = response.NcheckKapak.nitemOzkaynakAktif.TumYil.ToString("N2");

                var gauget = (XRGauge)report.FindControl("xrGauge1", false);
                gauget.TargetValue = response.NcheckKapak.nitemAltmanz.TumYil;

                var rShape1 = (XRShape)report.FindControl("xrShape1", false);
                rShape1.BackColor = Color.FromArgb(response.ShapeArgb1 ?? 0);

                var rShape2 = (XRShape)report.FindControl("xrShape2", false);
                rShape2.BackColor = Color.FromArgb(response.ShapeArgb2 ?? 0);

                var rShape3 = (XRShape)report.FindControl("xrShape3", false);
                rShape3.BackColor = Color.FromArgb(response.ShapeArgb3 ?? 0);



                var rShape7 = (XRShape)report.FindControl("xrShape7", false);
                rShape7.BackColor = Color.FromArgb(response.ShapeArgb7 ?? 0);

                var rShape8 = (XRShape)report.FindControl("xrShape8", false);
                rShape8.BackColor = Color.FromArgb(response.ShapeArgb8 ?? 0);

                var rShape9 = (XRShape)report.FindControl("xrShape9", false);
                rShape9.BackColor = Color.FromArgb(response.ShapeArgb9 ?? 0);
                report.PrintingSystem.Document.Name = "Balance_raporlar";
            }
            catch (Exception ex)
            {
                var tt = ex;
                response.Isfailed = true;

            }
            return report;

        }
    }
}
