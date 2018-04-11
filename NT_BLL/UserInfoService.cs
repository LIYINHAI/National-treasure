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
   public class UserInfoService
    {
        private static IUserInfo iuserinfo = DataAccess.CreateUserInfo();
        //删除用户信息
        public static int DeleteAct(int UserID)
        {
            return iuserinfo.DeleteAct(UserID);
        }
        //展现用户信息
        public static DataTable SelectTextAll()
        {
            return iuserinfo.SelectTextAll();
        }
    }
}
