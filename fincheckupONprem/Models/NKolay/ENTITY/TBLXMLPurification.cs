using fincheckup.Models.NKolay.json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace fincheckup.Models.NKolay.ENTITY
{
    public class TBLXMLPurification : BaseModel
    {
        public long ID { get; set; }  
        public long CompanyID { get; set; }
        public int Year  { get; set; } 
        public DateTime CreatedDate { get; set; }
        public long CreatedUser { get; set; }

        public static TBLXMLPurification Get_row(long ide)
        {
            return StaticQuery<TBLXMLPurification>("Select * From  [dbo].[TBLXMLPurification] where ID=@ID", new { ID = ide }).FirstOrDefault();
        }
        public static TBLXMLPurification Get_byCompanyID(long companyide)
        {
            return StaticQuery<TBLXMLPurification>("Select TOP 1 * From  [dbo].[TBLXMLPurification] where CompanyID=@ID order by ID desc", new { ID = companyide }).FirstOrDefault();
        }

        public static IEnumerable<TBLXMLPurification> Get_All()
        {
            return StaticQuery<TBLXMLPurification>("Select * From  [dbo].[TBLXMLPurification]");
        }

        public void Save_()
        {
            string sql = @"  INSERT INTO  [dbo].[TBLXMLPurification]
          (  
        [CompanyID] ,
        [Year] ,
        [CreatedUser]  
          ) 
           VALUES 
         (  
        @CompanyID ,
        @Year ,
        @CreatedUser 

         )  ;select  Cast(SCOPE_IDENTITY() as Int)";
            this.ID = Query<int>(sql, this).FirstOrDefault();
        }

        public static void UpdateApintment(TBLXMLPurification apnt)
        {
            string sql = @" UPDATE [dbo].[TBLXMLPurification]
         SET  CompanyID=@CompanyID, Year=@Year, CreatedUser=@CreatedUser  WHERE ID=@ID";
            StaticQuery<int>(sql, apnt).FirstOrDefault();


        }
    }
}
