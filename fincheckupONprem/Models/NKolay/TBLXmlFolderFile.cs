using System;
using System.Collections.Generic;
using System.Linq;

namespace fincheckup.Models.NKolay
{
    public class TBLXmlFolderFile : BaseModel
    {
        public long ID { get; set; }
        public long TBLXmlID { get; set; }
        public string CsvName { get; set; }
        public string Test { get; set; }
        public DateTime CreatedDate { get; set; }
        public byte Issetted { get; set; } = 0;
        public byte IsFinished { get; set; } = 0;
        public bool IsLedger { get; set; }
        public int SortID { get; set; }
        public int LastSettedCount { get; set; }
        public long CompanyID { get; set; }
        public int MainYear { get; set; }
        public byte MainMonth { get; set; }
        public TBLXmlFolderFile()
        {

        }
        public TBLXmlFolderFile(string csvName, long companyID, int mainYear, byte mainMonth, int sortID, bool isLedger)
        {
            CsvName = csvName;
            CompanyID = companyID;
            MainYear = mainYear;
            MainMonth = mainMonth;
            SortID = sortID;
            IsLedger = isLedger;
        }

        public static List<TBLXmlFolderFile> GetList(long _ID)
        {
            return StaticQuery<TBLXmlFolderFile>("Select [CompanyID],[MainMonth],[MainYear],[Issetted] FROM [EDEFTERDB].[dbo].[TBLXmlFolderFile] where [CompanyID]=@ID and IsLedger=1  and [CreatedDate]> DATEADD(MINUTE,-130, GETDATE()) order by ID ", new { ID = _ID }).ToList();
        }
        public static List<ViewSortlist> GetListSort(long _ID)
        {
            string sql = @"  SELECT SUM(t.AllSet) as 'AllSet',SUM(t.AllWait) as  'AllWait',SUM(t.AllRecord) as  'AllRecord',t.MainYear from
  (Select 
  Case When [Issetted]=1 Then COUNT(*) ELSE 0 END as 'AllSet',
  Case When [Issetted]=0 Then COUNT(*) ELSE 0 END as  'AllWait',
  Count(*) as  'AllRecord', [MainYear]
   FROM [EDEFTERDB].[dbo].[TBLXmlFolderFile] where [CompanyID]=@ID and IsLedger=1  group by [Issetted],[MainYear],[CompanyID])t group by t.MainYear";

            return StaticQuery<ViewSortlist>(sql, new { ID = _ID }).ToList();
        }
    }

    public class ViewSortlist
    {
        public int AllSet { get; set; }
        public int AllWait { get; set; }
        public int AllRecord { get; set; }
        public int MainYear { get; set; }
    }
}
