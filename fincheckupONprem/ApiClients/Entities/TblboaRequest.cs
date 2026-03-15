using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  fincheckup.ApiClients.Entities;

[Table("TBLBoaRequest")]
public partial class TblboaRequest
{
    [Key]
    [Column("ID")]
    public long Id { get; set; }

    public byte ApiId { get; set; }

    public string RequestJsonString { get; set; }

    [Required]
    public string ResponseJsonString { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }
}
