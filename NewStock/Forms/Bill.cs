﻿using NewStock.Logic;
using System;

namespace NewStock.Forms
{
	public partial class Bill : DevExpress.XtraEditors.XtraForm
	{
		public Bill()
		{
			InitializeComponent();
			// This line of code is generated by Data Source Configuration Wizard

		}

		private void setData()
		{
			tB_BillTableAdapter1.Fill(billsDB1.TB_Bill);
		}

		private void Bill_Load(object sender, System.EventArgs e)
		{
			setData();
		}

		private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
			SaveGuid.guidSave = new Guid
				(gridView1.GetFocusedRowCellValue("BillGuid").ToString());
			var form = new Frm_Bills();
			form.ShowDialog();
			form.Close();
			setData();
		}
	}
}