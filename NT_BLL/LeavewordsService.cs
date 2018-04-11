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
   public class LeavewordsService
    {
        private static ILeavewords ileavewords = DataAccess.CreateLeavewords();
    }
}
