namespace NewStock.Forms
{
	public partial class Frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
	{
		public Frm_Main()
		{
			InitializeComponent();
		}

		private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			var from = new Frm_Info();
			from.ShowDialog();
			from.Close();
		}

		private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Bill vBills = new Bill();
			vBills.ShowDialog();
			vBills.Close();

		}

		private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Frm_Item vItem = new Frm_Item();

			vItem.ShowDialog(); vItem.Close();
		}

		private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			Stock stock = new Stock();
			stock.ShowDialog();
			stock.Close();

		}
	}
}