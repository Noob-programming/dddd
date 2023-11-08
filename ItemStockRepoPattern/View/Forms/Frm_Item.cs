using System;
using DevExpress.XtraEditors;
using ItemStockRepoPattern.Logic.Extension;

namespace ItemStockRepoPattern.View.Forms
{
	public partial class Frm_Item : XtraForm
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
			tB_ItemTableAdapter1.Fill(billsData1.TB_Item);
		}


		private void treeList1_DoubleClick(object sender, EventArgs e)
		{
			GuidHelper.SaveGuid = new Guid
				(treeList1.GetFocusedRowCellValue("itemGuid").ToString());
			var form = new Frm_ItemEdit();
			form.ShowDialog();
			form.Close();
			SetData();
		}
	}
}