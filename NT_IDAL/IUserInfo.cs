using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NT_Models;
using System.Data.SqlClient;

namespace NT_IDAL
{
   public interface IUserInfo
    {
        //注册
        int Insert(UserInfo userinfo);
        //删除
        int DeleteAct(int UserID);
        //展现所有
        DataTable SelectTextAll();
        //登陆
        SqlDataReader Login(string Name, string paw);
    }
}
