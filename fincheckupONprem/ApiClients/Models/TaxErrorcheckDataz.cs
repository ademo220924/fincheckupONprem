using System;
using System.Collections.Generic;

namespace fincheckup.ApiClients.Models
{
    public class TaxErrorcheckDataz
    {
        public long CsvID { get; set; }
        public DateTime EndDate { get; set; }
        public string AccountMainID { get; set; }
        public string AccountMainDescription { get; set; }
        public string AccountSubID { get; set; }
        public string AccountSubDescription { get; set; }
        public string DebitCreditCode { get; set; }
        public float Amount { get; set; }
        public int ErrorIdentity { get; set; } 
        public List<TaxErrorcheckDataz> taxchecklist { get; set; } = new();
    }
}
