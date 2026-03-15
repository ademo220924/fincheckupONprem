using System;
using System.Collections.Generic;
using System.Linq;

namespace fincheckup.Models.NKolay.MizanView
{
    public class DashGelirTablosuMizanDefter
    {
        public static List<DashBilancoViewMizan> getList(int _year, long _compID)
        {
            DashGelirTablosuViewT nCheckdefter = new DashGelirTablosuViewT();
            nCheckdefter.SetBilancoHeaderT(DashGelirTablosuSet.Get_BrutStsT(_year, _compID), "A-Brüt Satışlar", 60, 1);
            nCheckdefter.SetBilanco(DashGelirTablosuSet.Get_BrutSts(_year, _compID), "A-Brüt Satışlar", 0);

            nCheckdefter.SetBilancoHeaderT(DashGelirTablosuSet.Get_StsIndirimT(_year, _compID), "B-Satış Indirimleri(-)", 61, 1);
            nCheckdefter.SetBilanco(DashGelirTablosuSet.Get_StsIndirim(_year, _compID), "B-Satış Indirimleri(-)", 0);

            nCheckdefter.SetBilancoHeaderT(DashGelirTablosuSet.Get_NetStsT(_year, _compID), "C-Net Satışlar", 111, 0);


            nCheckdefter.SetBilancoHeaderT(DashGelirTablosuSet.Get_StsMlytT(_year, _compID), "D-Satışların Maliyeti (-)", 62, 1);
            nCheckdefter.SetBilanco(DashGelirTablosuSet.Get_StsMlyt(_year, _compID), "D-Satışların Maliyeti (-)", 0);

            nCheckdefter.SetBilancoHeaderT(DashGelirTablosuSet.Get_BrutKarZararT(_year, _compID), "E-Brüt Kar/Zararı", 222, 0);
            nCheckdefter.SetBilanco(DashGelirTablosuSet.Get_ESMMGenel(_year, _compID), "E-SMM Satışların Maliyeti (Mizanda 7'li Gruplarda Bekleyen)", 0);

            nCheckdefter.SetBilancoHeaderT(DashGelirTablosuSet.Get_GenelYonGiderTV3(_year, _compID), "F-Genel Yönetim Giderleri (-)", 333, 0);

            nCheckdefter.SetBilancoHeaderT(DashGelirTablosuSet.Get_PazarlamaGiderT(_year, _compID), "G-Pazarlama Giderleri (-)", 444, 0);

            nCheckdefter.SetBilancoHeaderT(DashGelirTablosuSet.Get_ArGeGiderT(_year, _compID), "H-Araştırma ve Geliştirme Giderleri (-)", 555, 0);

            //nCheck.SetBilancoHeaderT(DashGelirTablosu.Get_FinansmanGiderT(_year, _compID), "I-Finasnman Giderleri", 777, 0);

            nCheckdefter.SetBilancoHeaderT(DashGelirTablosuSet.Get_EsasMaliyetKarZararTV3(_year, _compID), "J-Esas Faaliyet Karı/Zararı", 888, 0);

            nCheckdefter.SetBilancoHeaderT(DashGelirTablosuSet.Get_DigerFalGelT(_year, _compID), "K-DİĞER FAALİYETLERDEN OLAĞAN GELİR VE KARLAR", 999, 1);
            nCheckdefter.SetBilanco(DashGelirTablosuSet.Get_DigerFalGel(_year, _compID), "K-DİĞER FAALİYETLERDEN OLAĞAN GELİR VE KARLAR", 0);

            nCheckdefter.SetBilancoHeaderT(DashGelirTablosuSet.Get_DigerFalGidrT(_year, _compID), "L-DİĞER FAALİYETLERDEN OLAĞAN GİDER VE ZARARLAR", 1111, 1);
            nCheckdefter.SetBilanco(DashGelirTablosuSet.Get_DigerFalGidr(_year, _compID), "L-DİĞER FAALİYETLERDEN OLAĞAN GİDER VE ZARARLAR", 0);

            nCheckdefter.SetBilancoHeaderT(DashGelirTablosuSet.Get_FaaliyetKarZaraT(_year, _compID), "M-FİNANSMAN GİDERİ ÖNCESİ FAALİYET KARI ZARARI", 2222, 0);

            nCheckdefter.SetBilancoHeaderT(DashGelirTablosuSet.Get_FinansmanGidrTV3(_year, _compID), "N-Finansman Giderleri", 3333, 0);

            nCheckdefter.SetBilancoHeaderT(DashGelirTablosuSet.Get_OlaganKarZaraT(_year, _compID), "O-OLAĞAN KAR VEYA  ZARAR", 4444, 0);

            nCheckdefter.SetBilancoHeaderT(DashGelirTablosuSet.Get_OlaganDisiGelrT(_year, _compID), "V-OLAĞANDIŞI GELIR VE KARLAR", 5555, 1);
            nCheckdefter.SetBilanco(DashGelirTablosuSet.Get_OlaganDisiGelr(_year, _compID), "V-OLAĞANDIŞI GELIR VE KARLAR", 0);

            nCheckdefter.SetBilancoHeaderT(DashGelirTablosuSet.Get_OlaganDisiGdrT(_year, _compID), "Y-OLAĞANDIŞI GİDER VE ZARARLAR", 7777, 1);
            nCheckdefter.SetBilanco(DashGelirTablosuSet.Get_OlaganDisiGdr(_year, _compID), "Y-OLAĞANDIŞI GİDER VE ZARARLAR", 0);

            nCheckdefter.SetBilancoHeaderT(DashGelirTablosuSet.Get_DonemKarZaraTV3(_year, _compID), "Z-DÖNEM KARI/ZARARI", 9991, 0);
            nCheckdefter.SetBilancoHeaderT(DashGelirTablosuSet.Get_OlaganDisiGdrYkmllk(_year, _compID), "Z1-DÖNEM KARI VERGİ VE DİĞ.YASAL YÜKÜMLÜLÜK KARŞILIĞI", 9993, 0);
            nCheckdefter.SetBilancoHeaderT(DashGelirTablosuSet.Get_DonemKarZaraTNetV3(_year, _compID), "ZT-DÖNEM NET KARI/ZARARI", 9995, 0);

            return nCheckdefter.mrequestEntry;
        }
    }

