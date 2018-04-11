using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using NT_Models;
using NT_IDAL;
using System.Data;

namespace NT_DAL
{
    public class SqlServerUser : IUser
    {
        public int DeleteAct(int User_ID)
        {
            string sql = "delete from UserInfo where User_ID=@User_ID";
            SqlParameter[] sp = { new SqlParameter("@User_ID",User_ID) };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }

        public DataTable SelectTextAll()
        {
            string sql = "select * from UserInfo";
            return DBHelper.GetFillData(sql);
        }
        //查询某位用户具体信息
        public SqlDataReader users(int User_ID)
        {
            string sql = "select * from UserInfo where User_ID=@User_ID";
            SqlParameter[] sp =
            {
                new SqlParameter("@User_ID",User_ID)
            };
            return DBHelper.GetDataReader(sql,sp);
        }
        //用户修改自己的信息
        public int usersupdate(User user)
        {
            string sql = "update UserInfo set User_Password=@User_Password,User_Phone=@User_Phone,User_Img=@User_Img,User_Email=@User_Email where User_ID=@User_ID";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@User_Name",user.User_Name),
                new SqlParameter("@User_Password",user.User_Password),
                new SqlParameter("@Users_Img",user.User_Img),
                new SqlParameter("@User_Phone",user.User_Phone),
                new SqlParameter("@User_Email",user.User_Email)
            };
            return DBHelper.GetExcuteNonQuery(sql, sp);
        }
    }
}
