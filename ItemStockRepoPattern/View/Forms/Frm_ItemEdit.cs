using ItemStockRepoPattern.Logic.Extension;
using ItemStockRepoPattern.Logic.Repository;
using ItemStockRepoPattern.Model;
using System;
using System.Globalization;
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

		void GetData()
		{
			var r = Repository.FillLookUp().
				ChangeList(x => new ItemModel()
				{
					itemGuid = new Guid(x["itemguid"].ToString()),
					itemName = x["itemName"].ToString(),
					parentGuid = new Guid(x["parentGuid"].ToString()),
				});
			Parent.Properties.DataSource = r;
			Parent.Properties.DisplayMember = "itemName";
			Parent.Properties.ValueMember = "itemGuid";

			item = Repository.GetByGuid(GuidHelper.SaveGuid);
			txtCode.Text = item.itemCode.ToString();

			txtGuid.Text = item.itemGuid.ToString();
			txtName.Text = item.itemName;
			txtPrice.Text = item.itemPrice.ToString(CultureInfo.InvariantCulture);

			txtPriceSingle.Text = item.itemPriceSingle.ToString(CultureInfo.InvariantCulture);
			txtPriceMany.Text = item.itemPriceMany.ToString(CultureInfo.InvariantCulture);
			Parent.EditValue = item.parentGuid.ToString();

			CEGroup.Checked = item.ISgroup;
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
			item.itemGuid = new Guid(txtGuid.Text);
		}

		private void Frm_ItemEdit_Load(object sender, EventArgs e)
		{
			GetData();
		}
	}
}