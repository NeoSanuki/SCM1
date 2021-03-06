﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SCM1_API.Model;
using SCM1_API.Repository;

namespace SCM1_API.Service
{
    public class EMP_Service
    {
        /// <summary>
        /// 社員情報を取得する
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MST_EMP_MODEL> FetchEMPInfo_Service(string postedEMP_NO)
        {
            //                ↓はxml内に記述されたSQLの「#」で括られた部分
            var param = new { EMP_NO = postedEMP_NO };
            return MST_EMP_Repository.FetchEMPInfo_Repository(param);
            
        }
    }
}