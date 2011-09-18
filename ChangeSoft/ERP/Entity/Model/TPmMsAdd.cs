using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Queries;


#region 'T_PM_MS_ADD' Schema
/*
 * 'TPmMsAdd' class maps to 'T_PM_MS_ADD' table.
 * 	 I_FAC_CD                | Type:VARCHAR2  | Len:8     | Nullable:F | PK:T | FK:F
 * 	 I_ITEM_CD               | Type:VARCHAR2  | Len:25    | Nullable:F | PK:T | FK:F
 * 	 I_ADD_NUMBER_1          | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ADD_NUMBER_2          | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ADD_NUMBER_3          | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ADD_NUMBER_4          | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ADD_NUMBER_5          | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ADD_NUMBER_6          | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ADD_NUMBER_7          | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ADD_NUMBER_8          | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ADD_NUMBER_9          | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ADD_NUMBER_10         | Type:NUMBER    | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ADD_VARCHAR2_1        | Type:VARCHAR2  | Len:25    | Nullable:T | PK:F | FK:F
 * 	 I_ADD_VARCHAR2_2        | Type:VARCHAR2  | Len:25    | Nullable:T | PK:F | FK:F
 * 	 I_ADD_VARCHAR2_3        | Type:VARCHAR2  | Len:25    | Nullable:T | PK:F | FK:F
 * 	 I_ADD_VARCHAR2_4        | Type:VARCHAR2  | Len:25    | Nullable:T | PK:F | FK:F
 * 	 I_ADD_VARCHAR2_5        | Type:VARCHAR2  | Len:25    | Nullable:T | PK:F | FK:F
 * 	 I_ADD_VARCHAR2_6        | Type:VARCHAR2  | Len:80    | Nullable:T | PK:F | FK:F
 * 	 I_ADD_VARCHAR2_7        | Type:VARCHAR2  | Len:80    | Nullable:T | PK:F | FK:F
 * 	 I_ADD_VARCHAR2_8        | Type:VARCHAR2  | Len:80    | Nullable:T | PK:F | FK:F
 * 	 I_ADD_VARCHAR2_9        | Type:VARCHAR2  | Len:80    | Nullable:T | PK:F | FK:F
 * 	 I_ADD_VARCHAR2_10       | Type:VARCHAR2  | Len:80    | Nullable:T | PK:F | FK:F
 * 	 I_ADD_VARCHAR2_11       | Type:VARCHAR2  | Len:120   | Nullable:T | PK:F | FK:F
 * 	 I_ADD_VARCHAR2_12       | Type:VARCHAR2  | Len:120   | Nullable:T | PK:F | FK:F
 * 	 I_ADD_VARCHAR2_13       | Type:VARCHAR2  | Len:120   | Nullable:T | PK:F | FK:F
 * 	 I_ADD_VARCHAR2_14       | Type:VARCHAR2  | Len:120   | Nullable:T | PK:F | FK:F
 * 	 I_ADD_VARCHAR2_15       | Type:VARCHAR2  | Len:120   | Nullable:T | PK:F | FK:F
 * 	 I_ADD_DATE_1            | Type:DATE      | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ADD_DATE_2            | Type:DATE      | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ADD_DATE_3            | Type:DATE      | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ADD_DATE_4            | Type:DATE      | Len:0     | Nullable:T | PK:F | FK:F
 * 	 I_ADD_DATE_5            | Type:DATE      | Len:0     | Nullable:T | PK:F | FK:F
 */
#endregion
/// <summary>
///	Generated by MyGeneration using the ActiveRecord Object Mapper - 1.0.2
///	Created on 2011/9/17 23:15:03
/// </summary>
namespace Com.GainWinSoft.ERP.Entity
{
    [Serializable, ActiveRecord("T_PM_MS_ADD")]
    public class TPmMsAdd : ActiveRecordBase
    {

        #region Private Members

        private TPmMsId id;
        private decimal iAddNumber1;
        private decimal iAddNumber2;
        private decimal iAddNumber3;
        private decimal iAddNumber4;
        private decimal iAddNumber5;
        private decimal iAddNumber6;
        private decimal iAddNumber7;
        private decimal iAddNumber8;
        private decimal iAddNumber9;
        private decimal iAddNumber10;
        private string iAddVarchar21;
        private string iAddVarchar22;
        private string iAddVarchar23;
        private string iAddVarchar24;
        private string iAddVarchar25;
        private string iAddVarchar26;
        private string iAddVarchar27;
        private string iAddVarchar28;
        private string iAddVarchar29;
        private string iAddVarchar210;
        private string iAddVarchar211;
        private string iAddVarchar212;
        private string iAddVarchar213;
        private string iAddVarchar214;
        private string iAddVarchar215;
        private DateTime iAddDate1;
        private DateTime iAddDate2;
        private DateTime iAddDate3;
        private DateTime iAddDate4;
        private DateTime iAddDate5;

