using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Queries;
//using NHibernate.Expression;
//using NHibernate.Generics;


#region 'T_RATE_STP' Schema
/*
 * 'TRateStp' class maps to 'T_RATE_STP' table.
 * 	 I_JOURNAL_NO            | Type:NUMBER    | Len:0     | Nullable:F | PK:T | FK:F
 * 	 I_PRCS_CLS              | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_USER_ID               | Type:VARCHAR2  | Len:10    | Nullable:F | PK:F | FK:F
 * 	 I_PRCS_DATE             | Type:DATE      | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_PRCS_TIME             | Type:VARCHAR2  | Len:6     | Nullable:F | PK:F | FK:F
 * 	 I_UPD_CLS               | Type:VARCHAR2  | Len:1     | Nullable:F | PK:F | FK:F
 * 	 I_COMPANY_CD            | Type:VARCHAR2  | Len:8     | Nullable:F | PK:T | FK:F
 * 	 I_RATE_CLS              | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_DL_CURR_CD            | Type:VARCHAR2  | Len:4     | Nullable:F | PK:F | FK:F
 * 	 I_EFF_END_DATE          | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_RATE                  | Type:NUMBER    | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_CNV_METHOD            | Type:VARCHAR2  | Len:1     | Nullable:F | PK:F | FK:F
 * 	 I_ENTRY_DATE            | Type:DATE      | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_UPD_DATE              | Type:DATE      | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_PG_ID                 | Type:VARCHAR2  | Len:15    | Nullable:T | PK:F | FK:F
 * 	 I_REF_TIMESTAMP         | Type:VARCHAR2  | Len:17    | Nullable:T | PK:F | FK:F
 */
#endregion
/// <summary>
///	Generated by MyGeneration using the ActiveRecord Object Mapper - 1.0.2
///	Created on 2011/09/14 11:03:50
/// </summary>
namespace Com.GainWinSoft.ERP.Entity
{
	[Serializable , ActiveRecord("T_RATE_STP")]
	public class TRateStp : ActiveRecordBase	{

		#region Private Members

        //private decimal iJournalNo;
        //private string iCompanyCd; 
        private TRateStpId id;

		private string iPrcsCls; 
		private string iUserId; 
		private DateTime iPrcsDate; 
		private string iPrcsTime; 
		private string iUpdCls; 
		
		private string iRateCls; 
		private string iDlCurrCd; 
		private decimal iEffEndDate; 
		private decimal iRate; 
		private string iCnvMethod; 
		private DateTime iEntryDate; 
		private DateTime iUpdDate; 
		private string iPgId; 
		private string iRefTimestamp; 
		
		#endregion

		#region Constuctor(s)
		
		public TRateStp()
		{
            //iJournalNo = 0;
            //iCompanyCd = String.Empty;
            id = new TRateStpId();

			iPrcsCls = String.Empty; 
			iUserId = String.Empty; 
			iPrcsDate = DateTime.MinValue; 
			iPrcsTime = String.Empty; 
			iUpdCls = String.Empty; 
			 
			iRateCls = String.Empty; 
			iDlCurrCd = String.Empty; 
			iEffEndDate = 0; 
			iRate = 0; 
			iCnvMethod = String.Empty; 
			iEntryDate = DateTime.MinValue; 
			iUpdDate = DateTime.MinValue; 
			iPgId = String.Empty; 
			iRefTimestamp = String.Empty; 

		}

		public TRateStp(
			decimal i_journal_no, 
			string i_prcs_cls, 
			string i_user_id, 
			DateTime i_prcs_date, 
			string i_prcs_time, 
			string i_upd_cls, 
			string i_company_cd, 
			string i_rate_cls, 
			string i_dl_curr_cd, 
			decimal i_eff_end_date, 
			decimal i_rate, 
			string i_cnv_method)
			: this()
		{
            //iJournalNo = i_journal_no;
            //iCompanyCd = i_company_cd;
            id = new TRateStpId(i_journal_no,i_company_cd);
			iPrcsCls = i_prcs_cls;
			iUserId = i_user_id;
			iPrcsDate = i_prcs_date;
			iPrcsTime = i_prcs_time;
			iUpdCls = i_upd_cls;
        
			iRateCls = i_rate_cls;
			iDlCurrCd = i_dl_curr_cd;
			iEffEndDate = i_eff_end_date;
			iRate = i_rate;
			iCnvMethod = i_cnv_method;
			iEntryDate = DateTime.MinValue;
			iUpdDate = DateTime.MinValue;
			iPgId = String.Empty;
			iRefTimestamp = String.Empty;
		}

		#endregion // End of Class Constuctor(s)
		
		#region Public Properties
			
        //[PrimaryKey(PrimaryKeyType.Identity ,"I_JOURNAL_NO")]
        //public virtual decimal IJournalNo
        //{
        //    get { return iJournalNo; }
        //    set { iJournalNo = value; }
        //}
        [CompositeKey]
        public TRateStpId Id
        {
            get { return id; }
            set { id = value; }
        }

		[Property(Column="I_PRCS_CLS", NotNull=true, Length=2)]
		public virtual string IPrcsCls
		{
			get { return iPrcsCls; }
			set { iPrcsCls = value; }
		}

		[Property(Column="I_USER_ID", NotNull=true, Length=10)]
		public virtual string IUserId
		{
			get { return iUserId; }
			set { iUserId = value; }
		}

