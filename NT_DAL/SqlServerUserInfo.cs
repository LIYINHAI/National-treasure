using NT_IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using NT_Models;
using System.Data;

namespace NT_DAL
{
    public class SqlServerUserInfo : IUserInfo
    {
        public int DeleteAct(int User_ID)
        {
            string sql ="delete from UserInfo where User_ID=@User_ID";
            SqlParameter[] sp = { new SqlParameter("@User_ID",User_ID) };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectTextAll()
        {
            string sql ="select * from UserInfo";
            return DBHelper.GetFillData(sql);
        }
    }
}
