using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace ItemStockRepoPattern.View.Forms
{
	public partial class Frm_Main : XtraForm
	{
		public Frm_Main()
		{
			InitializeComponent();
		}

		private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
		{
			var f = new Frm_Item();
			f.ShowDialog();
			f.Close();
		}

		private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
		{
			var f = new Frm_Bill();
			f.ShowDialog();
			f.Close();
		}

		private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
		{
			var frm = new Frm_StockItem();
			frm.ShowDialog();
			frm.Close();
		}

		private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
		{
			var frm = new Frm_ShoppingCart();
			frm.ShowDialog();
			frm.Close();
		}
	}
}