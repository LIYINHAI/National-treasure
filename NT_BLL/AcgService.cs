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
namespace NT_BLL
{
   public class AcgService
    {
        private static IAcg iacg = DataAccess.CreateAcg();
        //查找某用户创建的ACG&文物内容
        public static DataTable UserAcg(int User_ID)
        {
            return iacg.UserAcg(User_ID);
        }
        //根据作品ID进行删除操作
        public static int delete(int Pro_ID)
        {
            return iacg.delete(Pro_ID);
        }
     }
}
