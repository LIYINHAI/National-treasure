using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NT_Models;
using System.Data;

namespace NT_IDAL
{
   public interface IComments
    {
        //展现评论
        DataTable SelectAllpinlun();
        //删除
        int DeleteComments(int Comments_ID);
    }
}
