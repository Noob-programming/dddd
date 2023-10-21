using NewStock.Logic;
using NewStock.Logic.Services;
using System;

namespace NewStock.Forms
{
	public partial class Frm_BillItem : DevExpress.XtraEditors.XtraForm
	{
		public Frm_BillItem()
		{
			InitializeComponent();
		}

		private void Frm_BillItem_Load(object sender, EventArgs e)
		{
			SetData();
		}

		void SetData()
		{
			gridControl1.DataSource = BillItemService.GetData("TB_BillItem_GET");
		}

		private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
		{
			SaveGuid.guidSave = SaveGuid.guidSave = new Guid
				(gridView1.GetFocusedRowCellValue("BillitemGuid").ToString());
			Frm_BillItem frm = new Frm_BillItem();
			frm.ShowDialog();
			frm.Close();
			SetData();
		}
	}
}