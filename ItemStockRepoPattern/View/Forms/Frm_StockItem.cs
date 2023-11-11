using DevExpress.XtraEditors;
using ItemStockRepoPattern.Logic.Repository;
using ItemStockRepoPattern.Model;
using System;
using System.Windows.Forms;

namespace ItemStockRepoPattern.View.Forms
{
	public partial class Frm_StockItem : XtraForm
	{
		private readonly StockReposition _reposition = new StockReposition();

		private readonly StockReposition _stockReposition = new StockReposition();

		private readonly StockModel stock = new StockModel();

		public Frm_StockItem()
		{
			InitializeComponent();
		}

		private void Frm_StockItem_Load(object sender, EventArgs e)
		{
			SetData();
		}

		private void SetData()
		{
			stockModelBindingSource.DataSource = new StockModel();
			var binding = new BindingSource();
			binding.DataSource = _reposition.GetAll();
			gridControl1.DataSource = binding;

			ItemGuidTextEdit.Properties.DataSource = _reposition.FillLookItem();
			ItemGuidTextEdit.Properties.DisplayMember = "itemName";
			ItemGuidTextEdit.Properties.ValueMember = "itemGuid";
		}


		private void Save_Click(object sender, EventArgs e)
		{
			try
			{
				var re = (StockModel)stockModelBindingSource.DataSource;
				var ch = _stockReposition.Save(re);
				switch (ch)
				{
					case 0:
						MessageBox.Show(@"ERROR");
						break;
					case 1:
						MessageBox.Show(@"Done Insert");
						SetData();
						break;
					case 2:
						MessageBox.Show(@"Done Update");
						SetData();
						break;
				}
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
				var res = (StockModel)stockModelBindingSource.DataSource;
				var re = _stockReposition.Delete(res.ItemGuid);
				switch (re)
				{
					case 0:
						MessageBox.Show(@"Error delete");
						break;
					case 1:
						MessageBox.Show(@"Done Delete");
						SetData();
						break;
				}
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
				throw;
			}
		}

		private void gridView1_DoubleClick(object sender, EventArgs e)
		{
			stockModelBindingSource.DataSource = (StockModel)gridView1.GetRow(gridView1.FocusedRowHandle);
		}

		private void Add_Click(object sender, EventArgs e)
		{
			try
			{
				stockModelBindingSource.DataSource = new StockModel();
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
				throw;
			}
		}
	}
}