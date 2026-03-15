using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  fincheckup.ApiClients.Entities;

[Table("TBLMNKzone")]
public partial class Tblmnkzone
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int? MainCode { get; set; }

    [StringLength(155)]
    public string MainDesc { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [Column("TypeID")]
    public byte? TypeId { get; set; }
}
