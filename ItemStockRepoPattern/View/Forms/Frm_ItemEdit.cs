using System;
using System.Globalization;
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

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				SetItem();
				var ch = _repository.Save(_item);
				if (ch == 0)
				{
					MessageBox.Show(@"Error");
				}
				else if (ch == 1)
				{
					MessageBox.Show(@"Done Insert");
					FillLook();
				}
				else if (ch == 2)
				{
					MessageBox.Show(@"Done UPdate");
					FillLook();
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show($@"{exception}");
				throw;
			}
		}

		private void GetData()
		{
			FillLook();

			_item = _repository.GetByGuid(GuidHelper.SaveGuid);
			txtCode.Text = _item.itemCode.ToString();

			txtGuid.Text = _item.itemGuid.ToString();
			txtName.Text = _item.itemName;
			txtPrice.Text = _item.itemPrice.ToString(CultureInfo.InvariantCulture);

			txtPriceSingle.Text = _item.itemPriceSingle.ToString(CultureInfo.InvariantCulture);
			txtPriceMany.Text = _item.itemPriceMany.ToString(CultureInfo.InvariantCulture);
			LookParent.EditValue = _item.parentGuid.ToString();

			CEGroup.Checked = _item.ISgroup;
		}

		private void FillLook()
		{
			var r = _repository.FillLookItem();
			LookParent.Properties.DataSource = r;
			LookParent.Properties.DisplayMember = "itemName";
			LookParent.Properties.ValueMember = "itemGuid";
		}

		private void SetItem()
		{
			var a = string.IsNullOrEmpty(LookParent.EditValue.ToString())
				? (IComparable)Guid.Empty
				: LookParent.EditValue.ToString();
			_item.parentGuid = new Guid(a.ToString());
			_item.itemName = txtName.Text;
			_item.itemCode = Convert.ToInt32(txtCode.Text);
			_item.itemPrice = Convert.ToDecimal(txtPrice.Text);
			_item.itemPriceSingle = Convert.ToDecimal(txtPriceSingle.Text);
			_item.itemPriceMany = Convert.ToDecimal(txtPriceMany.Text);
			_item.ISgroup = CEGroup.Checked;
			_item.itemGuid = new Guid(txtGuid.Text);
		}

		private void Frm_ItemEdit_Load(object sender, EventArgs e)
		{
			GetData();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			AddMember();
		}

		private void AddMember()
		{
			txtCode.Text = $@"{_repository.GetMaxId()}";

			txtGuid.Text = Guid.Empty.ToString();
			txtName.Text = string.Empty;
			txtPrice.Text = string.Empty;

			txtPriceSingle.Text = string.Empty;
			txtPriceMany.Text = string.Empty;
			LookParent.EditValue = string.Empty;

			CEGroup.Checked = false;
		}
	}
}