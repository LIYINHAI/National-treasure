using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using NT_Models;
using NT_IDAL;
using System.Data;
namespace NT_DAL
{
   public  class SqlServerAcg:IAcg
    {
        //查找某用户创建的ACG&文物内容
        public DataTable UserAcg(int User_ID)
        {
            string sql= "select * from Acg where User_ID='"+User_ID+"'";
          
            return DBHelper.GetFillData(sql);
        }
        //根据作品ID进行删除操作
        public int delete(int Pro_ID)
        {
            string sql= "delete from Acg where News_ID = '" + Pro_ID + "'";
            return DBHelper.GetExcuteNonQuery(sql);
        }
    }
}
