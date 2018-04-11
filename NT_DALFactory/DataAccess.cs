using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NT_IDAL;
using System.Reflection;
using System.Configuration;

namespace NT_DALFactory
{
   public class DataAccess
    {
        private static string AssemblyName = ConfigurationManager.AppSettings["Path"].ToString();
        private static string db = ConfigurationManager.AppSettings["DB"].ToString();
        public static IAcg CreateAcg()
        {
            string className = AssemblyName + "." + db + "ACG";
            return (IAcg)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IAdminInfo CreateAdminInfo()
        {
            string className = AssemblyName + "." + db + "Admin";
            return (IAdminInfo)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IComments CreateComments()
        {
            string className = AssemblyName + "." + db + "Comments";
            return (IComments)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static ICulinfo CreateCulinfo()
        {
            string className = AssemblyName + "." + db + "Cull";
            return (ICulinfo)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static ILeavewords CreateLeavewords()
        {
            string className = AssemblyName + "." + db + "Leavewords";
            return (ILeavewords)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static INewsinfo CreateNewsinfo()
        {
            string className = AssemblyName + "." + db + "News";
            return (INewsinfo)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IReplyComments CreateReplyComments()
        {
            string className = AssemblyName + "." + db + "ReplyComments";
            return (IReplyComments)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IReplyLeavewords CreateReplyLeavewords()
        {
            string className = AssemblyName + "." + db + "ReplyLeavewords";
            return (IReplyLeavewords)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IUser CreateUser()
        {
            string className = AssemblyName + "." + db + "User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
