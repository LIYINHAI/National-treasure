﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NT_Models;
using System.Data;

namespace NT_IDAL
{
   public interface INewsinfo
    {
        //删除
        int DeleteAct(int News_ID);
        //展现所有
        DataTable SelectTextAll();
    }
}
