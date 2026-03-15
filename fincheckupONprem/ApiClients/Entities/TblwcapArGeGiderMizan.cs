using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  fincheckup.ApiClients.Entities;

[Table("TBLWcapArGeGiderMizan")]
public partial class TblwcapArGeGiderMizan
{
    public double? Amount { get; set; }

    [Column("CompanyID")]
    public long? CompanyId { get; set; }

    public int Year { get; set; }

    [Key]
    [Column("ID")]
    public long Id { get; set; }
}
