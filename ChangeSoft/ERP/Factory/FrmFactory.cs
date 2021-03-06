﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Com.GainWinSoft.Common;
using WeifenLuo.WinFormsUI.Docking;
using Com.GainWinSoft.Common.Vo;
using Noogen.Validation;
using Com.GainWinSoft.ERP.MasterCheck;
using Com.GainWinSoft.ERP.Factory.Action;
using Com.GainWinSoft.ERP.Entity;
using System.Runtime.InteropServices;

namespace Com.GainWinSoft.ERP.Factory
{
    public partial class FrmFactory : BaseContent
    {
        /// <summary>
        /// 画面操作模式
        /// </summary>
        private string strMode = "";
        /// <summary>
        /// 利用者情报
        /// </summary>
        private LoginUserInfoVo uservo;

        /// <summary>
        /// Check用Validation
        /// </summary>
        private ValidationProvider vdpRequireG1;
        private ValidationProvider vdpRequireG2;
        private ValidationProvider vdpExistG1;
        private ValidationProvider vdpExistG2;
        private ValidationProvider vdpCustomG1;
        private ValidationProvider vdpCustomG2;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        public FrmFactory(DockPanel _parentdockpanel)
            : base(_parentdockpanel)
        {
            InitializeComponent();
        }

        #region 方法
        /// <summary>
        /// 画面加载初期化处理
        /// </summary>
        private void FrmFactory_Load(object sender, System.EventArgs e)
        {
            this.Check_Init();
            this.Initialize();
        }

        /// <summary>
        /// 初期化处理
        /// </summary>
        private void Initialize()
        {
            this.uservo = (LoginUserInfoVo)SessionUtils.GetSession(SessionUtils.COMMON_LOGIN_USER_INFO);
            if (string.IsNullOrEmpty(strMode))
            {
                this.strMode = Constant.MODE_ADD;
            }

            this.SetToolBar(this.strMode);
            this.SetLayout(this.strMode);
            this.removeAllClickEvent();
            this.addAllClickEvent();

            this.txtCompany.Text = this.uservo.CompanyCondition.ICompanyCd;
            #region Company delete
            this.lblCompany.Visible = false;
            this.lblStar2.Visible = false;
            this.txtCompany.Visible = false;
            this.txtCompany.Enabled = false;
            this.txtCompany.TabStop = false;
            this.lblCompanyNM.Visible = false;
            this.btnCompany.Visible = false;
            this.btnCompany.TabStop = false;
            #endregion

            this.Activate();
            this.GotFocus += new EventHandler(FrmFactory_GotFocus);
        }

        void FrmFactory_GotFocus(object sender, EventArgs e)
        {
            this.SetFocus();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Winapi)]
        internal static extern IntPtr GetFocus();
        /// <summary>
        /// 此方法引入系统user32.dll,获得当前获得焦点的控件
        /// </summary>
        /// <returns></returns>
        private Control GetFocusedControl()
        {
            Control FocusedControl = null;
            IntPtr FocusedHandle = GetFocus();
            if (FocusedHandle != IntPtr.Zero)
                FocusedControl = Control.FromHandle(FocusedHandle);
            return FocusedControl;
        }

        /// <summary>
        /// 移除全部按钮的点击事件
        /// </summary>
        private void removeAllClickEvent()
        {
            this.commonToolStrip1.AddClick -= new EventHandler(commonToolStrip1_AddClick);
            this.commonToolStrip1.DeleteClick -= new EventHandler(commonToolStrip1_DeleteClick);
            this.commonToolStrip1.UpdateClick -= new EventHandler(commonToolStrip1_UpdateClick);
            this.commonToolStrip1.SaveClick -= new EventHandler(commonToolStrip1_SaveClick);
            this.commonToolStrip1.GobackClick -= new EventHandler(commonToolStrip1_GobackClick);
            this.commonToolStrip1.OkClick -= new EventHandler(commonToolStrip1_OkClick);
        }

