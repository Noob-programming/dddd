using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Windows.Forms;

namespace StockMarcte
{
	public partial class BillItem : XtraForm
	{
		private readonly Bills bills = new Bills();



		public BillItem()
		{
			InitializeComponent();
		}

		private void BillItem_Load(object sender, EventArgs e)
		{
			getdata();
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
			bills.Billguid = !string.IsNullOrEmpty(txtguid.Text) ? Guid.Parse(txtguid.Text) : Guid.Empty;
			bills.DateTime = DateBill.DateTime;
			bills.billcode = Convert.ToInt32(Billcode.Text);
			bills.notes = txtNotes.Text;
			bills.billtye = Convert.ToBoolean(toggleSwitch1.EditValue.ToString());

			var re = DbHelper.ExcuteData("TB_Bill_Save",
				() => Executable.parmterBill(bills, DbHelper.cmd));

			if (re) getdata();
			MessageBox.Show(re ? "save" : "error");
		}

		private void getdata()
		{
			gridControl1.DataSource = DbHelper.GetData("TB_Bill_GET");
		}

		private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
		{
			Billcode.Text = gridView1.GetFocusedRowCellValue("Billcode").ToString();
			DateBill.Text = gridView1.GetFocusedRowCellValue("BillDate").ToString();
			txtNotes.Text = gridView1.GetFocusedRowCellValue("Notes").ToString();
			toggleSwitch1.IsOn = gridView1.GetFocusedRowCellValue("Type").ToString() == "Buy";
			txtguid.Text = gridView1.GetFocusedRowCellValue("BillGuid").ToString();
		}

		private void Deletes_Click(object sender, EventArgs e)
		{
			var re = DbHelper.ExcuteData
				("TB_Bill_Delete", () => Executable.ParameterDelete(bills, DbHelper.cmd));

			if (re) getdata();
			MessageBox.Show(re ? "save" : "error");
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			Billcode.Text = String.Empty;
			DateBill.Text = String.Empty;
			txtNotes.Text = String.Empty;
			toggleSwitch1.IsOn = false;
			txtguid.Text = String.Empty;
		}
	}
}