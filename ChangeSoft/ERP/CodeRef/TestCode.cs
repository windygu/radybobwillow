﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Com.GainWinSoft.ERP.CodeRef.Action;
using Com.GainWinSoft.Common;
using Com.GainWinSoft.ERP.Entity;

namespace Com.GainWinSoft.ERP.CodeRef
{
    public partial class TestCode : BaseCodeForm
    {
        private List<Control> _lst;
        public TestCode(List<Control> lst)
        {
            InitializeComponent();
            this._lst = lst;

            LoadData();
        }

        private void LoadData()
        {
            IAction_TestCode af = ComponentLocator.Instance().Resolve<IAction_TestCode>();
            IList<MFunctioncatalog> flist = af.GetFunctionDataList();

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");

            foreach (MFunctioncatalog mfvo in flist)
            {
                DataRow dr = dt.NewRow();
                dr[0] = mfvo.Id.Catalogid;
                dr[1] = mfvo.Catalogname;
                dt.Rows.Add(dr);
            }

            this.dgvCode.DataSource = dt;
        }

        private void dgvCode_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = this.dgvCode.CurrentRow;

            this._lst[0].Text = dgvr.Cells[0].Value.ToString();
            this._lst[0].Focus();
            this.Close();
            this.Dispose();
        }
    }
}