        /// <summary>
        /// 添加全部按钮的点击事件
        /// </summary>
        private void addAllClickEvent()
        {
            this.commonToolStrip1.AddClick += new EventHandler(commonToolStrip1_AddClick);
            this.commonToolStrip1.DeleteClick += new EventHandler(commonToolStrip1_DeleteClick);
            this.commonToolStrip1.UpdateClick += new EventHandler(commonToolStrip1_UpdateClick);
            this.commonToolStrip1.SaveClick += new EventHandler(commonToolStrip1_SaveClick);
            this.commonToolStrip1.GobackClick += new EventHandler(commonToolStrip1_GobackClick);
            this.commonToolStrip1.OkClick += new EventHandler(commonToolStrip1_OkClick);
        }

        /// <summary>
        /// 确定按钮的点击事件
        /// </summary>
        private void commonToolStrip1_OkClick(object sender, EventArgs e)
        {
            this.ClearError();
            if (!this.CheckG1())
            {
                return;
            }

            this.LoadData();
            this.SetLayoutG1G2();
            this.SetToolBarG1G2();

            if (Constant.MODE_DEL.Equals(this.strMode))
            {
                this.tpG2.Enabled = false;
            }
            this.SetFocus();
        }

        /// <summary>
        /// 返回按钮的点击事件
        /// </summary>
        private void commonToolStrip1_GobackClick(object sender, EventArgs e)
        {
            this.ClearError();
            this.SetLayoutG2G1();
            this.SetToolBarG2G1();
            this.SetFocus();
        }

        /// <summary>
        /// 保存按钮的点击事件
        /// </summary>
        private void commonToolStrip1_SaveClick(object sender, EventArgs e)
        {
            this.ClearError();
            if (!this.CheckG1())
            {
                return;
            }
            if (!this.CheckG2())
            {
                return;
            }

            this.SaveData();
            this.SetFocus();
        }

        /// <summary>
        /// 修改按钮的点击事件
        /// </summary>
        private void commonToolStrip1_UpdateClick(object sender, EventArgs e)
        {
            this.strMode = Constant.MODE_UPD;
            this.ClearError();
            this.SetToolBar(this.strMode);
            this.SetLayout(this.strMode);
            this.SetFocus();
        }

        /// <summary>
        /// 删除按钮的点击事件
        /// </summary>
        private void commonToolStrip1_DeleteClick(object sender, EventArgs e)
        {
            this.strMode = Constant.MODE_DEL;
            this.ClearError(); 
            this.SetToolBar(this.strMode);
            this.SetLayout(this.strMode);
            this.SetFocus();
        }

        /// <summary>
        /// 追加按钮的点击事件
        /// </summary>
        private void commonToolStrip1_AddClick(object sender, EventArgs e)
        {
            this.strMode = Constant.MODE_ADD;
            this.ClearError();
            this.SetToolBar(this.strMode);
            this.SetLayout(this.strMode);
            this.SetFocus();
        }

        /// <summary>
        /// 工厂代码参照按钮的点击事件
        /// </summary>
        private void btnFactory_Click(object sender, EventArgs e)
        {
            CodeRef.CodeRefFactory cr = new CodeRef.CodeRefFactory(this.txtCompany.Text);
            cr.AddValueControl(this.txtFactory);
            cr.ShowDialog(this);
            this.txtFactory.Focus();
        }

        /// <summary>
        /// 部门代码参照按钮的点击事件
        /// </summary>
        private void btnDepart_Click(object sender, EventArgs e)
        {
            CodeRef.CodeRefSection cr = new CodeRef.CodeRefSection(this.txtCompany.Text);
            cr.AddValueControl(this.txtDepart);
            cr.AddNameControl(this.lblDepartNM);
            cr.ShowDialog(this);
            this.txtDepart.Focus();
        }
        #endregion

        #region 私有函数

