using ItemStockRepoPattern.Logic.Extension;
using ItemStockRepoPattern.Logic.Repository;
using ItemStockRepoPattern.Model;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace ItemStockRepoPattern.View.Forms
{
	public partial class Frm_ShoppingCart : DevExpress.XtraEditors.XtraForm
	{
		public Frm_ShoppingCart()
		{
			InitializeComponent();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			AddMember();
		}

		private void AddMember()
		{
			txtPrice.Text = @"0";
			txtQuantity.Text = @"0";
			txtTotal.Text = @"0";

			txtSalesOrderGuid.Text = Guid.Empty.ToString();
			LookBillGuid.EditValue = null;
			LookItemGuid.EditValue = null;

			txtShoppingID.Text = @"0";
		}

		private readonly StoppingCartModel _shoppingCard = new StoppingCartModel();
		private void Frm_ShoppingCart_Load(object sender, EventArgs e)
		{
			GetData();
		}

		private readonly ShoppingRepository _shopping = new ShoppingRepository();

		private void GetData()
		{
			var lookFillBill = _shopping.FillLookBill();


			LookBillGuid.Properties.DataSource = lookFillBill;
			LookBillGuid.Properties.DisplayMember = "Billcode";
			LookBillGuid.Properties.ValueMember = "BillGuid";


			var lookFillItem = _shopping.FillLookItem();

			LookItemGuid.Properties.DataSource = lookFillItem;
			LookItemGuid.Properties.DisplayMember = "itemName";
			LookItemGuid.Properties.ValueMember = "itemGuid";

			gridControl1.DataSource = _shopping.GetAll(); ;

		}

		readonly ItemRepository _repository = new ItemRepository();

		private void LookItemGuid_EditValueChanged(object sender, EventArgs e)
		{
			if (LookItemGuid.EditValue == null) return;
			var res = _repository.GetByGuid(new Guid(LookItemGuid.EditValue.ToString()));

			txtPrice.Text = res.itemPriceSingle.ToString(CultureInfo.InvariantCulture);

		}

		private void txtQuantity_EditValueChanged(object sender, EventArgs e)
		{
			if (txtQuantity.Text == null) return;
			txtTotal.Text =
				(Convert.ToDecimal(txtPrice.Text) * Convert.ToDecimal(txtQuantity.Text)).
				ToString(CultureInfo.InvariantCulture);
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			SetShopping();
			int ch = _shopping.Save(_shoppingCard);

			if (ch == 0)
			{
				MessageBox.Show(@"Error");
			}
			else if (ch == 1)
			{
				MessageBox.Show(@"Add Done");
				GetData(); AddMember();
			}
			else if (ch == 2)
			{
				MessageBox.Show(@"Update Done");
				GetData(); AddMember();
			}
		}

		private void SetShopping()
		{
			_shoppingCard.ItemGuid = new Guid(LookItemGuid.EditValue.ToString());
			_shoppingCard.BillGuid = new Guid(LookBillGuid.EditValue.ToString());
			_shoppingCard.Quantity = Convert.ToDecimal(txtQuantity.Text);
			_shoppingCard.Prices = Convert.ToDecimal(txtPrice.Text);
			_shoppingCard.Total = Convert.ToDecimal(txtTotal.Text);
			_shoppingCard.SalesOrderId = new Guid(txtSalesOrderGuid.Text);
			_shoppingCard.ShoppingOrderId = Convert.ToInt32(txtShoppingID.Text);
		}

		private void simpleButton3_Click(object sender, EventArgs e)
		{
			GuidHelper.SaveGuid = new Guid(txtSalesOrderGuid.Text);
			int ch = _shopping.Delete(GuidHelper.SaveGuid);

			if (ch == 0)
			{
				MessageBox.Show(@"Error");
			}
			else if (ch == 1)
			{
				MessageBox.Show(@"Delete Done");
				GetData(); AddMember();
			}

		}

		private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{
			try
			{

				txtSalesOrderGuid.Text = gridView1.GetFocusedRowCellValue("SalesOrderId").ToString();
				txtPrice.Text = gridView1.GetFocusedRowCellValue("Prices").ToString();
				txtShoppingID.Text = gridView1.GetFocusedRowCellValue("ShoppingOrderId").ToString();

				txtTotal.Text = gridView1.GetFocusedRowCellValue("Total").ToString();
				LookBillGuid.EditValue = gridView1.GetFocusedRowCellValue("BillGuid").ToString();
				LookItemGuid.EditValue = gridView1.GetFocusedRowCellValue("ItemGuid").ToString();

				txtQuantity.Text = gridView1.GetFocusedRowCellValue("Quantity").ToString();
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
				throw;
			}
		}
	}
}