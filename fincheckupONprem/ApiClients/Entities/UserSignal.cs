using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  fincheckup.ApiClients.Entities;

[Table("UserSignal")]
public partial class UserSignal
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("UserID")]
    public int? UserId { get; set; }

    [Column("UserSignalID")]
    [StringLength(290)]
    public string UserSignalId { get; set; }

    public bool IsActive { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ActionDate { get; set; }
}
