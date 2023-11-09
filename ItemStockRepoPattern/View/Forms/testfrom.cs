using ItemStockRepoPattern.Model;
using System;

namespace ItemStockRepoPattern.View.Forms
{
	public partial class testfrom : DevExpress.XtraEditors.XtraForm
	{
		public testfrom()
		{
			InitializeComponent();
		}

		private void testfrom_Load(object sender, EventArgs e)
		{
			var dd = (ItemModel)itemModelBindingSource.DataSource;
		}
	}
}