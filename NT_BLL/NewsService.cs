﻿using System;
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
   public class NewsService
    {
        private static INewsinfo inewsinfo = DataAccess.CreateNewsinfo();
        public static int DeleteAct(int News_ID)
        {
            return inewsinfo.DeleteAct(News_ID);
        }
        public static DataTable SelectTextAll()
        {
            return inewsinfo.SelectTextAll();
        }
    }
}
