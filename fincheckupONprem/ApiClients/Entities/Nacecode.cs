using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  fincheckup.ApiClients.Entities;

[Table("NACECODE")]
public partial class Nacecode
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(255)]
    public string Code { get; set; }

    [StringLength(255)]
    public string Description { get; set; }
}
