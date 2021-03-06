using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Queries;


#region 'T_WAREHOUSE_MS' Schema
/*
 * 'TWarehouseMs' class maps to 'T_WAREHOUSE_MS' table.
 * 	 I_FAC_CD                | Type:VARCHAR2  | Len:8     | Nullable:F | PK:T | FK:F
 * 	 I_CONDITION_CD          | Type:VARCHAR2  | Len:6     | Nullable:T | PK:F | FK:F
 * 	 I_INSPECTON_LOCATION    | Type:VARCHAR2  | Len:8     | Nullable:F | PK:F | FK:F
 * 	 I_RJT_WH_CD             | Type:VARCHAR2  | Len:8     | Nullable:F | PK:F | FK:F
 * 	 I_NON_ALLOC_LOCATION    | Type:VARCHAR2  | Len:8     | Nullable:F | PK:F | FK:F
 * 	 I_OS_WH_CD              | Type:VARCHAR2  | Len:8     | Nullable:F | PK:F | FK:F
 * 	 I_NON_SALES_WH_CD       | Type:VARCHAR2  | Len:8     | Nullable:F | PK:F | FK:F
 * 	 I_DEL_WH_IN_CD          | Type:VARCHAR2  | Len:8     | Nullable:T | PK:F | FK:F
 * 	 I_DEL_WH_OUT_CD         | Type:VARCHAR2  | Len:8     | Nullable:T | PK:F | FK:F
 * 	 I_ENTRY_DATE            | Type:DATE      | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_UPD_DATE              | Type:DATE      | Len:0     | Nullable:F | PK:F | FK:F
 * 	 I_UPD_TIMESTAMP         | Type:VARCHAR2  | Len:17    | Nullable:F | PK:F | FK:F
 */
#endregion
/// <summary>
///	Generated by MyGeneration using the ActiveRecord Object Mapper - 1.0.2
///	Created on 2011/09/13 15:38:50
/// </summary>
namespace Com.GainWinSoft.ERP.Entity
{
	[Serializable , ActiveRecord("T_WAREHOUSE_MS")]
	public class TWarehouseMs : ActiveRecordBase	{

		#region Private Members

		private string iFacCd; 
		private string iConditionCd; 
		private string iInspectonLocation; 
		private string iRjtWhCd; 
		private string iNonAllocLocation; 
		private string iOsWhCd; 
		private string iNonSalesWhCd; 
		private string iDelWhInCd; 
		private string iDelWhOutCd; 
		private DateTime iEntryDate; 
		private DateTime iUpdDate; 
		private string iUpdTimestamp; 
		
		#endregion

		#region Constuctor(s)
		
		public TWarehouseMs()
		{
			iFacCd = String.Empty; 
			iConditionCd = String.Empty; 
			iInspectonLocation = String.Empty; 
			iRjtWhCd = String.Empty; 
			iNonAllocLocation = String.Empty; 
			iOsWhCd = String.Empty; 
			iNonSalesWhCd = String.Empty; 
			iDelWhInCd = String.Empty; 
			iDelWhOutCd = String.Empty; 
			iEntryDate = DateTime.MinValue; 
			iUpdDate = DateTime.MinValue; 
			iUpdTimestamp = String.Empty; 

		}

		public TWarehouseMs(
			string i_fac_cd, 
			string i_inspecton_location, 
			string i_rjt_wh_cd, 
			string i_non_alloc_location, 
			string i_os_wh_cd, 
			string i_non_sales_wh_cd, 
			DateTime i_entry_date, 
			DateTime i_upd_date, 
			string i_upd_timestamp)
			: this()
		{
			iFacCd = i_fac_cd;
			iConditionCd = String.Empty;
			iInspectonLocation = i_inspecton_location;
			iRjtWhCd = i_rjt_wh_cd;
			iNonAllocLocation = i_non_alloc_location;
			iOsWhCd = i_os_wh_cd;
			iNonSalesWhCd = i_non_sales_wh_cd;
			iDelWhInCd = String.Empty;
			iDelWhOutCd = String.Empty;
			iEntryDate = i_entry_date;
			iUpdDate = i_upd_date;
			iUpdTimestamp = i_upd_timestamp;
		}

