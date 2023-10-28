using ItemStockRepoPattern.Logic.Extension;
using System;

namespace ItemStockRepoPattern.View.Forms
{
	public partial class Frm_Item : DevExpress.XtraEditors.XtraForm
	{
		public Frm_Item()
		{
			InitializeComponent();
		}

		private void Frm_Item_Load(object sender, EventArgs e)
		{
			SetData();
		}

		private void SetData()
		{
			this.tB_ItemTableAdapter.Fill(this.billsDataSet.TB_Item);
		}

		private void treeList1_RowClick(object sender, DevExpress.XtraTreeList.RowClickEventArgs e)
		{
			GuidHelper.SaveGuid = new Guid
				(treeList1.GetFocusedRowCellValue("itemGuid").ToString());
			var form = new Frm_ItemEdit();
			form.ShowDialog();
			form.Close();
		}
	}
}