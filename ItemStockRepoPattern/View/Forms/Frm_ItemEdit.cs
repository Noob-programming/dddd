using DevExpress.XtraEditors;
using ItemStockRepoPattern.Logic.Repository;
using ItemStockRepoPattern.Model;
using System;
using System.Windows.Forms;

namespace ItemStockRepoPattern.View.Forms
{
	public partial class Frm_ItemEdit : XtraForm
	{
		private readonly ItemRepository _repository = new ItemRepository();
		private ItemModel _item = new ItemModel();


		public Frm_ItemEdit()
		{
			InitializeComponent();
		}

		void SetData()
		{
			itemModelBindingSource.DataSource = new ItemModel();
		}

		private void Frm_ItemEdit_Load(object sender, EventArgs e)
		{
			SetData();
		}



		private void AddMember()
		{
			itemModelBindingSource = null;
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			try
			{
				_item = (ItemModel)itemModelBindingSource.DataSource;
				var ch = _repository.Save(_item);
				if (ch == 0)
				{
					MessageBox.Show(@"Error");
				}
				else if (ch == 1)
				{
					MessageBox.Show(@"Done Insert");

				}
				else if (ch == 2)
				{
					MessageBox.Show(@"Done UPdate");

				}
			}
			catch (Exception exception)
			{
				MessageBox.Show($@"{exception}");
				throw;
			}
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			AddMember();
		}

		private void simpleButton3_Click(object sender, EventArgs e)
		{
			try
			{
				_item = (ItemModel)itemModelBindingSource.DataSource;

				int ch = _repository.Delete(_item.itemGuid);
				if (ch == 0)
				{
					MessageBox.Show(@"Error");
				}
				else if (ch == 1)
				{
					MessageBox.Show(@"Done Insert");

				}
				else if (ch == 2)
				{
					MessageBox.Show(@"Done UPdate");

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