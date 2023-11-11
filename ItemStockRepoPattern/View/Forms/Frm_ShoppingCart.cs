using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ItemStockRepoPattern.Logic.Extension;
using ItemStockRepoPattern.Logic.Repository;
using ItemStockRepoPattern.Model;

namespace ItemStockRepoPattern.View.Forms
{
	public partial class Frm_ShoppingCart : XtraForm
	{
		private readonly ItemRepository _repository = new ItemRepository();

		private readonly ShoppingRepository _shopping = new ShoppingRepository();

		private readonly ShoppingCartModel _shoppingCard = new ShoppingCartModel();

		public Frm_ShoppingCart()
		{
			InitializeComponent();
		}

		private void Frm_ShoppingCart_Load(object sender, EventArgs e)
		{
			GetData();
		}

		private void GetData()
		{
			var lookFillBill = _shopping.FillLookBill();

			BillGuidTextEdit.Properties.DataSource = lookFillBill;
			BillGuidTextEdit.Properties.DisplayMember = "Billcode";
			BillGuidTextEdit.Properties.ValueMember = "BillGuid";


			var lookFillItem = _shopping.FillLookItem();

			ItemGuidTextEdit.Properties.DataSource = lookFillItem;
			ItemGuidTextEdit.Properties.DisplayMember = "itemName";
			ItemGuidTextEdit.Properties.ValueMember = "itemGuid";

			var binding = new BindingSource();
			binding.DataSource = _shopping.GetAll();
			gridControl1.DataSource = binding;
		}


		private void simpleButton3_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(@"are you ready to delete", @"delete", MessageBoxButtons.OKCancel) !=
			    DialogResult.OK) return;
			GuidHelper.SaveGuid = new Guid(SalesOrderIdTextEdit.Text);
			var ch = _shopping.Delete(GuidHelper.SaveGuid);

			switch (ch)
			{
				case 0:
					MessageBox.Show(@"Error");
					break;
				case 1:
					MessageBox.Show(@"Delete Done");
					GetData();

					break;
			}
		}

		private void gridView1_DoubleClick(object sender, EventArgs e)
		{
			stoppingCartModelBindingSource.DataSource = (ShoppingCartModel)gridView1.GetRow(gridView1.FocusedRowHandle);
		}

		private void Save_Click(object sender, EventArgs e)
		{
			try
			{
				var ch = _shopping.Save((ShoppingCartModel)stoppingCartModelBindingSource.DataSource);

				switch (ch)
				{
					case 0:
						MessageBox.Show(@"Error");
						break;
					case 1:
						MessageBox.Show(@"Add Done");
						GetData();

						break;
					case 2:
						MessageBox.Show(@"Update Done");
						GetData();

						break;
				}
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
				throw;
			}
		}

		private void Add_Click(object sender, EventArgs e)
		{
			try
			{
				stoppingCartModelBindingSource.DataSource = new ShoppingCartModel();
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
				throw;
			}
		}

		private void Delete_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("are you ready to delete", "delete", MessageBoxButtons.OKCancel) !=
				    DialogResult.OK) return;
				var a = (ShoppingCartModel)stoppingCartModelBindingSource.DataSource;
				var ch = _shopping.Delete(a.SalesOrderId);
				switch (ch)
				{
					case 0:
						MessageBox.Show(@"Error");
						return;
					case 1:
						MessageBox.Show(@"Done Delete");
						GetData();
						break;
				}
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
				throw;
			}
		}
	}
}