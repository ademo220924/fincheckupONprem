
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  fincheckup.ApiClients.Entities.BgServer;

[Table("ReminderAccountGroup")]
public partial class ReminderAccountGroup
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [Required]
    [StringLength(500)]
    public string Name { get; set; }
}
