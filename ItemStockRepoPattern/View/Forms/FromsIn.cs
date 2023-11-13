using ItemStockRepoPattern.Logic.Extension;
using ItemStockRepoPattern.Logic.Repository;
using ItemStockRepoPattern.Model;
using System;
using System.Windows.Forms;

namespace ItemStockRepoPattern.View.Forms
{
	public partial class FromsIn : DevExpress.XtraEditors.XtraForm
	{
		public FromsIn()
		{
			InitializeComponent();
		}
		private readonly ItemRepository _repository = new ItemRepository();
		private ItemModel _item = new ItemModel();


		private void SetData()
		{
			var item = _repository.GetByGuid(GuidHelper.SaveGuid);
			DataRepository.SavedItem = item;

			itemModelBindingSource.DataSource = DataRepository.SavedItem;
			var p = _repository.GetByGuid(item.ParentGuid);

			ParentGuidButtonEdit.Text = p.ItemName;
			ParentGuidButtonEdit.Tag = p.ItemGuid;
		}
		private void SaveData()
		{
			if (ParentGuidButtonEdit.Tag is Guid parentGuid)
			{
				DataRepository.SavedItem.ParentGuid = parentGuid;

				if (ParentGuidButtonEdit.EditValue != null)
				{
					if (ParentGuidButtonEdit.EditValue is Guid editValueGuid)
					{
						var result = _repository.Save(DataRepository.SavedItem);

						switch (result)
						{
							case 0:
								MessageBox.Show(@"Error");
								break;
							case 1:
								MessageBox.Show(@"Done Insert");
								break;
							case 2:
								MessageBox.Show(@"Done Update");
								break;
						}
					}
					else
					{
						MessageBox.Show("Invalid EditValue type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("EditValue is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Invalid parent GUID value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void simpleButton1_Click(object sender, EventArgs e)
		{

			try
			{
				SaveData();
				// DataRepository.SavedItem.ParentGuid = (Guid)ParentGuidButtonEdit.Tag;
				//
				//
				// //itemModelBindingSource.DataSource = DataRepository.SavedItem;
				// // _item = (ItemModel)itemModelBindingSource.DataSource;
				// // DataRepository.SavedItem;
				// var ch = _repository.Save(DataRepository.SavedItem);
				// switch (ch)
				// {
				// 	case 0:
				// 		MessageBox.Show(@"Error");
				// 		break;
				// 	case 1:
				// 		MessageBox.Show(@"Done Insert");
				// 		break;
				// 	case 2:
				// 		MessageBox.Show(@"Done UPdate");
				// 		break;
				// }
			}
			catch (Exception exception)
			{
				MessageBox.Show($@"{exception}");
				throw;
			}

		}



		private void ParentGuidButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			var form = new Frm_ParentItem();
			form.ShowDialog();

			var p = _repository.GetByGuid(GuidHelper.SaveGuid);

			ParentGuidButtonEdit.Text = p.ItemName;
			ParentGuidButtonEdit.Tag = p.ItemGuid;
		}

		private void FromsIn_Load(object sender, EventArgs e)
		{
			SetData();
		}
	}
}