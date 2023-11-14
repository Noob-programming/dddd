using System;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using NewStock.Logic;
using NewStock.Logic.Services;

namespace NewStock.Forms
{
	public partial class Frm_BillItem : XtraForm
	{
		public Frm_BillItem()
		{
			InitializeComponent();
		}

		private void Frm_BillItem_Load(object sender, EventArgs e)
		{
			SetData();
		}

		private void SetData()
		{
			gridControl1.DataSource = BillItemService.GetData("TB_BillItem_GET");
		}

		private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
		{
			SaveGuid.guidSave = SaveGuid.guidSave = new Guid
				(gridView1.GetFocusedRowCellValue("BillitemGuid").ToString());
			var frm = new Frm_BillItem();
			frm.ShowDialog();
			frm.Close();
			SetData();
		}
	}
}