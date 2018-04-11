using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using NT_Models;

namespace NT_IDAL
{
   public interface IAcg
    {
        //查找某用户创建的ACG&文物内容
        DataTable UserAcg(int User_ID);
        //根据作品ID进行删除操作
        int delete(int Pro_ID);
    }
}
