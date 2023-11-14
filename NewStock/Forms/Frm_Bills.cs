using DevExpress.XtraEditors;
using NewStock.Exten;
using NewStock.Logic;
using NewStock.Logic.Services;
using NewStock.Model;
using System;
using System.Windows.Forms;

namespace NewStock.Forms
{
	public partial class Frm_Bills : XtraForm
	{
		private BillModel _billModel;

		private bool _check;

		public Frm_Bills()
		{
			InitializeComponent();
			_billModel = new BillModel();
		}

		private void Frm_Bills_Load(object sender, EventArgs e)
		{
			SetData(BillService.GetData(SaveGuid.guidSave).ChangeForItem(x =>
				_billModel = new BillModel
				{
					billGuid = Guid.Parse(x["BillGuid"].ToString()),
					Billcode = Convert.ToInt32(x["Billcode"].ToString()),
					billdate = (DateTime)x["BillDate"],
					notes = x["Notes"].ToString(),
					billType = Convert.ToBoolean(x["Type"].ToString() == "Sell")
				}));
		}

		private void SetData(BillModel itemModel)
		{
			txtGuid.Text = itemModel.billGuid.ToString();
			txtCode.Text = itemModel.Billcode.ToString();
			txtNode.Text = itemModel.notes;
			dataBill.DateTime = itemModel.billdate;
			tsType.IsOn = itemModel.billType;
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			_billModel.billGuid = new Guid(txtGuid.Text);
			_billModel.Billcode = Convert.ToInt32(txtCode.Text);
			_billModel.notes = txtNode.Text;
			_billModel.billdate = dataBill.DateTime;
			_billModel.billType = tsType.IsOn;

			_check = BillService.BillExistsSave(_billModel);
			if (_check)
			{
				MessageBox.Show(@"Save Data");
				SetData(new BillModel());
			}
			else
			{
				MessageBox.Show(@"Error Data Save");
			}
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			SetData(new BillModel());
		}

		private void simpleButton3_Click(object sender, EventArgs e)
		{
			SaveGuid.guidSave = _billModel.billGuid;
			_check = BillService.IsDelete(SaveGuid.guidSave);

			if (_check)
			{
				MessageBox.Show(@"Done Delete");
				SetData(new BillModel());
			}
			else
			{
				MessageBox.Show(@"Error Delete");
			}
		}
	}
}