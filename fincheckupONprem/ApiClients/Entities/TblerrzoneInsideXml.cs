using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  fincheckup.ApiClients.Entities;

[Table("TBLErrzoneInsideXML")]
public partial class TblerrzoneInsideXml
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("CsvID")]
    public int CsvId { get; set; }

    [Required]
    [StringLength(155)]
    public string EntryNo { get; set; }

    [Column("ErrorInsideID")]
    public int ErrorInsideId { get; set; }
}
