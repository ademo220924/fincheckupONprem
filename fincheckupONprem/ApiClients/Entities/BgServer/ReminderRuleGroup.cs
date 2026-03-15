
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  fincheckup.ApiClients.Entities.BgServer;

[Table("ReminderRuleGroup")]
public partial class ReminderRuleGroup
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ReminderAccountID")]
    public long ReminderAccountId { get; set; }

    [Column("RuleGroupID")]
    public long RuleGroupId { get; set; }
}
