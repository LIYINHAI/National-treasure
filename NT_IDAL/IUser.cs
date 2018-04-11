using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NT_Models;


namespace NT_IDAL
{
   public interface IUser
    {
        //删除
        int DeleteAct(int User_ID);
        //展现所有
        DataTable SelectTextAll();
        //查询某位用户具体信息
        SqlDataReader users(int User_ID);
        //用户修改自己的信息
        int usersupdate(User user);
    }
}