		[Property(Column="I_PRCS_DATE", NotNull=true)]
		public virtual DateTime IPrcsDate
		{
			get { return iPrcsDate; }
			set { iPrcsDate = value; }
		}

		[Property(Column="I_PRCS_TIME", NotNull=true, Length=6)]
		public virtual string IPrcsTime
		{
			get { return iPrcsTime; }
			set { iPrcsTime = value; }
		}

		[Property(Column="I_UPD_CLS", NotNull=true, Length=1)]
		public virtual string IUpdCls
		{
			get { return iUpdCls; }
			set { iUpdCls = value; }
		}
/*
		[PrimaryKey(PrimaryKeyType.Identity ,"I_COMPANY_CD", Length=8)]
		public virtual string ICompanyCd
		{
			get { return iCompanyCd; }
			set { iCompanyCd = value; }
		}*/

		[Property(Column="I_RATE_CLS", NotNull=true, Length=2)]
		public virtual string IRateCls
		{
			get { return iRateCls; }
			set { iRateCls = value; }
		}

		[Property(Column="I_DL_CURR_CD", NotNull=true, Length=4)]
		public virtual string IDlCurrCd
		{
			get { return iDlCurrCd; }
			set { iDlCurrCd = value; }
		}

		[Property(Column="I_EFF_END_DATE", NotNull=true)]
		public virtual decimal IEffEndDate
		{
			get { return iEffEndDate; }
			set { iEffEndDate = value; }
		}

		[Property(Column="I_RATE", NotNull=true)]
		public virtual decimal IRate
		{
			get { return iRate; }
			set { iRate = value; }
		}

		[Property(Column="I_CNV_METHOD", NotNull=true, Length=1)]
		public virtual string ICnvMethod
		{
			get { return iCnvMethod; }
			set { iCnvMethod = value; }
		}

		[Property(Column="I_ENTRY_DATE")]
		public virtual DateTime IEntryDate
		{
			get { return iEntryDate; }
			set { iEntryDate = value; }
		}

		[Property(Column="I_UPD_DATE")]
		public virtual DateTime IUpdDate
		{
			get { return iUpdDate; }
			set { iUpdDate = value; }
		}

		[Property(Column="I_PG_ID", Length=15)]
		public virtual string IPgId
		{
			get { return iPgId; }
			set { iPgId = value; }
		}

		[Property(Column="I_REF_TIMESTAMP", Length=17)]
		public virtual string IRefTimestamp
		{
			get { return iRefTimestamp; }
			set { iRefTimestamp = value; }
		}


		#endregion 

			
		#region Equals, HashCode and ToString overrides

        /// <summary>
        /// Local implementation of Equals based on unique value members
        /// </summary>
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if ((obj == null) || (obj.GetType() != this.GetType())) return false;
            TRateStp castObj = (TRateStp)obj;
            return (castObj != null) &&
                  (this.id == castObj.id);
                //(this.iJournalNo == castObj.IJournalNo) &&
                //(this.iCompanyCd == castObj.ICompanyCd);
        }

        /// <summary>
        /// Local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {

            int hash = 57;
            hash = 27 * hash * id.GetHashCode();
            //hash = 27 * hash * iJournalNo.GetHashCode();
            //hash = 27 * hash * iCompanyCd.GetHashCode();
            return hash;
        }
		
		/// <summary>
		/// Local implementation of ToString based on class members
		/// </summary>
		public override String ToString()
        {
            StringBuilder sbuffer = new StringBuilder();
			sbuffer.Append("{");
			
            //sbuffer.AppendFormat("IJournalNo = {0}, ",iJournalNo);
            //sbuffer.AppendFormat("ICompanyCd = {0}, ", iCompanyCd);

			sbuffer.AppendFormat("IJournalNo = {0}, ",id.IJournalNo);
            sbuffer.AppendFormat("ICompanyCd = {0}, ", id.ICompanyCd);

			sbuffer.AppendFormat("IPrcsCls = {0}, ",iPrcsCls);
			sbuffer.AppendFormat("IUserId = {0}, ",iUserId);
			sbuffer.AppendFormat("IPrcsDate = {0}, ",iPrcsDate);
			sbuffer.AppendFormat("IPrcsTime = {0}, ",iPrcsTime);
			sbuffer.AppendFormat("IUpdCls = {0}, ",iUpdCls);
			
			sbuffer.AppendFormat("IRateCls = {0}, ",iRateCls);
			sbuffer.AppendFormat("IDlCurrCd = {0}, ",iDlCurrCd);
			sbuffer.AppendFormat("IEffEndDate = {0}, ",iEffEndDate);
			sbuffer.AppendFormat("IRate = {0}, ",iRate);
			sbuffer.AppendFormat("ICnvMethod = {0}, ",iCnvMethod);
			sbuffer.AppendFormat("IEntryDate = {0}, ",iEntryDate);
			sbuffer.AppendFormat("IUpdDate = {0}, ",iUpdDate);
			sbuffer.AppendFormat("IPgId = {0}, ",iPgId);
			sbuffer.AppendFormat("IRefTimestamp = {0}, ",iRefTimestamp);
			sbuffer.Append(" }");
			return sbuffer.ToString();
        }
		
		#endregion
	}
}
