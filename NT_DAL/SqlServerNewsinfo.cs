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
    public class SqlServerNewsinfo : INewsinfo
    {
        public int DeleteAct(int News_ID)
        {
            string sql = "delete from NewsInfo where News_ID=@News_ID";
            SqlParameter[] sp = { new SqlParameter("@News_ID",News_ID) };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectTextAll()
        {
            string sql = "select * from NewsInfo order by News_Time desc";
            return DBHelper.GetFillData(sql);
        }
    }
}