        #region 工具栏控制相关
        /// <summary>
        /// 工具栏按钮显示控制
        /// <param name="strMode">画面模式</param>
        /// </summary>
        private void SetToolBar(string strMode)
        {
            InitToolBar();

            switch (strMode)
            {
                case Constant.MODE_ADD:
                    SetToolBarAdd();
                    break;
                case Constant.MODE_DEL:
                    SetToolBarDel();
                    break;
                case Constant.MODE_UPD:
                    SetToolBarUpd();
                    break;
            }
            this.commonToolStrip1.Update();
        }

        /// <summary>
        /// 工具栏按钮初期化
        /// </summary>
        private void InitToolBar()
        {
            #region 初期化
            this.commonToolStrip1.AddEnabled = true;
            this.commonToolStrip1.AddVisible = true;
            this.commonToolStrip1.DeleteEnabled = true;
            this.commonToolStrip1.DeleteVisible = true;
            this.commonToolStrip1.UpdateEnabled = true;
            this.commonToolStrip1.UpdateVisible = true;
            this.commonToolStrip1.SaveEnabled = false;
            this.commonToolStrip1.SaveVisible = false;
            this.commonToolStrip1.Line1Visible = false;

            this.commonToolStrip1.CopyEnabled = false;
            this.commonToolStrip1.CopyVisible = false;
            this.commonToolStrip1.Line2Visible = false;

            this.commonToolStrip1.ReportEnabled = false;
            this.commonToolStrip1.ReportVisible = false;
            this.commonToolStrip1.CsvEnabled = false;
            this.commonToolStrip1.CsvVisible = false;
            this.commonToolStrip1.Line3Visible = false;

            this.commonToolStrip1.GobackEnabled = false;
            this.commonToolStrip1.GobackVisible = false;
            this.commonToolStrip1.OkEnabled = false;
            this.commonToolStrip1.OkVisible = false;
            this.commonToolStrip1.ExitEnabled = false;
            this.commonToolStrip1.ExitVisible = false;
            this.commonToolStrip1.Line4Visible = false;

            this.commonToolStrip1.HelpEnabled = false;
            this.commonToolStrip1.HelpVisible = false;
            this.commonToolStrip1.Displaytext = true;
            #endregion
        }

        /// <summary>
        /// 追加模式工具栏按钮控制
        /// </summary>
        private void SetToolBarAdd()
        {
            this.commonToolStrip1.SaveEnabled = true;
            this.commonToolStrip1.SaveVisible = true;
            this.commonToolStrip1.Line1Visible = false;
        }

        /// <summary>
        /// 删除模式工具栏按钮控制
        /// </summary>
        private void SetToolBarDel()
        {
            this.commonToolStrip1.Line1Visible = true;
            this.commonToolStrip1.OkEnabled = true;
            this.commonToolStrip1.OkVisible = true;
        }

        /// <summary>
        /// 修正模式工具栏按钮控制
        /// </summary>
        private void SetToolBarUpd()
        {
            this.commonToolStrip1.Line1Visible = true;
            this.commonToolStrip1.OkEnabled = true;
            this.commonToolStrip1.OkVisible = true;
        }

        /// <summary>
        /// G1->G2工具栏按钮控制
        /// </summary>
        private void SetToolBarG1G2()
        {
            this.commonToolStrip1.SaveEnabled = true;
            this.commonToolStrip1.SaveVisible = true;
            this.commonToolStrip1.GobackEnabled = true;
            this.commonToolStrip1.GobackVisible = true;
            this.commonToolStrip1.OkEnabled = false;
            this.commonToolStrip1.OkVisible = false;
        }

        /// <summary>
        /// G2->G1工具栏按钮控制
        /// </summary>
        private void SetToolBarG2G1()
        {
            this.commonToolStrip1.SaveEnabled = false;
            this.commonToolStrip1.SaveVisible = false;
            this.commonToolStrip1.GobackEnabled = false;
            this.commonToolStrip1.GobackVisible = false;
            this.commonToolStrip1.OkEnabled = true;
            this.commonToolStrip1.OkVisible = true;
        }
        #endregion

