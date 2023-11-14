using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace NewStock.Forms
{
	public partial class Frm_Main : RibbonForm
	{
		public Frm_Main()
		{
			InitializeComponent();
		}

		private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
		{
			var from = new Frm_Info();
			from.ShowDialog();
			from.Close();
		}

		private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
		{
			var vBills = new Bill();
			vBills.ShowDialog();
			vBills.Close();
		}

		private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
		{
			var vItem = new Frm_Item();

			vItem.ShowDialog();
			vItem.Close();
		}

		private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
		{
			var stock = new Stock();
			stock.ShowDialog();
			stock.Close();
		}
	}
}