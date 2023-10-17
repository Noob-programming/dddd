using NewStock.Exten;
using NewStock.Logic;
using NewStock.Logic.Services;
using NewStock.Model;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace NewStock.Forms
{
	public partial class Frm_ItemForms : DevExpress.XtraEditors.XtraForm
	{
		public Frm_ItemForms()
		{
			InitializeComponent();

		}

		void LookUpdater()
		{

			var r = ItemService.GetParent().ChangeList(x => new
			{
				itemGuid = new Guid(x["itemGuid"].ToString()),
				ParentGuid = new Guid(x["parentGuid"].ToString()),
				itemName = x["itemName"].ToString(),
			});
			txtparentguid.Properties.DataSource = r;
			txtparentguid.Properties.ValueMember = "itemGuid";
			txtparentguid.Properties.DisplayMember = "itemName";



		}

		/*System.Data.DataRowView*/

		private void Frm_ItemForms_Load(object sender, System.EventArgs e)
		{
			LookUpdater();
			SetData(ItemService.GetData(SaveGuid.guidSave).changeForItem(x => new ItemModel
			{
				itemGuid = Guid.Parse(x["itemGuid"].ToString()),
				itemCode = Convert.ToInt32(x["itemcode"].ToString()),
				itemName = x["itemName"].ToString(),
				itemPrice = Convert.ToDecimal(x["itemPrice"].ToString()),
				itemPriceMany = Convert.ToDecimal(x["itemPriceMany"].ToString()),
				itemPriceSingle = Convert.ToDecimal(x["itemPriceSingle"].ToString()),
				parentGuid = Guid.Parse(x["parentGuid"].ToString()),
				isGroup = Convert.ToBoolean(x["ISGroup"].ToString())
			}));

		}


		void SetData(ItemModel dt)
		{
			txtGuid.Text = dt.itemGuid.ToString();
			txtCode.Text = dt.itemCode.ToString();
			txtName.Text = dt.itemName;

			txtparentguid.EditValue = dt.parentGuid.ToString();
			txtPrice.Text = dt.itemPrice.ToString(CultureInfo.InvariantCulture);
			txtPriceSingle.Text = dt.itemPriceSingle.ToString(CultureInfo.InvariantCulture);

			txtPriceMany.Text = dt.itemPriceMany.ToString(CultureInfo.InvariantCulture);
			Group.Checked = dt.isGroup;
		}

		ItemModel Preprocess()
		{
			return new ItemModel()
			{
				parentGuid = new Guid(txtparentguid.EditValue.ToString()),
				itemCode = Convert.ToInt32(txtCode.Text),
				itemGuid = new Guid(txtGuid.Text),
				itemName = txtName.Text,
				itemPrice = Convert.ToDecimal(txtPrice.Text),
				itemPriceMany = Convert.ToDecimal(txtPriceMany.Text),
				itemPriceSingle = Convert.ToDecimal(txtPriceSingle.Text),
				isGroup = Group.Checked
			};
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			try
			{
				bool check = ItemService.IsItem(item: Preprocess());

				if (!check)
				{
					MessageBox.Show(@"Error");
				}

				else
				{
					SetData(new ItemModel());

					LookUpdater();
					MessageBox.Show(@"Delete");
				}
			}
			catch (Exception exception)
			{
				System.Windows.Forms.MessageBox.Show($@"{exception}");
				throw;
			}
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			SetData(new ItemModel());
		}

		private void simpleButton3_Click(object sender, EventArgs e)
		{
			try
			{
				bool check = ItemService.IsDelete(SaveGuid.guidSave);

				if (!check)
				{
					MessageBox.Show(@"Error");
				}

				else
				{
					SetData(new ItemModel());

					LookUpdater();
					MessageBox.Show(@"Delete");
				}

			}
			catch (Exception exception)
			{
				MessageBox.Show($@"{exception}");
				throw;
			}


		}
	}
}