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
   public class ReplyCommentsService
    {
        private static IReplyComments ireplycomments = DataAccess.CreateReplyComments();
        public static int Delete(int ReplyComments_ID)
        {
            return ireplycomments.Delete(ReplyComments_ID);
        }
        public static DataTable SelectAll()
        {
            return ireplycomments.SelectAll();
        }

    }
}
