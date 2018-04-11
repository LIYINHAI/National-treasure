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
   public class CommentService
    {
        private static IComments icomments = DataAccess.CreateComments();
        public static int DeleteComments(int ComID)
        {
            return icomments.DeleteComments(ComID);
        }
        public static DataTable SelectAllpinlun()
        {
            return icomments.SelectAllpinlun();
        }
    }
}
