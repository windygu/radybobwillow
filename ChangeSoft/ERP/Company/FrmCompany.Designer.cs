﻿namespace Com.GainWinSoft.ERP.Company
{
    partial class FrmCompany
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompany));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.validationProvider1 = new Noogen.Validation.ValidationProvider(this.components);
            this.clsDetailCodeRefDropDownList1 = new ClsDetailCodeRefDropDownList.ClsDetailCodeRefDropDownList();
            this.xDateTimePicker1 = new Com.GainWinSoft.Common.Control.XDateTimePicker.XDateTimePicker();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // validationProvider1
            // 
            this.validationProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            resources.ApplyResources(this.validationProvider1, "validationProvider1");
            // 
            // clsDetailCodeRefDropDownList1
            // 
            this.clsDetailCodeRefDropDownList1.Autoaddblankitem = true;
            this.clsDetailCodeRefDropDownList1.ClsCd = "D9";
            this.clsDetailCodeRefDropDownList1.Defaultselectedindex = 0;
            resources.ApplyResources(this.clsDetailCodeRefDropDownList1, "clsDetailCodeRefDropDownList1");
            this.clsDetailCodeRefDropDownList1.Name = "clsDetailCodeRefDropDownList1";
            this.clsDetailCodeRefDropDownList1.Selectedindex = -1;
            this.clsDetailCodeRefDropDownList1.Selectedname = null;
            this.clsDetailCodeRefDropDownList1.Selectedvalue = null;
            this.clsDetailCodeRefDropDownList1.ShowNameDesc = false;
            // 
            // xDateTimePicker1
            // 
            resources.ApplyResources(this.xDateTimePicker1, "xDateTimePicker1");
            this.xDateTimePicker1.Name = "xDateTimePicker1";

            // 
            // FrmCompany
            // 
            resources.ApplyResources(this, "$this");
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.ControlBox = false;
            this.Controls.Add(this.xDateTimePicker1);
            this.Controls.Add(this.clsDetailCodeRefDropDownList1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompany";
            this.Load += new System.EventHandler(this.FrmCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private Noogen.Validation.ValidationProvider validationProvider1;
        private ClsDetailCodeRefDropDownList.ClsDetailCodeRefDropDownList clsDetailCodeRefDropDownList1;
        private Com.GainWinSoft.Common.Control.XDateTimePicker.XDateTimePicker xDateTimePicker1;
    }
}