        #region 画面控件显示相关
        /// <summary>
        /// 根据模式，控制画面上的显示项目
        /// <param name="strMode">画面模式</param>
        /// </summary>
        private void SetLayout(string strMode)
        {
            this.ClearG1();
            this.ClearG2();
            switch (strMode)
            {
                case Constant.MODE_ADD:
                    this.SetLayoutAdd();
                    break;
                case Constant.MODE_DEL:
                    this.SetLayoutDel();
                    break;
                case Constant.MODE_UPD:
                    this.SetLayoutUpd();
                    break;
            }
        }

        /// <summary>
        /// 清空G1部分画面项目的显示内容
        /// </summary>
        private void ClearG1()
        {
            #region G1项目
            //this.txtCompany.Text = "";
            this.lblCompanyNM.Text = "";
            this.txtFactory.Text = "";
            #endregion
        }

        /// <summary>
        /// 清空G2部分画面项目的显示内容
        /// </summary>
        private void ClearG2()
        {
            #region G2项目
            this.txtAbbreviation.Text = "";
            this.txtName.Text = "";
            this.txtPinyin.Text = "";
            this.txtZipCD.Text = "";
            this.cbbCountry.SelectedIndex = 0;
            this.txtAddress1.Text = "";
            this.txtAddress2.Text = "";
            this.txtAddress3.Text = "";
            this.txtTel.Text = "";
            this.txtFax.Text = "";
            this.cbbLanguage.SelectedIndex = 0;
            this.cbbTimezone.SelectedIndex = 0;
            this.txtBase.Text = "";
            this.txtDepart.Text = "";
            this.lblDepartNM.Text = "";
            this.cbbChange.Selectedindex = 0;
            this.txtAutoPeriod.Text = "";
            this.txtStockPeriod.Text = "";
            this.txtArrange.Text = "";
            this.cbbSafe.Selectedindex = 0;
            this.cbbRate.Selectedindex = 0;
            this.cbbPlan.Selectedindex = 0;
            this.cbbCost.Selectedindex = 0;
            this.cbbDecide.Selectedindex = 0;
            #endregion
        }

        private void ClearError()
        {
            this.vdpRequireG1.ValidationMessages(false);
            this.vdpRequireG2.ValidationMessages(false);
            this.vdpExistG1.ValidationMessages(false);
            this.vdpExistG2.ValidationMessages(false);
            this.baseform.msgwindow.Hide();
        }

        /// <summary>
        /// 追加模式，控制画面上的显示项目
        /// </summary>
        private void SetLayoutAdd()
        {
            this.lblMode.Text = ConditionUtils.GetConditionName("ActionMode", "C");
            this.tpG1.Enabled = true;
            this.tpG2.Enabled = true;
            //this.tpG2.Visible = true;
        }

        /// <summary>
        /// 删除模式，控制画面上的显示项目
        /// </summary>
        private void SetLayoutDel()
        {
            this.lblMode.Text = ConditionUtils.GetConditionName("ActionMode", "D");
            this.tpG1.Enabled = true;
            this.tpG2.Enabled = false;
            //this.tpG2.Visible = false;
        }

        /// <summary>
        /// 修改模式，控制画面上的显示项目
        /// </summary>
        private void SetLayoutUpd()
        {
            this.lblMode.Text = ConditionUtils.GetConditionName("ActionMode", "U");
            this.tpG1.Enabled = true;
            this.tpG2.Enabled = false;
            //this.tpG2.Visible = false;
        }

        /// <summary>
        /// G1->G2，控制画面上的显示项目
        /// </summary>
        private void SetLayoutG1G2()
        {
            this.tpG1.Enabled = false;
            this.tpG2.Enabled = true;
            //this.tpG2.Visible = true;
        }

        /// <summary>
        /// G2->G1，控制画面上的显示项目
        /// </summary>
        private void SetLayoutG2G1()
        {
            this.ClearG2();
            this.tpG1.Enabled = true;
            this.tpG2.Enabled = false;
            //this.tpG2.Visible = false;
        }

