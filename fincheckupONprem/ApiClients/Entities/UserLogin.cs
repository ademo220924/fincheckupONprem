
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  fincheckup.ApiClients.Entities;

[Table("UserLogin")]
public partial class UserLogin
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    [Column("UserID")]
    public int? UserId { get; set; }

    [Column("UserIP")]
    [StringLength(150)]
    public string UserIp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(450)]
    public string UserBrowser { get; set; }
}
