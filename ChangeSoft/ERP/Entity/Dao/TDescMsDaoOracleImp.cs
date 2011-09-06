﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.ActiveRecord;
using Com.ChangeSoft.Common;
using System.Collections;
using Castle.ActiveRecord.Queries;
using NHibernate;
using System.Data.Common;

namespace Com.ChangeSoft.ERP.Entity.Dao
{
    public class TDescMsDaoOracleImp :ActiveRecordBase, IBaseDao, Com.ChangeSoft.ERP.Entity.Dao.ITDescMsDao{
        public IList<TDescMs> GetTDescMsList(string iClsCd,string iLanguageCd)
        {
            IList<TDescMs> result = new List<TDescMs>();

            TransactionScope transaction = new TransactionScope();

            ISession ss = holder.CreateSession(typeof(TDescMsDaoOracleImp));
            ITransaction tran = ss.BeginTransaction();
            try
            {
                //result = (IList<MFunctioncatalog>)FindAll(typeof(MFunctioncatalog));
                SimpleQuery<TDescMs> q = new SimpleQuery<TDescMs>(typeof(TDescMs), @"
                                                from TDescMs where Id.IClsCd=:iClsCd and Id.ILanguageCd=:iLanguageCd");
                q.SetParameter("iClsCd", iClsCd);
                q.SetParameter("iLanguageCd", iLanguageCd);
                result = q.Execute();


            }
            catch (Castle.ActiveRecord.Framework.ActiveRecordException ex)
            {
                transaction.VoteRollBack();
                throw new ApplicationException(ex.Message, ex);
            }
            catch (DbException ex)
            {
                transaction.VoteRollBack();
                throw new ApplicationException(ex.Message, ex);
            }
            finally
            {
                transaction.Dispose();
            }

            return result;

        }
    }
}