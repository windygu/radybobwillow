using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Queries;


#region 'T_UNIT_MS' Schema
/*
 * 'TUnitMs' class maps to 'T_UNIT_MS' table.
 * 	 I_UNIT_CD               | Type:VARCHAR2  | Len:2     | Nullable:F | PK:T | FK:F
 * 	 I_UNIT_DESC             | Type:VARCHAR2  | Len:8     | Nullable:T | PK:F | FK:F
 * 	 I_FRC_CLS               | Type:VARCHAR2  | Len:2     | Nullable:F | PK:F | FK:F
 * 	 I_INQ_ITEM              | Type:VARCHAR2  | Len:1     | Nullable:T | PK:F | FK:F
 * 	 I_ENTRY_DATE            | Type:DATE      | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_UPD_DATE              | Type:DATE      | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_UPD_TIMESTAMP         | Type:VARCHAR2  | Len:17    | Nullable:F | PK:F | FK:F
 */
#endregion
/// <summary>
///	Generated by MyGeneration using the ActiveRecord Object Mapper - 1.0.2
///	Created on 2011/9/17 23:15:17
/// </summary>
namespace Com.GainWinSoft.ERP.Entity
{
	[Serializable , ActiveRecord("T_UNIT_MS", DynamicUpdate = true, Lazy = true)]
	public class TUnitMs : ActiveRecordBase	{

		#region Private Members

		private string iUnitCd; 
		private string iUnitDesc; 
		private string iFrcCls; 
		private string iInqItem; 
		private DateTime iEntryDate; 
		private DateTime iUpdDate; 
		private string iUpdTimestamp; 
		
		#endregion

		#region Constuctor(s)
		
		public TUnitMs()
		{
			iUnitCd = String.Empty; 
			iUnitDesc = String.Empty; 
			iFrcCls = String.Empty; 
			iInqItem = String.Empty; 
			iEntryDate = DateTime.MinValue; 
			iUpdDate = DateTime.MinValue; 
			iUpdTimestamp = String.Empty; 

		}

		public TUnitMs(
			string i_unit_cd, 
			string i_frc_cls, 
			DateTime i_entry_date, 
			DateTime i_upd_date, 
			string i_upd_timestamp)
			: this()
		{
			iUnitCd = i_unit_cd;
			iUnitDesc = String.Empty;
			iFrcCls = i_frc_cls;
			iInqItem = String.Empty;
			iEntryDate = i_entry_date;
			iUpdDate = i_upd_date;
			iUpdTimestamp = i_upd_timestamp;
		}

		#endregion // End of Class Constuctor(s)
		
		#region Public Properties
			
		[PrimaryKey(PrimaryKeyType.Identity ,"I_UNIT_CD", Length=2)]
		public virtual string IUnitCd
		{
			get { return iUnitCd; }
			set { iUnitCd = value; }
		}

		[Property(Column="I_UNIT_DESC", Length=8)]
		public virtual string IUnitDesc
		{
			get { return iUnitDesc; }
			set { iUnitDesc = value; }
		}

		[Property(Column="I_FRC_CLS", NotNull=true, Length=2)]
		public virtual string IFrcCls
		{
			get { return iFrcCls; }
			set { iFrcCls = value; }
		}

		[Property(Column="I_INQ_ITEM", Length=1)]
		public virtual string IInqItem
		{
			get { return iInqItem; }
			set { iInqItem = value; }
		}

		[Property(Column="I_ENTRY_DATE", NotNull=true)]
		public virtual DateTime IEntryDate
		{
			get { return iEntryDate; }
			set { iEntryDate = value; }
		}

		[Property(Column="I_UPD_DATE", NotNull=true)]
		public virtual DateTime IUpdDate
		{
			get { return iUpdDate; }
			set { iUpdDate = value; }
		}

		[Property(Column="I_UPD_TIMESTAMP", NotNull=true, Length=17)]
		public virtual string IUpdTimestamp
		{
			get { return iUpdTimestamp; }
			set { iUpdTimestamp = value; }
		}


		#endregion 

			
		#region Equals, HashCode and ToString overrides
		
		/// <summary>
		/// Local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			if( this == obj ) return true;
			if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
			TUnitMs castObj = (TUnitMs)obj; 
			return ( castObj != null ) &&
				( this.iUnitCd == castObj.IUnitCd );
		}
		
		/// <summary>
		/// Local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * iUnitCd.GetHashCode();
			return hash; 
		}
		
		/// <summary>
		/// Local implementation of ToString based on class members
		/// </summary>
		public override String ToString()
        {
            StringBuilder sbuffer = new StringBuilder();
			sbuffer.Append("{");
			
			sbuffer.AppendFormat("IUnitCd = {0}, ",iUnitCd);
			sbuffer.AppendFormat("IUnitDesc = {0}, ",iUnitDesc);
			sbuffer.AppendFormat("IFrcCls = {0}, ",iFrcCls);
			sbuffer.AppendFormat("IInqItem = {0}, ",iInqItem);
			sbuffer.AppendFormat("IEntryDate = {0}, ",iEntryDate);
			sbuffer.AppendFormat("IUpdDate = {0}, ",iUpdDate);
			sbuffer.AppendFormat("IUpdTimestamp = {0}, ",iUpdTimestamp);
			sbuffer.Append(" }");
			return sbuffer.ToString();
        }
		
		#endregion
	}
}
