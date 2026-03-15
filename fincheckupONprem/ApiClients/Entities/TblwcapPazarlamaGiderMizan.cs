using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  fincheckup.ApiClients.Entities;

[Table("TBLWcapPazarlamaGiderMizan")]
public partial class TblwcapPazarlamaGiderMizan
{
    public double? Amount { get; set; }

    [Column("CompanyID")]
    public long? CompanyId { get; set; }

    public int Year { get; set; }

    [Key]
    [Column("ID")]
    public long Id { get; set; }
}
