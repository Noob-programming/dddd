using System;
using DevExpress.XtraEditors;
using ItemStockRepoPattern.Logic.Extension;

namespace ItemStockRepoPattern.View.Forms
{
	public partial class Frm_ParentItem : XtraForm
	{
		public Frm_ParentItem()
		{
			InitializeComponent();

			sqlDataSource1.Fill();
		}

		private void treeList1_DoubleClick(object sender, EventArgs e)
		{
			GuidHelper.SaveGuid = new Guid(treeList1.GetFocusedRowCellValue("itemGuid").ToString());
			Close();
		}
	}
}