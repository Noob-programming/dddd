using ItemStockRepoPattern.Logic.Repository;
using ItemStockRepoPattern.Model;
using System;
using System.Windows.Forms;

namespace ItemStockRepoPattern.View.Forms
{
	public partial class Frm_ItemEdit : DevExpress.XtraEditors.XtraForm
	{
		public Frm_ItemEdit()
		{
			InitializeComponent();
		}
		ItemRepository Repository = new ItemRepository();
		ItemModel item = new ItemModel();

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				SetItem();
				bool check = Repository.Save(item);
				MessageBox.Show(check ? "Done" : "Error");
			}
			catch (Exception exception)
			{
				System.Windows.Forms.MessageBox.Show($@"{exception}");
				throw;
			}

		}

		private void SetItem()
		{
			item.parentGuid = Guid.Empty;
			item.itemName = txtName.Text;
			item.itemCode = Convert.ToInt32(txtCode.Text);
			item.itemPrice = Convert.ToDecimal(txtPrice.Text);
			item.itemPriceSingle = Convert.ToDecimal(txtPriceSingle.Text);
			item.itemPriceMany = Convert.ToDecimal(txtPriceMany.Text);
			item.ISgroup = CEGroup.Checked;
			item.itemGuid = Guid.Empty;
		}
	}
}