        #endregion

        #region Constuctor(s)

        public TPmMsAdd()
        {
            id = new TPmMsId();
            id.IFacCd = String.Empty;
            id.IItemCd = String.Empty;
            iAddNumber1 = 0;
            iAddNumber2 = 0;
            iAddNumber3 = 0;
            iAddNumber4 = 0;
            iAddNumber5 = 0;
            iAddNumber6 = 0;
            iAddNumber7 = 0;
            iAddNumber8 = 0;
            iAddNumber9 = 0;
            iAddNumber10 = 0;
            iAddVarchar21 = String.Empty;
            iAddVarchar22 = String.Empty;
            iAddVarchar23 = String.Empty;
            iAddVarchar24 = String.Empty;
            iAddVarchar25 = String.Empty;
            iAddVarchar26 = String.Empty;
            iAddVarchar27 = String.Empty;
            iAddVarchar28 = String.Empty;
            iAddVarchar29 = String.Empty;
            iAddVarchar210 = String.Empty;
            iAddVarchar211 = String.Empty;
            iAddVarchar212 = String.Empty;
            iAddVarchar213 = String.Empty;
            iAddVarchar214 = String.Empty;
            iAddVarchar215 = String.Empty;
            iAddDate1 = DateTime.MinValue;
            iAddDate2 = DateTime.MinValue;
            iAddDate3 = DateTime.MinValue;
            iAddDate4 = DateTime.MinValue;
            iAddDate5 = DateTime.MinValue;

        }

        public TPmMsAdd(
            string i_fac_cd,
            string i_item_cd)
            : this()
        {
            id = new TPmMsId();
            id.IFacCd = i_fac_cd;
            id.IItemCd = i_item_cd;
            iAddNumber1 = 0;
            iAddNumber2 = 0;
            iAddNumber3 = 0;
            iAddNumber4 = 0;
            iAddNumber5 = 0;
            iAddNumber6 = 0;
            iAddNumber7 = 0;
            iAddNumber8 = 0;
            iAddNumber9 = 0;
            iAddNumber10 = 0;
            iAddVarchar21 = String.Empty;
            iAddVarchar22 = String.Empty;
            iAddVarchar23 = String.Empty;
            iAddVarchar24 = String.Empty;
            iAddVarchar25 = String.Empty;
            iAddVarchar26 = String.Empty;
            iAddVarchar27 = String.Empty;
            iAddVarchar28 = String.Empty;
            iAddVarchar29 = String.Empty;
            iAddVarchar210 = String.Empty;
            iAddVarchar211 = String.Empty;
            iAddVarchar212 = String.Empty;
            iAddVarchar213 = String.Empty;
            iAddVarchar214 = String.Empty;
            iAddVarchar215 = String.Empty;
            iAddDate1 = DateTime.MinValue;
            iAddDate2 = DateTime.MinValue;
            iAddDate3 = DateTime.MinValue;
            iAddDate4 = DateTime.MinValue;
            iAddDate5 = DateTime.MinValue;
        }

        #endregion // End of Class Constuctor(s)

        #region Public Properties
        [CompositeKey]
        public Com.GainWinSoft.ERP.Entity.TPmMsId Id
        {
            get { return id; }
            set { id = value; }
        }

        [Property(Column = "I_ADD_NUMBER_1")]
        public virtual decimal IAddNumber1
        {
            get { return iAddNumber1; }
            set { iAddNumber1 = value; }
        }

        [Property(Column = "I_ADD_NUMBER_2")]
        public virtual decimal IAddNumber2
        {
            get { return iAddNumber2; }
            set { iAddNumber2 = value; }
        }

        [Property(Column = "I_ADD_NUMBER_3")]
        public virtual decimal IAddNumber3
        {
            get { return iAddNumber3; }
            set { iAddNumber3 = value; }
        }

