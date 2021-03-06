﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using Com.GainWinSoft.Common;
using Com.GainWinSoft.ERP.Entity.Dao;
using System.Collections;
using Com.GainWinSoft.ERP.Entity;
using System.Threading;

namespace Com.GainWinSoft.ERP.CodeRef.Action
{
    public class Action_TestCode : Com.GainWinSoft.Common.IBaseAction, Com.GainWinSoft.ERP.CodeRef.Action.IAction_TestCode
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Action_TestCode));

        public IList<MFunctioncatalog> GetFunctionDataList()
        {
            IList<MFunctioncatalog> funcvolist = new List<MFunctioncatalog>();
            IMFunctioncatalogDao td = ComponentLocator.Instance().Resolve<IMFunctioncatalogDao>();
            IList<MFunctioncatalog> mfuncatalist = td.GetFunctionCatalogList(LangUtils.GetCurrentLanguage());
            //foreach (MFunctioncatalog mfvo in mfuncatalist)
            //{
            //    FunctionVo fvo = new FunctionVo();
            //    fvo.Langid = mfvo.Id.Langid;
            //    fvo.Catalogid = mfvo.Id.Catalogid;
            //    fvo.Catalogname = mfvo.Catalogname;
            //    fvo.Catalogimage = mfvo.Catalogimage;
            //    funcvolist.Add(fvo);
            //}

            return mfuncatalist;
        }
    }
}
