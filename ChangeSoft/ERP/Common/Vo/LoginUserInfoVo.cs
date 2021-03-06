﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.GainWinSoft.Common.Vo
{
    public class LoginUserInfoVo
    {
        private string userid;

        public string Userid
        {
            get { return userid; }
            set { userid = value; }
        }
        private string companyid;

        public string Companyid
        {
            get { return companyid; }
            set { companyid = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string namepinyin;

        public string Namepinyin
        {
            get { return namepinyin; }
            set { namepinyin = value; }
        }
        private string usertype;

        public string Usertype
        {
            get { return usertype; }
            set { usertype = value; }
        }
        private string mappingid;

        public string Mappingid
        {
            get { return mappingid; }
            set { mappingid = value; }
        }
        private string deleteflag;

        public string Deleteflag
        {
            get { return deleteflag; }
            set { deleteflag = value; }
        }
        private string temppasswordflag;

        public string Temppasswordflag
        {
            get { return temppasswordflag; }
            set { temppasswordflag = value; }
        }
        private string lockflag;

        public string Lockflag
        {
            get { return lockflag; }
            set { lockflag = value; }
        }
        private IList<RoleUserVo> roleuserlist;

        public IList<RoleUserVo> Roleuserlist
        {
            get { return roleuserlist; }
            set { roleuserlist = value; }
        }
        private IList<FunctionVo> rolefunctionlist;

        public IList<FunctionVo> Rolefunctionlist
        {
            get { return rolefunctionlist; }
            set { rolefunctionlist = value; }
        }


        private PersonVo person;

        public PersonVo Person
        {
            get { return person; }
            set { person = value; }
        }

        private CompanyConditionVo companyCondition;

        public CompanyConditionVo CompanyCondition
        {
            get { return companyCondition; }
            set { companyCondition = value; }
        }

        private FactoryVo factory;

        public FactoryVo Factory
        {
            get { return factory; }
            set { factory = value; }
        }
        private TermVo term;

        public TermVo Term
        {
            get { return term; }
            set { term = value; }
        }


 



    }
}
