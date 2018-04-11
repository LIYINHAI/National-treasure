using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NT_Models;
using System.Data;

namespace NT_IDAL
{
   public interface IReplyLeavewords
    {
        //展现
        DataTable SelectAll();
        //删除
        int Delete(int ReplyLeavewords_ID);
    }
}
