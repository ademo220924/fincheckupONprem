using System.Collections.Generic;

namespace fincheckup.ApiClients.Models
{
    public class TaxErrorcheckTest
    {

        public TaxErrorcheckTest()
        {
            taxchecklist = new List<TaxErrorcheckTest>();
        }
        public string AccountMainID { get; set; }
        public string AccountMainDescription { get; set; }
        public string AccountSubID { get; set; }
        public string AccountSubDescription { get; set; }
        public string DebitCreditCode { get; set; }
        public double January { get; set; }
        public double February { get; set; }
        public double March { get; set; }
        public double April { get; set; }
        public double May { get; set; }
        public double June { get; set; }
        public double July { get; set; }
        public double August { get; set; }
        public double September { get; set; }
        public double October { get; set; }
        public double November { get; set; }
        public double December { get; set; }

        public long CompanyID { get; set; }
        public double JanuaryTx => January;
        public double FebruaryTx => February != 0 ? (January + February) : 0;
        public double MarchTx => March != 0 ? (FebruaryTx + March) : 0;
        public double AprilTx => April != 0 ? (MarchTx + April) : 0;
        public double MayTx => May != 0 ? (AprilTx + May) : 0;
        public double JuneTx => June != 0 ? (MayTx + June) : 0;
        public double JulyTx => July != 0 ? (JuneTx + July) : 0;
        public double AugustTx => August != 0 ? (JulyTx + August) : 0;
        public double SeptemberTx => September != 0 ? (AugustTx + September) : 0;
        public double OctoberTx => October != 0 ? (SeptemberTx + October) : 0;
        public double NovemberTx => November != 0 ? (OctoberTx + November) : 0;
        public double DecemberTx => December != 0 ? (NovemberTx + December) : 0;

        public double JanuaryTxa => January;
        public double FebruaryTxa => February != 0 ? January + February : 0;
        public double MarchTxa => March != 0 ? January + February + March : 0;
        public double AprilTxa => April != 0 ? January + February + March + April : 0;
        public double MayTxa => May != 0 ? January + February + March + April + May : 0;
        public double JuneTxa => June != 0 ? January + February + March + April + May + June : 0;
        public double JulyTxa => July != 0 ? January + February + March + April + May + June + July : 0;
        public double AugustTxa => August != 0 ? January + February + March + April + May + June + July + August : 0;
        public double SeptemberTxa => September != 0 ? January + February + March + April + May + June + July + August + September : 0;
        public double OctoberTxa => October != 0 ? January + February + March + April + May + June + July + August + September + October : 0;
        public double NovemberTxa => November != 0 ? January + February + March + April + May + June + July + August + September + October + November : 0;
        public double DecemberTxa => December != 0 ? January + February + March + April + May + June + July + August + September + October + November + December : 0;
 
        public int mainCkValue = 7500;
     

   
        public List<TaxErrorcheckTest> taxchecklist { get; set; }



    }

}
