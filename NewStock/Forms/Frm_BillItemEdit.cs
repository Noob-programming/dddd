using NewStock.Logic;
using NewStock.Logic.Services;
using NewStock.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace NewStock.Forms
{
	public partial class Frm_BillItemEdit : DevExpress.XtraEditors.XtraForm
	{
		public Frm_BillItemEdit()
		{
			InitializeComponent();
			model = new BillItemModel();
		}

		private void Frm_BillItemEdit_Load(object sender, EventArgs e)
		{
			LookUpFill();
		}



		private BillItemModel model;

		private void LookUpFill()
		{
			DataTable data = DbHelper.GetData("TB_Item_GetItemandName", () => { });
			LookUpItem.Properties.DataSource = data;
			LookUpItem.Properties.DisplayMember = "itemName";
			LookUpItem.Properties.ValueMember = "itemGuid";

			// TB_Bill_GetGuid

			data = DbHelper.GetData("TB_Bill_GetGuid", () => { });
			LookUpBill.Properties.DataSource = data;
			LookUpBill.Properties.DisplayMember = "Billcode";
			LookUpBill.Properties.ValueMember = "BillGuid";

		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			try
			{
				model.Price = decimal.Parse(txtPrice.Text);
				model.Quantity = Convert.ToDecimal(txtQuin.Text);
				model.BillitemID = Convert.ToInt32(txtBillCode.Text);
				model.Total = default;
				model.BillGuid = new Guid(LookUpBill.EditValue.ToString());
				model.ItemGuid = new Guid(LookUpItem.EditValue.ToString());

				model.BillitemGuid = string.IsNullOrEmpty(txtGuid.EditValue.ToString())
					? Guid.Empty : new Guid(txtGuid.EditValue.ToString());
				_check = BillItemService.SaveData(model);
				MessageBox.Show(_check ? @"Save Done" : @"Error Save");
				ClearField();
			}
			catch (Exception exception)
			{
				MessageBox.Show($@"{exception}");
				throw;
			}
		}

		private bool _check;
		private void simpleButton2_Click(object sender, EventArgs e)
		{
			ClearField();
		}

		private void ClearField()
		{
			txtPrice.Text = string.Empty;
			txtQuin.Text = string.Empty;
			txtBillCode.Text = string.Empty;
			txtTotal.Text = string.Empty;
			LookUpBill.EditValue = null;
			LookUpItem.EditValue = null;
			txtGuid.Text = Guid.Empty.ToString();
		}
	}
}