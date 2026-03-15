using System.ComponentModel;

namespace fincheckup.ApiClients.Models.Common;

public enum JobStatus
{
    [Description("Oluşturuldu")] Created = 1,
    [Description("Çalışıyor")] Processing = 2,
    [Description("Tamamlandı")] Completed = 3,
    [Description("Tekrarlanacak")] Retried = 4
}