    public class DashGelirTablosuBeyan
    {
        public static List<DashBilancoViewMizan> getList(int _year, long _compID)
        {
            DashGelirTablosuViewT nCheck = new DashGelirTablosuViewT();
            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_BrutStsT(_year, _compID), "A-Brüt Satışlar", 60, 1);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_BrutSts(_year, _compID), "A-Brüt Satışlar", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_StsIndirimT(_year, _compID), "B-Satış Indirimleri(-)", 61, 1);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_StsIndirim(_year, _compID), "B-Satış Indirimleri(-)", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_NetStsT(_year, _compID), "C-Net Satışlar", 111, 0);


            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_StsMlytT(_year, _compID), "D-Satışların Maliyeti (-)", 62, 1);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_StsMlyt(_year, _compID), "D-Satışların Maliyeti (-)", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_BrutKarZararT(_year, _compID), "E-Brüt Kar/Zararı", 222, 0);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_ESMMGenel(_year, _compID), "E-SMM Satışların Maliyeti (Mizanda 7'li Gruplarda Bekleyen)", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_GenelYonGiderT(_year, _compID), "F-Genel Yönetim Giderleri (-)", 333, 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_PazarlamaGiderT(_year, _compID), "G-Pazarlama Giderleri (-)", 444, 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_ArGeGiderT(_year, _compID), "H-Araştırma ve Geliştirme Giderleri (-)", 555, 0);

            //nCheck.SetBilancoHeaderT(DashGelirTablosu.Get_FinansmanGiderT(_year, _compID), "I-Finasnman Giderleri", 777, 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_EsasMaliyetKarZararT(_year, _compID), "J-Esas Faaliyet Karı/Zararı", 888, 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_DigerFalGelT(_year, _compID), "K-DİĞER FAALİYETLERDEN OLAĞAN GELİR VE KARLAR", 999, 1);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_DigerFalGel(_year, _compID), "K-DİĞER FAALİYETLERDEN OLAĞAN GELİR VE KARLAR", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_DigerFalGidrT(_year, _compID), "L-DİĞER FAALİYETLERDEN OLAĞAN GİDER VE ZARARLAR", 1111, 1);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_DigerFalGidr(_year, _compID), "L-DİĞER FAALİYETLERDEN OLAĞAN GİDER VE ZARARLAR", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_FaaliyetKarZaraT(_year, _compID), "M-FİNANSMAN GİDERİ ÖNCESİ FAALİYET KARI ZARARI", 2222, 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_FinansmanGidrT(_year, _compID), "N-Finansman Giderleri", 3333, 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_OlaganKarZaraT(_year, _compID), "O-OLAĞAN KAR VEYA  ZARAR", 4444, 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_OlaganDisiGelrT(_year, _compID), "V-OLAĞANDIŞI GELIR VE KARLAR", 5555, 1);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_OlaganDisiGelr(_year, _compID), "V-OLAĞANDIŞI GELIR VE KARLAR", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_OlaganDisiGdrT(_year, _compID), "Y-OLAĞANDIŞI GİDER VE ZARARLAR", 7777, 1);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_OlaganDisiGdr(_year, _compID), "Y-OLAĞANDIŞI GİDER VE ZARARLAR", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_DonemKarZaraT(_year, _compID), "Z-DÖNEM KARI/ZARARI", 9991, 0);
            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_OlaganDisiGdrYkmllk(_year, _compID), "Z1-DÖNEM KARI VERGİ VE DİĞ.YASAL YÜKÜMLÜLÜK KARŞILIĞI", 9993, 0);
            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_DonemKarZaraTNet(_year, _compID), "ZT-DÖNEM NET KARI/ZARARI", 9995, 0);

            return nCheck.mrequestEntry;
        }
    }
    public class DashGelirTablosuMizan
    {
        public static List<DashBilancoViewMizan> getListBYN(int _year, long _compID)
        {
            DashGelirTablosuViewT nCheck = new DashGelirTablosuViewT();
            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_BrutStsT(_year, _compID), "A-Brüt Satışlar", 60, 1);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_BrutSts(_year, _compID), "A-Brüt Satışlar", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_StsIndirimT(_year, _compID), "B-Satış Indirimleri(-)", 61, 1);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_StsIndirim(_year, _compID), "B-Satış Indirimleri(-)", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_NetStsT(_year, _compID), "C-Net Satışlar", 111, 0);


            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_StsMlytT(_year, _compID), "D-Satışların Maliyeti (-)", 62, 1);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_StsMlyt(_year, _compID), "D-Satışların Maliyeti (-)", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_BrutKarZararT(_year, _compID), "E-Brüt Kar/Zararı", 222, 0);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_ESMMGenel(_year, _compID), "E-SMM Satışların Maliyeti (Mizanda 7'li Gruplarda Bekleyen)", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_GenelYonGiderT(_year, _compID), "F-Genel Yönetim Giderleri (-)", 333, 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_PazarlamaGiderT(_year, _compID), "G-Pazarlama Giderleri (-)", 444, 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_ArGeGiderT(_year, _compID), "H-Araştırma ve Geliştirme Giderleri (-)", 555, 0);

            //nCheck.SetBilancoHeaderT(DashGelirTablosu.Get_FinansmanGiderT(_year, _compID), "I-Finasnman Giderleri", 777, 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_EsasMaliyetKarZararT(_year, _compID), "J-Esas Faaliyet Karı/Zararı", 888, 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_DigerFalGelT(_year, _compID), "K-DİĞER FAALİYETLERDEN OLAĞAN GELİR VE KARLAR", 999, 1);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_DigerFalGel(_year, _compID), "K-DİĞER FAALİYETLERDEN OLAĞAN GELİR VE KARLAR", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_DigerFalGidrT(_year, _compID), "L-DİĞER FAALİYETLERDEN OLAĞAN GİDER VE ZARARLAR", 1111, 1);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_DigerFalGidr(_year, _compID), "L-DİĞER FAALİYETLERDEN OLAĞAN GİDER VE ZARARLAR", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_FaaliyetKarZaraT(_year, _compID), "M-FİNANSMAN GİDERİ ÖNCESİ FAALİYET KARI ZARARI", 2222, 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_FinansmanGidrT(_year, _compID), "N-Finansman Giderleri", 3333, 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_OlaganKarZaraT(_year, _compID), "O-OLAĞAN KAR VEYA  ZARAR", 4444, 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_OlaganDisiGelrT(_year, _compID), "V-OLAĞANDIŞI GELIR VE KARLAR", 5555, 1);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_OlaganDisiGelr(_year, _compID), "V-OLAĞANDIŞI GELIR VE KARLAR", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_OlaganDisiGdrT(_year, _compID), "Y-OLAĞANDIŞI GİDER VE ZARARLAR", 7777, 1);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_OlaganDisiGdr(_year, _compID), "Y-OLAĞANDIŞI GİDER VE ZARARLAR", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_OlaganKarZaraTByn(_year, _compID), "Z-DÖNEM KARI/ZARARI", 9991, 0);
            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_OlaganDisiGdrYkmllk(_year, _compID), "Z1-DÖNEM KARI VERGİ VE DİĞ.YASAL YÜKÜMLÜLÜK KARŞILIĞI", 9993, 0);
            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_DonemKarZaraTNetByn(_year, _compID), "ZT-DÖNEM NET KARI/ZARARI", 9995, 0);

            return nCheck.mrequestEntry;
        }
        public static List<DashBilancoViewMizan> getList(int _year, long _compID)
        {
            DashGelirTablosuViewT nCheck = new DashGelirTablosuViewT();
            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_BrutStsT(_year, _compID), "A-Brüt Satışlar", 60, 1);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_BrutSts(_year, _compID), "A-Brüt Satışlar", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_StsIndirimT(_year, _compID), "B-Satış Indirimleri(-)", 61, 1);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_StsIndirim(_year, _compID), "B-Satış Indirimleri(-)", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_NetStsT(_year, _compID), "C-Net Satışlar", 111, 0);


            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_StsMlytT(_year, _compID), "D-Satışların Maliyeti (-)", 62, 1);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_StsMlyt(_year, _compID), "D-Satışların Maliyeti (-)", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_BrutKarZararT(_year, _compID), "E-Brüt Kar/Zararı", 222, 0);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_ESMMGenel(_year, _compID), "E-SMM Satışların Maliyeti (Mizanda 7'li Gruplarda Bekleyen)", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_GenelYonGiderT(_year, _compID), "F-Genel Yönetim Giderleri (-)", 333, 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_PazarlamaGiderT(_year, _compID), "G-Pazarlama Giderleri (-)", 444, 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_ArGeGiderT(_year, _compID), "H-Araştırma ve Geliştirme Giderleri (-)", 555, 0);

            //nCheck.SetBilancoHeaderT(DashGelirTablosu.Get_FinansmanGiderT(_year, _compID), "I-Finasnman Giderleri", 777, 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_EsasMaliyetKarZararT(_year, _compID), "J-Esas Faaliyet Karı/Zararı", 888, 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_DigerFalGelT(_year, _compID), "K-DİĞER FAALİYETLERDEN OLAĞAN GELİR VE KARLAR", 999, 1);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_DigerFalGel(_year, _compID), "K-DİĞER FAALİYETLERDEN OLAĞAN GELİR VE KARLAR", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_DigerFalGidrT(_year, _compID), "L-DİĞER FAALİYETLERDEN OLAĞAN GİDER VE ZARARLAR", 1111, 1);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_DigerFalGidr(_year, _compID), "L-DİĞER FAALİYETLERDEN OLAĞAN GİDER VE ZARARLAR", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_FaaliyetKarZaraT(_year, _compID), "M-FİNANSMAN GİDERİ ÖNCESİ FAALİYET KARI ZARARI", 2222, 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_FinansmanGidrT(_year, _compID), "N-Finansman Giderleri", 3333, 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_OlaganKarZaraT(_year, _compID), "O-OLAĞAN KAR VEYA  ZARAR", 4444, 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_OlaganDisiGelrT(_year, _compID), "V-OLAĞANDIŞI GELIR VE KARLAR", 5555, 1);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_OlaganDisiGelr(_year, _compID), "V-OLAĞANDIŞI GELIR VE KARLAR", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_OlaganDisiGdrT(_year, _compID), "Y-OLAĞANDIŞI GİDER VE ZARARLAR", 7777, 1);
            nCheck.SetBilanco(DashGelirTablosuSet.Get_OlaganDisiGdr(_year, _compID), "Y-OLAĞANDIŞI GİDER VE ZARARLAR", 0);

            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_DonemKarZaraT(_year, _compID), "Z-DÖNEM KARI/ZARARI", 9991, 0);
            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_OlaganDisiGdrYkmllk(_year, _compID), "Z1-DÖNEM KARI VERGİ VE DİĞ.YASAL YÜKÜMLÜLÜK KARŞILIĞI", 9993, 0);
            nCheck.SetBilancoHeaderT(DashGelirTablosuSet.Get_DonemKarZaraTNet(_year, _compID), "ZT-DÖNEM NET KARI/ZARARI", 9995, 0);

            return nCheck.mrequestEntry;
        }
    }
    public class DashGelirTablosuViewT
    {
        public DashGelirTablosuViewT()
        {
            mrequestEntry = new List<DashBilancoViewMizan>();
            counter = 0;
        }
        public List<DashBilancoViewMizan> mrequestEntry { get; set; }
        public int counter { get; set; }

        public void SetBilanco(List<DashBilancoViewMizan> mrequestEntryCount, string tname, int ishidden)
        {
            DashBilancoViewMizan nDash = new DashBilancoViewMizan();
            for (int i = 0; i < mrequestEntryCount.Count(); i++)
            {
                counter++;
                nDash = new DashBilancoViewMizan();
                nDash.GroupName = tname;
                nDash.AccountMainDescription = mrequestEntryCount[i].AccountMainDescription;
                nDash.AccountMainID = mrequestEntryCount[i].AccountMainID;
                nDash.Amount = mrequestEntryCount[i].Amount;
                nDash.CompanyID = mrequestEntryCount[i].CompanyID;
                nDash.DebitCreditCode = mrequestEntryCount[i].DebitCreditCode;
                nDash.Year = mrequestEntryCount[i].Year;
                nDash.TypeID = 0;
                nDash.CounterZone = counter;
                nDash.IsHidden = ishidden;
                mrequestEntry.Add(nDash);
            }

        }

        public void SetBilancoHeaderT(List<DashBilancoViewMizan> mrequestEntryCount, string tname, int typeid_, int ishidden)
        {
            counter++;
            DashBilancoViewMizan nDash = new DashBilancoViewMizan();
            for (int i = 0; i < mrequestEntryCount.Count(); i++)
            {
                nDash = new DashBilancoViewMizan();
                nDash.GroupName = tname;
                nDash.AccountMainDescription = tname;
                nDash.AccountMainID = mrequestEntryCount[i].AccountMainID;
                nDash.Amount = mrequestEntryCount[i].Amount;
                nDash.CompanyID = mrequestEntryCount[i].CompanyID;
                nDash.DebitCreditCode = mrequestEntryCount[i].DebitCreditCode;
                nDash.Year = mrequestEntryCount[i].Year;
                nDash.TypeID = typeid_;
                nDash.IsHidden = ishidden;
                nDash.CounterZone = counter;

                mrequestEntry.Add(nDash);
            }
        }

    }
}
