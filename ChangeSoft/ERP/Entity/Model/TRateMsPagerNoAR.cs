using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Queries;


#region 'T_Rate_Ms' Schema
/*
 
 */
#endregion
/// <summary>
///	Generated by MyGeneration using the ActiveRecord Object Mapper - 1.0.2
///	
/// 
///	Created on 2011/8/24 20:15:02
/// </summary>
namespace Com.GainWinSoft.ERP.Entity
{
    [Serializable]
    public class TRateMsPagerNoAR
    {
        #region Private Members

        private string iCompanyCd;
        private string iRateCls;
        private string iRateClsDesc;
        private string iDlCurrCd;
        private string iDlCurrCdDesc;

        private decimal iEffEndDate;


        private TRateMsID id;

        private decimal iRate;
        private string iCnvMethod;
        private string iCnvMethodDesc;

        private DateTime iEntryDate;
        private DateTime iUpdDate;
        private string iUpdTimestamp;

        #endregion


        #region Public Properties()
        public string ICompanyCd
        {
            get { return iCompanyCd; }
            set { iCompanyCd = value; }
        }

        public string IRateCls
        {
            get { return iRateCls; }
            set { iRateCls = value; }
        }

        public string IRateClsDesc
        {
            get { return iRateClsDesc; }
            set { iRateClsDesc = value; }
        }

        public string IDlCurrCd
        {
            get { return iDlCurrCd; }
            set { iDlCurrCd = value; }
        }

        public string IDlCurrCdDesc
        {
            get { return iDlCurrCdDesc; }
            set { iDlCurrCdDesc = value; }
        }

        public decimal IEffEndDate
        {
            get { return iEffEndDate; }
            set { iEffEndDate = value; }
        }

        public Com.GainWinSoft.ERP.Entity.TRateMsID Id
        {
            get { return id; }
            set { id = value; }
        }

        public decimal IRate
        {
            get { return iRate; }
            set { iRate = value; }
        }

        public string ICnvMethod
        {
            get { return iCnvMethod; }
            set { iCnvMethod = value; }
        }

        public string ICnvMethodDesc
        {
            get { return iCnvMethodDesc; }
            set { iCnvMethodDesc = value; }
        }

        public System.DateTime IEntryDate
        {
            get { return iEntryDate; }
            set { iEntryDate = value; }
        }

        public System.DateTime IUpdDate
        {
            get { return iUpdDate; }
            set { iUpdDate = value; }
        }

        public string IUpdTimestamp
        {
            get { return iUpdTimestamp; }
            set { iUpdTimestamp = value; }
        }
        #endregion

    }
}