        /// <summary>
        /// 设置画面上的初期焦点
        /// </summary>
        private void SetFocus()
        {
            if (this.tpG1.Enabled)
            {
                this.txtFactory.Focus();
            }
            else
            {
                this.txtAbbreviation.Focus();
            }
        }
        #endregion

        #region 各种Check
        /// <summary>
        /// 各种Check用Validation初期化
        /// </summary>
        private void Check_Init()
        {
            #region Init
            this.vdpRequireG1 = new ValidationProvider(this.components);
            this.vdpRequireG1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            this.vdpRequireG2 = new ValidationProvider(this.components);
            this.vdpRequireG2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            this.vdpExistG1 = new ValidationProvider(this.components);
            this.vdpExistG1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            this.vdpExistG2 = new ValidationProvider(this.components);
            this.vdpExistG2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            this.vdpCustomG1 = new ValidationProvider(this.components);
            this.vdpCustomG1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            this.vdpCustomG2 = new ValidationProvider(this.components);
            this.vdpCustomG2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            #endregion

            #region vdpRequireG1
            ValidationRule ruleCompany = new ValidationRule();
            ruleCompany.IsRequired = true;
            ruleCompany.RequiredFieldErroMessage = MessageUtils.GetMessage("W0001", this.lblCompany.Text);
            this.vdpRequireG1.SetValidationRule(this.txtCompany, ruleCompany);

            ValidationRule ruleFactory = new ValidationRule();
            ruleFactory.IsRequired = true;
            ruleFactory.RequiredFieldErroMessage = MessageUtils.GetMessage("W0001", this.lblFactory.Text);
            this.vdpRequireG1.SetValidationRule(this.txtFactory, ruleFactory);
            #endregion

            #region vdpRequireG2
            ValidationRule ruleAbbreviation = new ValidationRule();
            ruleAbbreviation.IsRequired = true;
            ruleAbbreviation.RequiredFieldErroMessage = MessageUtils.GetMessage("W0001", this.lblAbbreviation.Text);
            this.vdpRequireG2.SetValidationRule(this.txtAbbreviation, ruleAbbreviation);

            ValidationRule ruleName = new ValidationRule();
            ruleName.IsRequired = true;
            ruleName.RequiredFieldErroMessage = MessageUtils.GetMessage("W0001", this.lblName.Text);
            this.vdpRequireG2.SetValidationRule(this.txtName, ruleName);

            ValidationRule ruleZip = new ValidationRule();
            ruleZip.IsRequired = true;
            ruleZip.RequiredFieldErroMessage = MessageUtils.GetMessage("W0001", this.lblZipCD.Text);
            this.vdpRequireG2.SetValidationRule(this.txtZipCD, ruleZip);

            ValidationRule ruleCountry = new ValidationRule();
            ruleCountry.IsRequired = true;
            ruleCountry.RequiredFieldErroMessage = MessageUtils.GetMessage("W0001", this.lblCountry.Text);
            this.vdpRequireG2.SetValidationRule(this.cbbCountry, ruleCountry);

            ValidationRule ruleAddress = new ValidationRule();
            ruleAddress.IsRequired = true;
            ruleAddress.RequiredFieldErroMessage = MessageUtils.GetMessage("W0001", this.lblAddress1.Text);
            this.vdpRequireG2.SetValidationRule(this.txtAddress1, ruleAddress);

            ValidationRule ruleTel = new ValidationRule();
            ruleTel.IsRequired = true;
            ruleTel.RequiredFieldErroMessage = MessageUtils.GetMessage("W0001", this.lblTel.Text);
            this.vdpRequireG2.SetValidationRule(this.txtTel, ruleTel);

            ValidationRule ruleLanguage = new ValidationRule();
            ruleLanguage.IsRequired = true;
            ruleLanguage.RequiredFieldErroMessage = MessageUtils.GetMessage("W0001", this.lblLanguage.Text);
            this.vdpRequireG2.SetValidationRule(this.cbbLanguage, ruleLanguage);

            ValidationRule ruleTimeZone = new ValidationRule();
            ruleTimeZone.IsRequired = true;
            ruleTimeZone.RequiredFieldErroMessage = MessageUtils.GetMessage("W0001", this.lblTimezone.Text);
            this.vdpRequireG2.SetValidationRule(this.cbbTimezone, ruleTimeZone);

            ValidationRule ruleChange = new ValidationRule();
            ruleChange.IsRequired = true;
            ruleChange.RequiredFieldErroMessage = MessageUtils.GetMessage("W0001", this.lblChange.Text);
            this.vdpRequireG2.SetValidationRule(this.cbbChange, ruleChange);

            ValidationRule ruleAutoPeriod = new ValidationRule();
            ruleAutoPeriod.IsRequired = true;
            ruleAutoPeriod.RequiredFieldErroMessage = MessageUtils.GetMessage("W0001", this.lblAutoPeriod.Text);
            this.vdpRequireG2.SetValidationRule(this.txtAutoPeriod, ruleAutoPeriod);

            ValidationRule ruleStockPeriod = new ValidationRule();
            ruleStockPeriod.IsRequired = true;
            ruleStockPeriod.RequiredFieldErroMessage = MessageUtils.GetMessage("W0001", this.lblStockPeriod.Text);
            this.vdpRequireG2.SetValidationRule(this.txtStockPeriod, ruleStockPeriod);

            ValidationRule ruleArrange = new ValidationRule();
            ruleArrange.IsRequired = true;
            ruleArrange.RequiredFieldErroMessage = MessageUtils.GetMessage("W0001", this.lblArrange.Text);
            this.vdpRequireG2.SetValidationRule(this.txtArrange, ruleArrange);
            #endregion

            #region vdpExistG1
            ValidationRule ruleCompanyExit = new ValidationRule();
            ruleCompanyExit.IsCustomError = true;
            ruleCompanyExit.CustomValidationMethod += new CustomValidationEventHandler(ruleCompanyExit_CustomValidationMethod);
            ruleCompanyExit.CustomErrorMessage = MessageUtils.GetMessage("W0004", this.lblCompany.Text);
            this.vdpExistG1.SetValidationRule(this.txtCompany, ruleCompanyExit);

            ValidationRule ruleFactoryExit = new ValidationRule();
            ruleFactoryExit.IsCustomError = true;
            ruleFactoryExit.CustomValidationMethod += new CustomValidationEventHandler(ruleFactoryExit_CustomValidationMethod);
            ruleFactoryExit.CustomErrorMessage = MessageUtils.GetMessage("W0004", this.lblFactory.Text);
            this.vdpExistG1.SetValidationRule(this.txtFactory, ruleFactoryExit);
            #endregion

            #region vdpExistG2
            ValidationRule ruleDepartExit = new ValidationRule();
            ruleDepartExit.IsCustomError = true;
            ruleDepartExit.CustomValidationMethod += new CustomValidationEventHandler(ruleDepartExit_CustomValidationMethod);
            ruleDepartExit.CustomErrorMessage = MessageUtils.GetMessage("W0004", this.lblDepart.Text);
            this.vdpExistG2.SetValidationRule(this.txtDepart, ruleDepartExit);
            #endregion

            #region vdpCustomG1
            #endregion

            #region vdpCustomG2
            #endregion
        }

