using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  fincheckup.ApiClients.Entities;

[Table("TBLWcapDonemKarZararNetMizan")]
public partial class TblwcapDonemKarZararNetMizan
{
    public double? Amount { get; set; }

    [Column("CompanyID")]
    public long? CompanyId { get; set; }

    public int Year { get; set; }

    [Key]
    [Column("ID")]
    public long Id { get; set; }
}