        [Property(Column = "I_ADD_NUMBER_4")]
        public virtual decimal IAddNumber4
        {
            get { return iAddNumber4; }
            set { iAddNumber4 = value; }
        }

        [Property(Column = "I_ADD_NUMBER_5")]
        public virtual decimal IAddNumber5
        {
            get { return iAddNumber5; }
            set { iAddNumber5 = value; }
        }

        [Property(Column = "I_ADD_NUMBER_6")]
        public virtual decimal IAddNumber6
        {
            get { return iAddNumber6; }
            set { iAddNumber6 = value; }
        }

        [Property(Column = "I_ADD_NUMBER_7")]
        public virtual decimal IAddNumber7
        {
            get { return iAddNumber7; }
            set { iAddNumber7 = value; }
        }

        [Property(Column = "I_ADD_NUMBER_8")]
        public virtual decimal IAddNumber8
        {
            get { return iAddNumber8; }
            set { iAddNumber8 = value; }
        }

        [Property(Column = "I_ADD_NUMBER_9")]
        public virtual decimal IAddNumber9
        {
            get { return iAddNumber9; }
            set { iAddNumber9 = value; }
        }

        [Property(Column = "I_ADD_NUMBER_10")]
        public virtual decimal IAddNumber10
        {
            get { return iAddNumber10; }
            set { iAddNumber10 = value; }
        }

        [Property(Column = "I_ADD_VARCHAR2_1", Length = 25)]
        public virtual string IAddVarchar21
        {
            get { return iAddVarchar21; }
            set { iAddVarchar21 = value; }
        }

        [Property(Column = "I_ADD_VARCHAR2_2", Length = 25)]
        public virtual string IAddVarchar22
        {
            get { return iAddVarchar22; }
            set { iAddVarchar22 = value; }
        }

        [Property(Column = "I_ADD_VARCHAR2_3", Length = 25)]
        public virtual string IAddVarchar23
        {
            get { return iAddVarchar23; }
            set { iAddVarchar23 = value; }
        }

        [Property(Column = "I_ADD_VARCHAR2_4", Length = 25)]
        public virtual string IAddVarchar24
        {
            get { return iAddVarchar24; }
            set { iAddVarchar24 = value; }
        }

        [Property(Column = "I_ADD_VARCHAR2_5", Length = 25)]
        public virtual string IAddVarchar25
        {
            get { return iAddVarchar25; }
            set { iAddVarchar25 = value; }
        }

        [Property(Column = "I_ADD_VARCHAR2_6", Length = 80)]
        public virtual string IAddVarchar26
        {
            get { return iAddVarchar26; }
            set { iAddVarchar26 = value; }
        }

        [Property(Column = "I_ADD_VARCHAR2_7", Length = 80)]
        public virtual string IAddVarchar27
        {
            get { return iAddVarchar27; }
            set { iAddVarchar27 = value; }
        }

        [Property(Column = "I_ADD_VARCHAR2_8", Length = 80)]
        public virtual string IAddVarchar28
        {
            get { return iAddVarchar28; }
            set { iAddVarchar28 = value; }
        }

        [Property(Column = "I_ADD_VARCHAR2_9", Length = 80)]
        public virtual string IAddVarchar29
        {
            get { return iAddVarchar29; }
            set { iAddVarchar29 = value; }
        }

        [Property(Column = "I_ADD_VARCHAR2_10", Length = 80)]
        public virtual string IAddVarchar210
        {
            get { return iAddVarchar210; }
            set { iAddVarchar210 = value; }
        }

        [Property(Column = "I_ADD_VARCHAR2_11", Length = 120)]
        public virtual string IAddVarchar211
        {
            get { return iAddVarchar211; }
            set { iAddVarchar211 = value; }
        }

        [Property(Column = "I_ADD_VARCHAR2_12", Length = 120)]
        public virtual string IAddVarchar212
        {
            get { return iAddVarchar212; }
            set { iAddVarchar212 = value; }
        }

        [Property(Column = "I_ADD_VARCHAR2_13", Length = 120)]
        public virtual string IAddVarchar213
        {
            get { return iAddVarchar213; }
            set { iAddVarchar213 = value; }
        }

        [Property(Column = "I_ADD_VARCHAR2_14", Length = 120)]
        public virtual string IAddVarchar214
        {
            get { return iAddVarchar214; }
            set { iAddVarchar214 = value; }
        }