        /// <summary>
        /// 企业代码存在Check
        /// </summary>
        private void ruleCompanyExit_CustomValidationMethod(object sender, CustomValidationEventArgs e)
        {
        }

        /// <summary>
        /// 工厂代码存在Check
        /// </summary>
        private void ruleFactoryExit_CustomValidationMethod(object sender, CustomValidationEventArgs e)
        {
            CheckFactory check = new CheckFactory();
            e.IsValid = check.Check01Bool(this.txtFactory.Text);
        }

        /// <summary>
        /// 部门代码存在Check
        /// </summary>
        private void ruleDepartExit_CustomValidationMethod(object sender, CustomValidationEventArgs e)
        {
            CheckSection check = new CheckSection();
            e.IsValid = false;
            this.lblDepartNM.Text = "";
            if (!String.IsNullOrEmpty(this.txtDepart.Text))
            {
                TSectionMs vo = check.Check01Vo(this.txtCompany.Text, this.txtDepart.Text);
                if (vo != null && !String.IsNullOrEmpty(vo.Id.ISectionCd))
                {
                    e.IsValid = true;
                    this.lblDepartNM.Text = vo.ISectionDesc;
                }
            }
            else
            {
                e.IsValid = true;
            }
        }

        /// <summary>
        /// Group1各种Check
        /// </summary>
        private Boolean CheckG1()
        {
            Boolean rtnValue = true;

            if (!this.vdpRequireG1.Validate())
            {
                IList<MessageVo> re = this.vdpRequireG1.ValidationMessages(true);
                this.DialogResult = DialogResult.Abort;
                this.baseform.msgwindow.Messagelist = re;
                this.baseform.msgwindow.ShowMessage();
                rtnValue = false;
            }

            if (rtnValue && !Constant.MODE_ADD.Equals(this.strMode))
            {
                if (!this.vdpExistG1.Validate())
                {
                    IList<MessageVo> re = this.vdpExistG1.ValidationMessages(true);
                    this.DialogResult = DialogResult.Abort;
                    this.baseform.msgwindow.Messagelist = re;
                    this.baseform.msgwindow.ShowMessage();
                    rtnValue = false;
                }
            }

            return rtnValue;
        }

