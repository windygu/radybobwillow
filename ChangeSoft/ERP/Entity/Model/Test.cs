using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Queries;


#region 'test' Schema
/*
 * 'Test' class maps to 'test' table.
 * 	 userid                  | Type:numeric   | Len:0     | Nullable:F | PK:T | FK:F
 * 	 loginid                 | Type:varchar   | Len:25    | Nullable:T | PK:F | FK:F
 * 	 username                | Type:varchar   | Len:20    | Nullable:T | PK:F | FK:F
 */
#endregion
/// <summary>
///	Generated by MyGeneration using the ActiveRecord Object Mapper - 1.0.2
///	Created on 2011/8/16 20:46:49
/// </summary>
namespace Com.GainWinSoft.ERP.Entity
{
	[Serializable , ActiveRecord("TEST")]
	public class Test : ActiveRecordBase	{

		#region Private Members

		private int userid; 
		private string loginid; 
		private string username; 
		
		#endregion

		#region Constuctor(s)
		
		public Test()
		{
			userid = 0; 
			loginid = String.Empty; 
			username = String.Empty; 
            
		}

		public Test(
			int uid)
			: this()
		{
            userid = uid;
			loginid = String.Empty;
			username = String.Empty;
		}

		#endregion // End of Class Constuctor(s)
		
		#region Public Properties
			
		[PrimaryKey(PrimaryKeyType.Assigned, "USERID")]
		public virtual int Userid
		{
			get { return userid; }
			set { userid = value; }
		}

		[Property(Column="LOGINID", Length=20)]
		public virtual string Loginid
		{
			get { return loginid; }
			set { loginid = value; }
		}

		[Property(Column="USERNAME", Length=100)]
		public virtual string Username
		{
			get { return username; }
			set { username = value; }
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
			Test castObj = (Test)obj; 
			return ( castObj != null ) &&
				( this.userid == castObj.Userid );
		}
		
		/// <summary>
		/// Local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * userid.GetHashCode();
			return hash; 
		}
		
		/// <summary>
		/// Local implementation of ToString based on class members
		/// </summary>
		public override String ToString()
        {
            StringBuilder sbuffer = new StringBuilder();
			sbuffer.Append("{");
			
			sbuffer.AppendFormat("Userid = {0}, ",userid);
			sbuffer.AppendFormat("Loginid = {0}, ",loginid);
			sbuffer.AppendFormat("Username = {0}, ",username);
			sbuffer.Append(" }");
			return sbuffer.ToString();
        }
		
		#endregion


	}
}
