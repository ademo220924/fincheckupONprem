using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace  fincheckup.ApiClients.Entities;

[Keyless]
[Table("Cities")]
public partial class City
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("City")]
    [StringLength(255)]
    public string CityName { get; set; }
}
