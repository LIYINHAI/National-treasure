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
   public class ReplyLeavewordsService
    {
        private static IReplyLeavewords ireplyleavewords = DataAccess.CreateReplyLeavewords();
        //删除
        public static int Delete(int ReplyLeavewords_ID)
        {
            return ireplyleavewords.Delete(ReplyLeavewords_ID);
        }
        //展现
        public static DataTable SelectAll()
        {
            return ireplyleavewords.SelectAll();
        }
    }
}
