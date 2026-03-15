using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  fincheckup.ApiClients.Entities;

[Table("RuleGroup")]
public partial class RuleGroup
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [StringLength(250)]
    public string Name { get; set; }
}
