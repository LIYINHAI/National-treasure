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
    public class SqlServerComments : IComments
    {
        public int DeleteComments(int Comments_ID)
        {
            SqlParameter[] sp = { new SqlParameter("@Comments_ID",Comments_ID) };
            return DBHelper.GetExcuteNonQuery("DeleteComments", System.Data.CommandType.StoredProcedure, sp);
        }

        public DataTable SelectAllpinlun()
        {
            string sql = "select a.*,b.User_Name,c.Pro_Title from Comments a,UserInfo b,ACG c where a.User_ID=b.User_ID and a.Pro_ID=c.Pro_ID";
            return DBHelper.GetFillData(sql);
        }
    }
}
