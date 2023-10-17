using NewStock.Exten;
using NewStock.Logic;
using NewStock.Logic.Services;
using NewStock.Model;
using System;

namespace NewStock.Forms
{
	public partial class Frm_Bills : DevExpress.XtraEditors.XtraForm
	{
		public Frm_Bills()
		{
			InitializeComponent();
		}



		private void textEdit1_EditValueChanged(object sender, EventArgs e)
		{

		}

		private void Frm_Bills_Load(object sender, EventArgs e)
		{
			SetData(BillService.GetData(SaveGuid.guidSave).changeForItem(x =>
				new BillModel()
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
	}
}