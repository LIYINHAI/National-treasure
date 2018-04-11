using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NT_Models;
namespace NT_IDAL
{
   public interface IUserInfo
    {
        //删除
        int DeleteAct(int UserID);
        //展现所有
        DataTable SelectTextAll();
    }
}
