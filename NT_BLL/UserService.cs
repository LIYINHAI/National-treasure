using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NT_Models;
using NT_IDAL;
using NT_DALFactory;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace NT_BLL
{
   public class UserService
    {
        private static IUser iuser = DataAccess.CreateUser();
        public static int DeleteAct(int User_ID)
        {
            return iuser.DeleteAct(User_ID);
        }
        public static DataTable SelectTextAll()
        {
            return iuser.SelectTextAll();
        }
        //查询某位用户具体信息
        public static SqlDataReader users(int User_ID)
        {
            return iuser.users(User_ID);
        }

        //用户修改自己的信息
        public static int usersupdate(User user)
        {
            return iuser.usersupdate(user);
        }
     }
}
