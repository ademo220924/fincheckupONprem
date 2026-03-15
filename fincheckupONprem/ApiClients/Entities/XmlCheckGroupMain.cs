using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  fincheckup.ApiClients.Entities;

[Table("XmlCheckGroupMain")]
public partial class XmlCheckGroupMain
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string EntryNumber { get; set; }

    public double? TotalCredit { get; set; }

    [Column("CsvID")]
    public int? CsvId { get; set; }
}