        [Property(Column = "I_ADD_VARCHAR2_15", Length = 120)]
        public virtual string IAddVarchar215
        {
            get { return iAddVarchar215; }
            set { iAddVarchar215 = value; }
        }

        [Property(Column = "I_ADD_DATE_1")]
        public virtual DateTime IAddDate1
        {
            get { return iAddDate1; }
            set { iAddDate1 = value; }
        }

        [Property(Column = "I_ADD_DATE_2")]
        public virtual DateTime IAddDate2
        {
            get { return iAddDate2; }
            set { iAddDate2 = value; }
        }

        [Property(Column = "I_ADD_DATE_3")]
        public virtual DateTime IAddDate3
        {
            get { return iAddDate3; }
            set { iAddDate3 = value; }
        }

        [Property(Column = "I_ADD_DATE_4")]
        public virtual DateTime IAddDate4
        {
            get { return iAddDate4; }
            set { iAddDate4 = value; }
        }

        [Property(Column = "I_ADD_DATE_5")]
        public virtual DateTime IAddDate5
        {
            get { return iAddDate5; }
            set { iAddDate5 = value; }
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
            TPmMsAdd castObj = (TPmMsAdd)obj;
            return (castObj != null) &&
                (this.id == castObj.id) ;
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

            sbuffer.AppendFormat("IFacCd = {0}, ", id.IFacCd);
            sbuffer.AppendFormat("IItemCd = {0}, ", id.IItemCd);
            sbuffer.AppendFormat("IAddNumber1 = {0}, ", iAddNumber1);
            sbuffer.AppendFormat("IAddNumber2 = {0}, ", iAddNumber2);
            sbuffer.AppendFormat("IAddNumber3 = {0}, ", iAddNumber3);
            sbuffer.AppendFormat("IAddNumber4 = {0}, ", iAddNumber4);
            sbuffer.AppendFormat("IAddNumber5 = {0}, ", iAddNumber5);
            sbuffer.AppendFormat("IAddNumber6 = {0}, ", iAddNumber6);
            sbuffer.AppendFormat("IAddNumber7 = {0}, ", iAddNumber7);
            sbuffer.AppendFormat("IAddNumber8 = {0}, ", iAddNumber8);
            sbuffer.AppendFormat("IAddNumber9 = {0}, ", iAddNumber9);
            sbuffer.AppendFormat("IAddNumber10 = {0}, ", iAddNumber10);
            sbuffer.AppendFormat("IAddVarchar21 = {0}, ", iAddVarchar21);
            sbuffer.AppendFormat("IAddVarchar22 = {0}, ", iAddVarchar22);
            sbuffer.AppendFormat("IAddVarchar23 = {0}, ", iAddVarchar23);
            sbuffer.AppendFormat("IAddVarchar24 = {0}, ", iAddVarchar24);
            sbuffer.AppendFormat("IAddVarchar25 = {0}, ", iAddVarchar25);
            sbuffer.AppendFormat("IAddVarchar26 = {0}, ", iAddVarchar26);
            sbuffer.AppendFormat("IAddVarchar27 = {0}, ", iAddVarchar27);
            sbuffer.AppendFormat("IAddVarchar28 = {0}, ", iAddVarchar28);
            sbuffer.AppendFormat("IAddVarchar29 = {0}, ", iAddVarchar29);
            sbuffer.AppendFormat("IAddVarchar210 = {0}, ", iAddVarchar210);
            sbuffer.AppendFormat("IAddVarchar211 = {0}, ", iAddVarchar211);
            sbuffer.AppendFormat("IAddVarchar212 = {0}, ", iAddVarchar212);
            sbuffer.AppendFormat("IAddVarchar213 = {0}, ", iAddVarchar213);
            sbuffer.AppendFormat("IAddVarchar214 = {0}, ", iAddVarchar214);
            sbuffer.AppendFormat("IAddVarchar215 = {0}, ", iAddVarchar215);
            sbuffer.AppendFormat("IAddDate1 = {0}, ", iAddDate1);
            sbuffer.AppendFormat("IAddDate2 = {0}, ", iAddDate2);
            sbuffer.AppendFormat("IAddDate3 = {0}, ", iAddDate3);
            sbuffer.AppendFormat("IAddDate4 = {0}, ", iAddDate4);
            sbuffer.AppendFormat("IAddDate5 = {0}, ", iAddDate5);
            sbuffer.Append(" }");
            return sbuffer.ToString();
        }

        #endregion

    }
}
