﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using NT_Models;
using NT_IDAL;
using System.Data;

namespace NT_DAL
{
    public class SqlServerReplyLeavewords : IReplyLeavewords
    {
        //删除
        public int Delete(int ReplyLeavewords_ID)
        {
            SqlParameter[] sp = { new SqlParameter("@ReplyLeavewords_ID", ReplyLeavewords_ID) };
            return DBHelper.GetExcuteNonQuery("ReplyLeavewords_ID", System.Data.CommandType.StoredProcedure, sp);
        }

       //展现
        public DataTable SelectAll()
        {
            string sql = "select a.*,b.User_Name,c.Leavewords_Content from ReplyLeavewords a,UserInfo b,Leavewords c where a.User_ID=b.User_ID and a.Leavewords_ID=c.Leavewords_ID";
            return DBHelper.GetFillData(sql);
        }
    }
}
