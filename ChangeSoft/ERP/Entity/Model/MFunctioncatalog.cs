using System;
using System.Text;
using Castle.ActiveRecord;



#region 'M_FUNCTIONCATALOG' Schema
/*
 * 'MFunctioncatalog' class maps to 'M_FUNCTIONCATALOG' table.
 * 	 LANGID                  | Type:NVARCHAR2 | Len:10    | Nullable:F | PK:T | FK:F
 * 	 CATALOGID               | Type:NUMBER    | Len:0     | Nullable:F | PK:T | FK:F
 * 	 CATALOGNAME             | Type:NVARCHAR2 | Len:50    | Nullable:T | PK:F | FK:F
 */
#endregion
/// <summary>
///	Generated by MyGeneration using the ActiveRecord Object Mapper - 1.0.2
///	Created on 2011/8/21 10:27:18
/// </summary>
namespace Com.ChangeSoft.ERP.Entity
{
	[Serializable , ActiveRecord("M_FUNCTIONCATALOG")]
	public class MFunctioncatalog : ActiveRecordBase	{

		#region Private Members

        private MFunctioncatalogID id; 
		private string catalogname; 
		
		#endregion

		#region Constuctor(s)
		
		public MFunctioncatalog()
		{
            id = new MFunctioncatalogID();
			catalogname = String.Empty; 

		}

		public MFunctioncatalog(
			string _langid, 
			int _catalogid)
			: this()
		{
            id = new MFunctioncatalogID();
            id.Catalogid = _catalogid;
            id.Langid = _langid;
			catalogname = String.Empty;
		}

		#endregion // End of Class Constuctor(s)
		
		#region Public Properties

		[CompositeKey]
		public virtual MFunctioncatalogID Id
		{
			get { return id; }
			set { id = value; }
		}

		[Property(Column="CATALOGNAME", Length=50)]
		public virtual string Catalogname
		{
			get { return catalogname; }
			set { catalogname = value; }
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
			MFunctioncatalog castObj = (MFunctioncatalog)obj;
            return (castObj != null) &&
                (this.id == castObj.id);
		}
		
		/// <summary>
		/// Local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * id.GetHashCode();
			return hash; 
		}
		
		/// <summary>
		/// Local implementation of ToString based on class members
		/// </summary>
		public override String ToString()
        {
            StringBuilder sbuffer = new StringBuilder();
			sbuffer.Append("{");
			
			sbuffer.AppendFormat("Langid = {0}, ",id.Langid);
			sbuffer.AppendFormat("Catalogid = {0}, ",id.Catalogid);
			sbuffer.AppendFormat("Catalogname = {0}, ",catalogname);
			sbuffer.Append(" }");
			return sbuffer.ToString();
        }
		
		#endregion
	}


}
