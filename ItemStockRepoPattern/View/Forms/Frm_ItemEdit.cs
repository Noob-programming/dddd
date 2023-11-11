using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ItemStockRepoPattern.Logic.Extension;
using ItemStockRepoPattern.Logic.Repository;
using ItemStockRepoPattern.Model;

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

		private void SetData()
		{
			itemModelBindingSource.DataSource = _repository.GetByGuid(GuidHelper.SaveGuid);
			parentGuidTextEdit.Properties.DataSource = _repository.FillLookItem();
			parentGuidTextEdit.Properties.DisplayMember = "itemName";
			parentGuidTextEdit.Properties.ValueMember = "itemGuid";
		}

		private void Frm_ItemEdit_Load(object sender, EventArgs e)
		{
			SetData();
		}


		private void AddMember()
		{
			itemModelBindingSource.DataSource = new ItemModel();
			parentGuidTextEdit.Properties.DataSource = _repository.FillLookItem();
			parentGuidTextEdit.Properties.DisplayMember = "itemName";
			parentGuidTextEdit.Properties.ValueMember = "itemGuid";
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			try
			{
				_item = (ItemModel)itemModelBindingSource.DataSource;
				var ch = _repository.Save(_item);
				switch (ch)
				{
					case 0:
						MessageBox.Show(@"Error");
						break;
					case 1:
						MessageBox.Show(@"Done Insert");
						break;
					case 2:
						MessageBox.Show(@"Done UPdate");
						break;
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
			try
			{
				AddMember();
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception);
				throw;
			}
		}

		private void simpleButton3_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("are you ready to delete", "delete", MessageBoxButtons.OKCancel) !=
				    DialogResult.OK) return;
				_item = (ItemModel)itemModelBindingSource.DataSource;

				var ch = _repository.Delete(_item.itemGuid);
				switch (ch)
				{
					case 0:
						MessageBox.Show(@"Error");
						break;
					case 1:
						MessageBox.Show(@"Done Insert");
						break;
					case 2:
						MessageBox.Show(@"Done UPdate");
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