        /// <summary>
        /// Group2各种Check
        /// </summary>
        private Boolean CheckG2()
        {
            Boolean rtnValue = true;

            if (!this.vdpRequireG2.Validate())
            {
                IList<MessageVo> re = this.vdpRequireG2.ValidationMessages(true);
                this.DialogResult = DialogResult.Abort;
                this.baseform.msgwindow.Messagelist = re;
                this.baseform.msgwindow.ShowMessage();
                rtnValue = false;
            }

            if (rtnValue && !Constant.MODE_DEL.Equals(this.strMode))
            {
                if (!this.vdpExistG2.Validate())
                {
                    IList<MessageVo> re = this.vdpExistG2.ValidationMessages(true);
                    this.DialogResult = DialogResult.Abort;
                    this.baseform.msgwindow.Messagelist = re;
                    this.baseform.msgwindow.ShowMessage();
                    rtnValue = false;
                }
            }

            #region 暂时先去掉。Group2的逻辑Check
            //if (rtnValue && !Constant.MODE_DEL.Equals(this.strMode))
            //{
            //    if (!this.vdpCustomG2.Validate())
            //    {
            //        IList<MessageVo> re = this.vdpCustomG2.ValidationMessages(true);
            //        this.DialogResult = DialogResult.Abort;
            //        this.baseform.msgwindow.Messagelist = re;
            //        this.baseform.msgwindow.ShowMessage();
            //        rtnValue = false;
            //    }
            //}
            #endregion

            return rtnValue;
        }
        #endregion

        #region 各种数据处理
        /// <summary>
        /// 根据画面输入条件，抽出数据
        /// </summary>
        private void LoadData()
        {
            IAction_Factory ac = ComponentLocator.Instance().Resolve<IAction_Factory>();
            TFactoryMs facVo = ac.GetFactoryByCd(this.txtFactory.Text);

            this.SetVoToForm(facVo);
        }

        /// <summary>
        /// 根据画面输入内容，更新数据库
        /// </summary>
        private void SaveData()
        {
            IAction_Factory ac = ComponentLocator.Instance().Resolve<IAction_Factory>();
            TFactoryMs facVo = this.getVoFromForm();
            Boolean val = ac.SaveDataToStp(strMode, facVo);
        }

