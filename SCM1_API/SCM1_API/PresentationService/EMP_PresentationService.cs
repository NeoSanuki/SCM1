﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SCM1_API.Service;

namespace SCM1_API.PresentationService
{
    public class EMP_PresentationService
    {
        private EMP_Service emp_Service; 

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public EMP_PresentationService()
        {
            emp_Service = new EMP_Service();
        }

        /// <summary>
        /// 社員情報を取得する
        /// </summary>
        /// <returns></returns>
        public Tuple<bool,object> FetchEMPInfo(string postedEMP_NO)
        {
            var FetchedEmpInfo = emp_Service.FetchEMPInfo_Service(postedEMP_NO);
            
            //処理ステータスと取得結果を返す
            var returnValue = new Tuple<bool, object>(FetchedEmpInfo.Count() != 0? true:false, FetchedEmpInfo);
            return returnValue;
        } 

    }
}