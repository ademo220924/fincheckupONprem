using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  fincheckup.ApiClients.Entities;

[Table("MCodeZenQnbID")]
public partial class McodeZenQnbId
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("QnbTypeID")]
    public int? QnbTypeId { get; set; }

    [Column("CodeZenID")]
    public int? CodeZenId { get; set; }
}