        /// <summary>
        /// 根据EntityVo的值给画面上的控件赋值
        /// </summary>
        private void SetVoToForm(TFactoryMs facVo)
        {
            #region
            this.txtAbbreviation.Text = facVo.IFacArgDesc;
            this.txtName.Text = facVo.IFacDesc;
            this.txtPinyin.Text = facVo.IFacDescKana;
            this.txtZipCD.Text = facVo.IMailNo;
            this.cbbCountry.Selectedvalue = facVo.ICountryCd;
            this.txtAddress1.Text = facVo.IAddress1;
            this.txtAddress2.Text = facVo.IAddress2;
            this.txtAddress3.Text = facVo.IAddress3;
            this.txtTel.Text = facVo.ITel;
            this.txtFax.Text = facVo.IFaxNo;
            this.cbbLanguage.Selectedvalue = facVo.ILanguageCd;
            this.cbbTimezone.Selectedvalue = facVo.ITimezoneCd;
            this.txtBase.Text = facVo.IBaseCd;
            this.txtDepart.Text = facVo.ISectionCd;

            CheckSection secCheck = new CheckSection();
            TSectionMs secVo = secCheck.Check01Vo(this.txtCompany.Text, facVo.ISectionCd);
            if (secVo != null && !String.IsNullOrEmpty(secVo.Id.ISectionCd))
            {
                this.lblDepartNM.Text = secVo.ISectionDesc;
            }
            else
            {
                this.lblDepartNM.Text = "";
            }

            this.cbbChange.Selectedvalue = facVo.IEgChgCls;
            this.txtAutoPeriod.Text = facVo.IMrpPeriod.ToString();
            this.txtStockPeriod.Text = facVo.IAlcPeriod.ToString();
            this.txtArrange.Text = facVo.IPoCreatePeriod.ToString();
            this.cbbSafe.Selectedvalue = facVo.ISafeStockCls;
            this.cbbRate.Selectedvalue = facVo.IRateCls;
            this.cbbPlan.Selectedvalue = facVo.IPlanCrtCls;
            this.cbbCost.Selectedvalue = facVo.IRsltCstCalcCls;
            this.cbbDecide.Selectedvalue = facVo.IPoCreateCls;
            #endregion
        }

        /// <summary>
        /// 根据画面上控件的值，生成EntityVo
        /// </summary>
        private TFactoryMs getVoFromForm()
        {
            TFactoryMs facVo = new TFactoryMs();

            #region
            facVo.ICompanyCd = this.txtCompany.Text;
            facVo.IFacCd = this.txtFactory.Text;
            facVo.IFacArgDesc = this.txtAbbreviation.Text;
            facVo.IFacDesc = this.txtName.Text;
            facVo.IFacDescKana = this.txtPinyin.Text;
            facVo.IMailNo = this.txtZipCD.Text;
            facVo.ICountryCd = this.cbbCountry.Selectedvalue;
            facVo.IAddress1 = this.txtAddress1.Text;
            facVo.IAddress2 = this.txtAddress2.Text;
            facVo.IAddress3 = this.txtAddress3.Text;
            facVo.ITel = this.txtTel.Text;
            facVo.IFaxNo = this.txtFax.Text;
            facVo.ILanguageCd = this.cbbLanguage.Selectedvalue;
            facVo.ITimezoneCd = this.cbbTimezone.Selectedvalue;
            facVo.IBaseCd = this.txtBase.Text;
            facVo.ISectionCd = this.txtDepart.Text;
            facVo.IEgChgCls = this.cbbChange.Selectedvalue;
            facVo.IMrpPeriod = Convert.ToDecimal(this.txtAutoPeriod.Text);
            facVo.IAlcPeriod = Convert.ToDecimal(this.txtStockPeriod.Text);
            facVo.IPoCreatePeriod = Convert.ToDecimal(this.txtArrange.Text);
            facVo.ISafeStockCls = this.cbbSafe.Selectedvalue;
            facVo.IRateCls = this.cbbRate.Selectedvalue;
            facVo.IPlanCrtCls = this.cbbPlan.Selectedvalue;
            facVo.IRsltCstCalcCls = this.cbbCost.Selectedvalue;
            facVo.IPoCreateCls = this.cbbDecide.Selectedvalue;
            #endregion

            return facVo;
        }
        #endregion

        #endregion
    }
}