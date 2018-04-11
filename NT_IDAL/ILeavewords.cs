using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NT_Models;
using System.Data;

namespace NT_IDAL
{
   public interface ILeavewords
    {
        //展现留言
        DataTable SelectAllliuyan();
        //删除留言
        int Deleteliuyan(int Leavewords_ID);
    }
}