		#endregion // End of Class Constuctor(s)
		
		#region Public Properties
			
		[PrimaryKey(PrimaryKeyType.Assigned ,"I_FAC_CD", Length=8)]
		public virtual string IFacCd
		{
			get { return iFacCd; }
			set { iFacCd = value; }
		}

		[Property(Column="I_CONDITION_CD", Length=6)]
		public virtual string IConditionCd
		{
			get { return iConditionCd; }
			set { iConditionCd = value; }
		}

		[Property(Column="I_INSPECTON_LOCATION", NotNull=true, Length=8)]
		public virtual string IInspectonLocation
		{
			get { return iInspectonLocation; }
			set { iInspectonLocation = value; }
		}

		[Property(Column="I_RJT_WH_CD", NotNull=true, Length=8)]
		public virtual string IRjtWhCd
		{
			get { return iRjtWhCd; }
			set { iRjtWhCd = value; }
		}

		[Property(Column="I_NON_ALLOC_LOCATION", NotNull=true, Length=8)]
		public virtual string INonAllocLocation
		{
			get { return iNonAllocLocation; }
			set { iNonAllocLocation = value; }
		}

		[Property(Column="I_OS_WH_CD", NotNull=true, Length=8)]
		public virtual string IOsWhCd
		{
			get { return iOsWhCd; }
			set { iOsWhCd = value; }
		}

		[Property(Column="I_NON_SALES_WH_CD", NotNull=true, Length=8)]
		public virtual string INonSalesWhCd
		{
			get { return iNonSalesWhCd; }
			set { iNonSalesWhCd = value; }
		}

		[Property(Column="I_DEL_WH_IN_CD", Length=8)]
		public virtual string IDelWhInCd
		{
			get { return iDelWhInCd; }
			set { iDelWhInCd = value; }
		}

		[Property(Column="I_DEL_WH_OUT_CD", Length=8)]
		public virtual string IDelWhOutCd
		{
			get { return iDelWhOutCd; }
			set { iDelWhOutCd = value; }
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
			TWarehouseMs castObj = (TWarehouseMs)obj; 
			return ( castObj != null ) &&
				( this.iFacCd == castObj.IFacCd );
		}
		
		/// <summary>
		/// Local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * iFacCd.GetHashCode();
			return hash; 
		}
		
		/// <summary>
		/// Local implementation of ToString based on class members
		/// </summary>
		public override String ToString()
        {
            StringBuilder sbuffer = new StringBuilder();
			sbuffer.Append("{");
			
			sbuffer.AppendFormat("IFacCd = {0}, ",iFacCd);
			sbuffer.AppendFormat("IConditionCd = {0}, ",iConditionCd);
			sbuffer.AppendFormat("IInspectonLocation = {0}, ",iInspectonLocation);
			sbuffer.AppendFormat("IRjtWhCd = {0}, ",iRjtWhCd);
			sbuffer.AppendFormat("INonAllocLocation = {0}, ",iNonAllocLocation);
			sbuffer.AppendFormat("IOsWhCd = {0}, ",iOsWhCd);
			sbuffer.AppendFormat("INonSalesWhCd = {0}, ",iNonSalesWhCd);
			sbuffer.AppendFormat("IDelWhInCd = {0}, ",iDelWhInCd);
			sbuffer.AppendFormat("IDelWhOutCd = {0}, ",iDelWhOutCd);
			sbuffer.AppendFormat("IEntryDate = {0}, ",iEntryDate);
			sbuffer.AppendFormat("IUpdDate = {0}, ",iUpdDate);
			sbuffer.AppendFormat("IUpdTimestamp = {0}, ",iUpdTimestamp);
			sbuffer.Append(" }");
			return sbuffer.ToString();
        }
		
		#endregion
	}
}
