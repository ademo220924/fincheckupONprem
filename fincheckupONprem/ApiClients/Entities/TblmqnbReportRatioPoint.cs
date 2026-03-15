using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  fincheckup.ApiClients.Entities;

[Table("TBLMQnbReportRatioPoint")]
public partial class TblmqnbReportRatioPoint
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("MainID")]
    public int MainId { get; set; }

    public double Amount { get; set; }
}
